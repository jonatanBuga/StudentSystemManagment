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
            btnAutoS.Location = new Point(261, 143);
            btnAutoS.MinimumSize = new Size(50, 50);
            btnAutoS.Name = "btnAutoS";
            btnAutoS.Size = new Size(170, 82);
            btnAutoS.TabIndex = 1;
            btnAutoS.Text = "Add auto student";
            btnAutoS.UseVisualStyleBackColor = true;
            btnAutoS.Click += button1_Click;
            // 
            // successAuto
            // 
            successAuto.AutoSize = true;
            successAuto.Location = new Point(24, 228);
            successAuto.MinimumSize = new Size(500, 150);
            successAuto.Name = "successAuto";
            successAuto.Size = new Size(500, 150);
            successAuto.TabIndex = 2;
            successAuto.Click += successAuto_Click;
            // 
            // UC_AutoAddition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(successAuto);
            Controls.Add(btnAutoS);
            MinimumSize = new Size(500, 100);
            Name = "UC_AutoAddition";
            Size = new Size(699, 396);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label buga;
        private Button btnAutoS;
        private Label successAuto;
    }
}
