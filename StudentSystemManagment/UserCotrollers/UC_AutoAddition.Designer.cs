namespace StudentSystemManagment.UserCotrollers
{
    partial class UC_AutoAddition
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAutoS = new Button();
            successAuto = new Label();
            SuspendLayout();
            // 
            // btnAutoS
            // 
            btnAutoS.BackColor = Color.LightSteelBlue;
            btnAutoS.BackgroundImageLayout = ImageLayout.Stretch;
            btnAutoS.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutoS.ForeColor = SystemColors.ButtonFace;
            btnAutoS.Location = new Point(281, 150);
            btnAutoS.MinimumSize = new Size(50, 50);
            btnAutoS.Name = "btnAutoS";
            btnAutoS.Size = new Size(214, 113);
            btnAutoS.TabIndex = 1;
            btnAutoS.Text = "Add Auto Student";
            btnAutoS.UseVisualStyleBackColor = false;
            btnAutoS.Click += button1_Click;
            // 
            // successAuto
            // 
            successAuto.AutoSize = true;
            successAuto.BackColor = Color.Transparent;
            successAuto.ForeColor = SystemColors.ButtonHighlight;
            successAuto.Location = new Point(117, 161);
            successAuto.MinimumSize = new Size(90, 40);
            successAuto.Name = "successAuto";
            successAuto.Size = new Size(90, 40);
            successAuto.TabIndex = 2;
            // 
            // UC_AutoAddition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PastedGraphic_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(successAuto);
            Controls.Add(btnAutoS);
            DoubleBuffered = true;
            MinimumSize = new Size(500, 100);
            Name = "UC_AutoAddition";
            Size = new Size(699, 396);
            Load += UC_AutoAddition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label buga;
        private Button btnAutoS;
        private Label successAuto;
    }
}
