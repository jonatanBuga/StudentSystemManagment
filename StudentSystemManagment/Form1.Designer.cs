namespace StudentSystemManagment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            ButtonPanel = new Panel();
            btnReport = new Button();
            btnAuto = new Button();
            btnAdd = new Button();
            MainPanel = new Panel();
            panel1.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 71);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 21);
            label1.Name = "label1";
            label1.Size = new Size(250, 22);
            label1.TabIndex = 0;
            label1.Text = "Student System Managment";
            label1.Click += label1_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(btnReport);
            ButtonPanel.Controls.Add(btnAuto);
            ButtonPanel.Controls.Add(btnAdd);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 71);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(699, 59);
            ButtonPanel.TabIndex = 1;
            ButtonPanel.Paint += ButtonPanel_Paint;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.Location = new Point(480, 0);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(216, 59);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report Export";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnAuto
            // 
            btnAuto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuto.Location = new Point(238, 0);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(230, 59);
            btnAuto.TabIndex = 2;
            btnAuto.Text = "Auto Addition";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(232, 59);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 130);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(699, 396);
            MainPanel.TabIndex = 2;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 526);
            Controls.Add(MainPanel);
            Controls.Add(ButtonPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel ButtonPanel;
        private Panel MainPanel;
        private Button btnReport;
        private Button btnAuto;
        private Button btnAdd;
    }
}