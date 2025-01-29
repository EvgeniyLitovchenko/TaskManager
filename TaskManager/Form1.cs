using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            cb_change.Items.AddRange(new string[]
            {
            "Idle",
            "BelowNormal",
            "Normal",
            "AboveNormal",
            "High",
            "RealTime"
            });
            cb_change.SelectedIndex = 2;
            LoadProcesses();
        }

        private List<Process> GetProcessesList()
        {
            return Process.GetProcesses().ToList();
        }

        private void UpdateProcessList()
        {
            var processes = GetProcessesList();
            dataGridView.Rows.Clear();

            foreach (var proc in processes)
            {
                try
                {
                    dataGridView.Rows.Add(
                        proc.Id,
                        proc.ProcessName,
                        proc.WorkingSet64 / 1024 / 1024 + " MB",
                        proc.PriorityClass.ToString(),
                        proc.Threads.Count,
                        proc.StartTime
                    );
                }
                catch
                {
                    continue;
                }
            }
        }

        private void RestoreSelection(int selectedRowIndex, int scrollPosition)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView.Rows.Count)
            {
                dataGridView.Rows[selectedRowIndex].Selected = true;
            }

            if (scrollPosition >= 0 && scrollPosition < dataGridView.Rows.Count)
            {
                dataGridView.FirstDisplayedScrollingRowIndex = scrollPosition;
            }
        }

        private void LoadProcesses()
        {
            int selectedRowIndex = dataGridView.SelectedRows.Count > 0 ? dataGridView.SelectedRows[0].Index : -1;
            int currentScrollPosition = dataGridView.FirstDisplayedScrollingRowIndex;

            UpdateProcessList();
            RestoreSelection(selectedRowIndex, currentScrollPosition);
        }



        private void btn_Start_Click(object sender, EventArgs e)
        {
            panelComand.Visible = true;
            tb_command.Clear();
            tb_command.Focus();
        }
        private bool TryGetSelectedProcess(out Process process)
        {
            process = null;

            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть процес.");
                return false;
            }

            try
            {
                int processId = (int)dataGridView.SelectedRows[0].Cells["ColumnId"].Value;
                process = Process.GetProcessById(processId);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка доступу до процесу: {ex.Message}");
                return false;
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (TryGetSelectedProcess(out Process process))
            {
                try
                {
                    process.Kill();
                    MessageBox.Show($"Процес {process.ProcessName} було зупинено.");
                    LoadProcesses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка зупинки процесу: {ex.Message}");
                }
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (TryGetSelectedProcess(out Process process))
            {
                panelPriority.Visible = true;
                panelPriority.Tag = process;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (panelPriority.Tag is Process process)
            {
                try
                {
                    string selectedPriority = cb_change.SelectedItem.ToString();
                    ProcessPriorityClass newPriority;

                    switch (selectedPriority)
                    {
                        case "Idle":
                            newPriority = ProcessPriorityClass.Idle;
                            break;
                        case "BelowNormal":
                            newPriority = ProcessPriorityClass.BelowNormal;
                            break;
                        case "Normal":
                            newPriority = ProcessPriorityClass.Normal;
                            break;
                        case "AboveNormal":
                            newPriority = ProcessPriorityClass.AboveNormal;
                            break;
                        case "High":
                            newPriority = ProcessPriorityClass.High;
                            break;
                        case "RealTime":
                            newPriority = ProcessPriorityClass.RealTime;
                            break;
                        default:
                            throw new InvalidOperationException("Невідомий пріоритет.");
                    }

                    process.PriorityClass = newPriority;
                    MessageBox.Show($"Пріоритет процесу {process.ProcessName} змінено на {selectedPriority}.");
                    LoadProcesses();
                    panelPriority.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка зміни пріоритету: {ex.Message}");
                }
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = Process.Start(tb_command.Text);
                if (process != null)
                {
                    LoadProcesses();
                    panelComand.Visible = false;
                    MessageBox.Show($"Процес {process.ProcessName} запущено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка запуску процесу: {ex.Message}");
            }
        }


        private void btn_exitC_Click(object sender, EventArgs e)
        {
            panelComand.Visible = false;
        }

        private void btn_exitP_Click(object sender, EventArgs e)
        {
            panelPriority.Visible = false;
            cb_change.SelectedIndex = 2;
        }
    }
}
