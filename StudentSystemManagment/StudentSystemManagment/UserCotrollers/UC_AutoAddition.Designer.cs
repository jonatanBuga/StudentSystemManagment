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
            this.btnAutoS = new System.Windows.Forms.Button();
            this.successAuto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAutoS
            // 
            this.btnAutoS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAutoS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAutoS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutoS.Location = new System.Drawing.Point(240, 108);
            this.btnAutoS.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnAutoS.Name = "btnAutoS";
            this.btnAutoS.Size = new System.Drawing.Size(214, 113);
            this.btnAutoS.TabIndex = 1;
            this.btnAutoS.Text = "Add Auto Student";
            this.btnAutoS.UseVisualStyleBackColor = false;
            this.btnAutoS.Click += new System.EventHandler(this.btnAutoS_Click);
            // 
            // successAuto
            // 
            this.successAuto.AutoSize = true;
            this.successAuto.BackColor = System.Drawing.Color.Transparent;
            this.successAuto.ForeColor = System.Drawing.Color.SteelBlue;
            this.successAuto.Location = new System.Drawing.Point(298, 256);
            this.successAuto.MinimumSize = new System.Drawing.Size(90, 40);
            this.successAuto.Name = "successAuto";
            this.successAuto.Size = new System.Drawing.Size(90, 40);
            this.successAuto.TabIndex = 2;
            // 
            // UC_AutoAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.successAuto);
            this.Controls.Add(this.btnAutoS);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "UC_AutoAddition";
            this.Size = new System.Drawing.Size(699, 350);
            this.Load += new System.EventHandler(this.UC_AutoAddition_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label buga;
        private Button btnAutoS;
        private Label successAuto;
    }
}
