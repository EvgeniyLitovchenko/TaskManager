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

        private void LoadProcesses()
        {
            int selectedRowIndex = -1;
            if (dataGridView.SelectedRows.Count > 0)
            {
                selectedRowIndex = dataGridView.SelectedRows[0].Index;
            }

            int currentScrollPosition = dataGridView.FirstDisplayedScrollingRowIndex;

            var processes = Process.GetProcesses();
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
                catch (Exception ex)
                {
                    continue;
                }
            }

            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView.Rows.Count)
            {
                dataGridView.Rows[selectedRowIndex].Selected = true;
            }

            if (currentScrollPosition >= 0 && currentScrollPosition < dataGridView.Rows.Count)
            {
                dataGridView.FirstDisplayedScrollingRowIndex = currentScrollPosition;
            }
        }


        private void btn_Start_Click(object sender, EventArgs e)
        {
            panelComand.Visible = true;
            tb_command.Clear();
            tb_command.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int processId = (int)dataGridView.SelectedRows[0].Cells["ColumnId"].Value;
                    Process process = Process.GetProcessById(processId);
                    MessageBox.Show($"Процес {process.ProcessName} було зупинено.");
                    process.Kill();
                    LoadProcesses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка зупинки процесу: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Оберіть процес для зупинки.");
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int processId = (int)dataGridView.SelectedRows[0].Cells["ColumnId"].Value;
                    Process process = Process.GetProcessById(processId);

                    panelPriority.Visible = true;
                    panelPriority.Tag = process;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка доступу до процесу: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Оберіть процес для зміни пріоритету.");
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
