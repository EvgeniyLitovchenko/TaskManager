namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProcces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPotoks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.panelPriority = new System.Windows.Forms.Panel();
            this.btn_exitP = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cb_change = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelComand = new System.Windows.Forms.Panel();
            this.btn_exitC = new System.Windows.Forms.Button();
            this.tb_command = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelPriority.SuspendLayout();
            this.panelComand.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnProcces,
            this.ColumnRAM,
            this.ColumnPriority,
            this.ColumnPotoks,
            this.ColumnDateTime});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(730, 345);
            this.dataGridView.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 125;
            // 
            // ColumnProcces
            // 
            this.ColumnProcces.HeaderText = "Назва процесу";
            this.ColumnProcces.MinimumWidth = 6;
            this.ColumnProcces.Name = "ColumnProcces";
            this.ColumnProcces.ReadOnly = true;
            this.ColumnProcces.Width = 125;
            // 
            // ColumnRAM
            // 
            this.ColumnRAM.HeaderText = "Память";
            this.ColumnRAM.MinimumWidth = 6;
            this.ColumnRAM.Name = "ColumnRAM";
            this.ColumnRAM.ReadOnly = true;
            this.ColumnRAM.Width = 125;
            // 
            // ColumnPriority
            // 
            this.ColumnPriority.HeaderText = "Пріоритет";
            this.ColumnPriority.MinimumWidth = 6;
            this.ColumnPriority.Name = "ColumnPriority";
            this.ColumnPriority.ReadOnly = true;
            this.ColumnPriority.Width = 125;
            // 
            // ColumnPotoks
            // 
            this.ColumnPotoks.HeaderText = "Кількість потоків";
            this.ColumnPotoks.MinimumWidth = 6;
            this.ColumnPotoks.Name = "ColumnPotoks";
            this.ColumnPotoks.ReadOnly = true;
            this.ColumnPotoks.Width = 125;
            // 
            // ColumnDateTime
            // 
            this.ColumnDateTime.HeaderText = "Час запуску";
            this.ColumnDateTime.MinimumWidth = 6;
            this.ColumnDateTime.Name = "ColumnDateTime";
            this.ColumnDateTime.ReadOnly = true;
            this.ColumnDateTime.Width = 125;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.Location = new System.Drawing.Point(12, 363);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(241, 70);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Запустити";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.MistyRose;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.Location = new System.Drawing.Point(259, 363);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(241, 70);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Видалити";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.SystemColors.Info;
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_change.Location = new System.Drawing.Point(506, 363);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(236, 70);
            this.btn_change.TabIndex = 3;
            this.btn_change.Text = "Змінити пріоритет";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // panelPriority
            // 
            this.panelPriority.Controls.Add(this.btn_exitP);
            this.panelPriority.Controls.Add(this.btn_confirm);
            this.panelPriority.Controls.Add(this.cb_change);
            this.panelPriority.Controls.Add(this.label1);
            this.panelPriority.Location = new System.Drawing.Point(259, 139);
            this.panelPriority.Name = "panelPriority";
            this.panelPriority.Size = new System.Drawing.Size(246, 155);
            this.panelPriority.TabIndex = 4;
            this.panelPriority.Visible = false;
            // 
            // btn_exitP
            // 
            this.btn_exitP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exitP.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_exitP.Location = new System.Drawing.Point(198, 6);
            this.btn_exitP.Name = "btn_exitP";
            this.btn_exitP.Size = new System.Drawing.Size(34, 35);
            this.btn_exitP.TabIndex = 6;
            this.btn_exitP.Text = "❌";
            this.btn_exitP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exitP.UseVisualStyleBackColor = true;
            this.btn_exitP.Click += new System.EventHandler(this.btn_exitP_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_confirm.Location = new System.Drawing.Point(15, 94);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(217, 49);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Підтвердити";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // cb_change
            // 
            this.cb_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_change.FormattingEnabled = true;
            this.cb_change.Location = new System.Drawing.Point(15, 47);
            this.cb_change.Name = "cb_change";
            this.cb_change.Size = new System.Drawing.Size(217, 28);
            this.cb_change.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть пріоритет";
            // 
            // panelComand
            // 
            this.panelComand.Controls.Add(this.btn_exitC);
            this.panelComand.Controls.Add(this.tb_command);
            this.panelComand.Controls.Add(this.btn_Run);
            this.panelComand.Controls.Add(this.label2);
            this.panelComand.Location = new System.Drawing.Point(259, 139);
            this.panelComand.Name = "panelComand";
            this.panelComand.Size = new System.Drawing.Size(246, 155);
            this.panelComand.TabIndex = 5;
            this.panelComand.Visible = false;
            // 
            // btn_exitC
            // 
            this.btn_exitC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exitC.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_exitC.Location = new System.Drawing.Point(199, 6);
            this.btn_exitC.Name = "btn_exitC";
            this.btn_exitC.Size = new System.Drawing.Size(34, 35);
            this.btn_exitC.TabIndex = 5;
            this.btn_exitC.Text = "❌";
            this.btn_exitC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exitC.UseVisualStyleBackColor = true;
            this.btn_exitC.Click += new System.EventHandler(this.btn_exitC_Click);
            // 
            // tb_command
            // 
            this.tb_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_command.Location = new System.Drawing.Point(15, 48);
            this.tb_command.Name = "tb_command";
            this.tb_command.Size = new System.Drawing.Size(218, 27);
            this.tb_command.TabIndex = 4;
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Run.Location = new System.Drawing.Point(13, 93);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(220, 49);
            this.btn_Run.TabIndex = 3;
            this.btn_Run.Text = "Виконати";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введіть команду";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 438);
            this.Controls.Add(this.panelComand);
            this.Controls.Add(this.panelPriority);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "`";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelPriority.ResumeLayout(false);
            this.panelPriority.PerformLayout();
            this.panelComand.ResumeLayout(false);
            this.panelComand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProcces;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPotoks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.Panel panelPriority;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cb_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelComand;
        private System.Windows.Forms.TextBox tb_command;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exitC;
        private System.Windows.Forms.Button btn_exitP;
    }
}

