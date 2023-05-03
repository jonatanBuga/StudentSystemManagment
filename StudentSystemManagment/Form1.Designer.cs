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
            PictureBox pictureBox1;
            panel1 = new Panel();
            label1 = new Label();
            ButtonPanel = new Panel();
            btnReport = new Button();
            btnAuto = new Button();
            btnAdd = new Button();
            MainPanel = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ButtonPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.Clock;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.PastedGraphic_1__3_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.BackgroundImage = Properties.Resources.PastedGraphic_11;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 79);
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
            label1.Size = new Size(0, 22);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(btnReport);
            ButtonPanel.Controls.Add(btnAuto);
            ButtonPanel.Controls.Add(btnAdd);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 79);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(699, 100);
            ButtonPanel.TabIndex = 1;
            ButtonPanel.Paint += ButtonPanel_Paint;
            // 
            // btnReport
            // 
            btnReport.BackgroundImage = Properties.Resources.report;
            btnReport.BackgroundImageLayout = ImageLayout.Stretch;
            btnReport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.Location = new Point(471, 0);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(225, 100);
            btnReport.TabIndex = 1;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnAuto
            // 
            btnAuto.BackgroundImage = Properties.Resources.auto;
            btnAuto.BackgroundImageLayout = ImageLayout.Stretch;
            btnAuto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuto.Location = new Point(3, 0);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(232, 100);
            btnAuto.TabIndex = 2;
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImage = Properties.Resources.STU;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(236, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(232, 100);
            btnAdd.TabIndex = 0;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 179);
            MainPanel.MinimumSize = new Size(699, 500);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(699, 500);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
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