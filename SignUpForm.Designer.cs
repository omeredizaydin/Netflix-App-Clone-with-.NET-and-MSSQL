
namespace netflixApp
{
    partial class SignUpForm
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
            this.btnSeethePlans = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.planForm1 = new netflixApp.PlanForm();
            this.seePlanForm1 = new netflixApp.SeePlanForm();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeethePlans
            // 
            this.btnSeethePlans.BackColor = System.Drawing.Color.Red;
            this.btnSeethePlans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeethePlans.FlatAppearance.BorderSize = 0;
            this.btnSeethePlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeethePlans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeethePlans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeethePlans.Location = new System.Drawing.Point(381, 532);
            this.btnSeethePlans.Name = "btnSeethePlans";
            this.btnSeethePlans.Size = new System.Drawing.Size(338, 51);
            this.btnSeethePlans.TabIndex = 12;
            this.btnSeethePlans.Text = "See the Plans";
            this.btnSeethePlans.UseVisualStyleBackColor = false;
            this.btnSeethePlans.Click += new System.EventHandler(this.btnSeethePlans_Click);
            // 
            // planForm1
            // 
            this.planForm1.Location = new System.Drawing.Point(255, 57);
            this.planForm1.Name = "planForm1";
            this.planForm1.Size = new System.Drawing.Size(644, 420);
            this.planForm1.TabIndex = 13;
            // 
            // seePlanForm1
            // 
            this.seePlanForm1.Location = new System.Drawing.Point(-4, -2);
            this.seePlanForm1.Name = "seePlanForm1";
            this.seePlanForm1.Size = new System.Drawing.Size(1146, 801);
            this.seePlanForm1.TabIndex = 14;
            this.seePlanForm1.Load += new System.EventHandler(this.seePlanForm1_Load);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Red;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinue.Location = new System.Drawing.Point(381, 532);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(338, 51);
            this.btnContinue.TabIndex = 15;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 797);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.seePlanForm1);
            this.Controls.Add(this.planForm1);
            this.Controls.Add(this.btnSeethePlans);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeethePlans;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PlanForm planForm1;
        private SeePlanForm seePlanForm1;
        private System.Windows.Forms.Button btnContinue;
    }
}