
namespace Connected
{
    partial class Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.reg_btn = new System.Windows.Forms.Button();
            this.applicant = new System.Windows.Forms.Button();
            this.company = new System.Windows.Forms.Button();
            this.R1 = new System.Windows.Forms.Button();
            this.R2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reg_btn
            // 
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Location = new System.Drawing.Point(406, 48);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(230, 60);
            this.reg_btn.TabIndex = 0;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // applicant
            // 
            this.applicant.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicant.Location = new System.Drawing.Point(406, 135);
            this.applicant.Name = "applicant";
            this.applicant.Size = new System.Drawing.Size(230, 60);
            this.applicant.TabIndex = 1;
            this.applicant.Text = "Applicant";
            this.applicant.UseVisualStyleBackColor = true;
            this.applicant.Click += new System.EventHandler(this.applicant_Click);
            // 
            // company
            // 
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.SystemColors.Desktop;
            this.company.Location = new System.Drawing.Point(406, 227);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(230, 60);
            this.company.TabIndex = 2;
            this.company.Text = "Company";
            this.company.UseVisualStyleBackColor = true;
            this.company.Click += new System.EventHandler(this.company_Click);
            // 
            // R1
            // 
            this.R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.R1.Location = new System.Drawing.Point(406, 316);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(230, 60);
            this.R1.TabIndex = 3;
            this.R1.Text = "Report1";
            this.R1.UseVisualStyleBackColor = true;
            this.R1.Click += new System.EventHandler(this.R1_Click);
            // 
            // R2
            // 
            this.R2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.R2.Location = new System.Drawing.Point(406, 405);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(230, 60);
            this.R2.TabIndex = 4;
            this.R2.Text = "Report2";
            this.R2.UseVisualStyleBackColor = true;
            this.R2.Click += new System.EventHandler(this.R2_Click);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 543);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.company);
            this.Controls.Add(this.applicant);
            this.Controls.Add(this.reg_btn);
            this.Name = "Gui";
            this.Text = "Gui";
            this.Load += new System.EventHandler(this.Gui_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Button applicant;
        private System.Windows.Forms.Button company;
        private System.Windows.Forms.Button R1;
        private System.Windows.Forms.Button R2;
    }
}