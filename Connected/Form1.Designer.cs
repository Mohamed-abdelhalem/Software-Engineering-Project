
namespace Connected
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
            this.name_text = new System.Windows.Forms.TextBox();
            this.compname_text = new System.Windows.Forms.TextBox();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.desc_tex = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.stat_text = new System.Windows.Forms.TextBox();
            this.date_text = new System.Windows.Forms.TextBox();
            this.alljobs_cmb = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.responds_btn = new System.Windows.Forms.Button();
            this.responds_cmb = new System.Windows.Forms.ComboBox();
            this.jobId_cmb = new System.Windows.Forms.ComboBox();
            this.jobId_hidden_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.Button();
            this.addfav = new System.Windows.Forms.Button();
            this.feed_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.feed_cmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cv_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.Location = new System.Drawing.Point(221, 17);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(224, 31);
            this.name_text.TabIndex = 5;
            // 
            // compname_text
            // 
            this.compname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compname_text.Location = new System.Drawing.Point(727, 169);
            this.compname_text.Name = "compname_text";
            this.compname_text.ReadOnly = true;
            this.compname_text.Size = new System.Drawing.Size(195, 31);
            this.compname_text.TabIndex = 6;
            // 
            // Apply_btn
            // 
            this.Apply_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Apply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_btn.Location = new System.Drawing.Point(580, 224);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(139, 42);
            this.Apply_btn.TabIndex = 7;
            this.Apply_btn.Text = "Apply";
            this.Apply_btn.UseVisualStyleBackColor = false;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // desc_tex
            // 
            this.desc_tex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_tex.HideSelection = false;
            this.desc_tex.Location = new System.Drawing.Point(239, 169);
            this.desc_tex.Multiline = true;
            this.desc_tex.Name = "desc_tex";
            this.desc_tex.ReadOnly = true;
            this.desc_tex.Size = new System.Drawing.Size(191, 36);
            this.desc_tex.TabIndex = 10;
            // 
            // pass_text
            // 
            this.pass_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_text.Location = new System.Drawing.Point(727, 17);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(218, 31);
            this.pass_text.TabIndex = 11;
            // 
            // stat_text
            // 
            this.stat_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_text.Location = new System.Drawing.Point(221, 438);
            this.stat_text.Name = "stat_text";
            this.stat_text.ReadOnly = true;
            this.stat_text.Size = new System.Drawing.Size(158, 31);
            this.stat_text.TabIndex = 18;
            // 
            // date_text
            // 
            this.date_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_text.Location = new System.Drawing.Point(727, 438);
            this.date_text.Name = "date_text";
            this.date_text.ReadOnly = true;
            this.date_text.Size = new System.Drawing.Size(263, 31);
            this.date_text.TabIndex = 21;
            // 
            // alljobs_cmb
            // 
            this.alljobs_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alljobs_cmb.FormattingEnabled = true;
            this.alljobs_cmb.Location = new System.Drawing.Point(315, 100);
            this.alljobs_cmb.Name = "alljobs_cmb";
            this.alljobs_cmb.Size = new System.Drawing.Size(234, 33);
            this.alljobs_cmb.TabIndex = 22;
            this.alljobs_cmb.SelectedIndexChanged += new System.EventHandler(this.alljobs_cmd_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(916, 494);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 37);
            this.back.TabIndex = 24;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // responds_btn
            // 
            this.responds_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.responds_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responds_btn.Location = new System.Drawing.Point(40, 372);
            this.responds_btn.Name = "responds_btn";
            this.responds_btn.Size = new System.Drawing.Size(224, 37);
            this.responds_btn.TabIndex = 25;
            this.responds_btn.Text = "Display responds";
            this.responds_btn.UseVisualStyleBackColor = false;
            this.responds_btn.Click += new System.EventHandler(this.responds_btn_Click);
            // 
            // responds_cmb
            // 
            this.responds_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responds_cmb.FormattingEnabled = true;
            this.responds_cmb.Location = new System.Drawing.Point(315, 376);
            this.responds_cmb.Name = "responds_cmb";
            this.responds_cmb.Size = new System.Drawing.Size(207, 33);
            this.responds_cmb.TabIndex = 26;
            this.responds_cmb.SelectedIndexChanged += new System.EventHandler(this.responds_cmb_SelectedIndexChanged);
            // 
            // jobId_cmb
            // 
            this.jobId_cmb.FormattingEnabled = true;
            this.jobId_cmb.Location = new System.Drawing.Point(590, 385);
            this.jobId_cmb.Name = "jobId_cmb";
            this.jobId_cmb.Size = new System.Drawing.Size(121, 21);
            this.jobId_cmb.TabIndex = 27;
            // 
            // jobId_hidden_cmb
            // 
            this.jobId_hidden_cmb.FormattingEnabled = true;
            this.jobId_hidden_cmb.Location = new System.Drawing.Point(580, 109);
            this.jobId_hidden_cmb.Name = "jobId_hidden_cmb";
            this.jobId_hidden_cmb.Size = new System.Drawing.Size(121, 21);
            this.jobId_hidden_cmb.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(494, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(45, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 37);
            this.label5.TabIndex = 31;
            this.label5.Text = "Display jobs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(45, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(450, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "Company Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(45, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 37);
            this.label6.TabIndex = 34;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(450, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 37);
            this.label7.TabIndex = 35;
            this.label7.Text = "Interview Date";
            // 
            // feedback
            // 
            this.feedback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback.Location = new System.Drawing.Point(851, 308);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(139, 42);
            this.feedback.TabIndex = 36;
            this.feedback.Text = "Feedback";
            this.feedback.UseVisualStyleBackColor = false;
            this.feedback.Click += new System.EventHandler(this.feedback_Click);
            // 
            // addfav
            // 
            this.addfav.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addfav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfav.Location = new System.Drawing.Point(790, 224);
            this.addfav.Name = "addfav";
            this.addfav.Size = new System.Drawing.Size(155, 42);
            this.addfav.TabIndex = 37;
            this.addfav.Text = "Add to fav";
            this.addfav.UseVisualStyleBackColor = false;
            this.addfav.Click += new System.EventHandler(this.addfav_Click);
            // 
            // feed_text
            // 
            this.feed_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feed_text.Location = new System.Drawing.Point(580, 308);
            this.feed_text.Multiline = true;
            this.feed_text.Name = "feed_text";
            this.feed_text.Size = new System.Drawing.Size(219, 36);
            this.feed_text.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(45, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 37);
            this.label8.TabIndex = 39;
            this.label8.Text = "All Feedback";
            // 
            // feed_cmb
            // 
            this.feed_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feed_cmb.FormattingEnabled = true;
            this.feed_cmb.Location = new System.Drawing.Point(300, 308);
            this.feed_cmb.Name = "feed_cmb";
            this.feed_cmb.Size = new System.Drawing.Size(249, 33);
            this.feed_cmb.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(50, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 37);
            this.label9.TabIndex = 41;
            this.label9.Text = "link Cv";
            // 
            // cv_text
            // 
            this.cv_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv_text.Location = new System.Drawing.Point(239, 230);
            this.cv_text.Name = "cv_text";
            this.cv_text.Size = new System.Drawing.Size(271, 31);
            this.cv_text.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Connected.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1032, 543);
            this.Controls.Add(this.cv_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.feed_cmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.feed_text);
            this.Controls.Add(this.addfav);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobId_hidden_cmb);
            this.Controls.Add(this.jobId_cmb);
            this.Controls.Add(this.responds_cmb);
            this.Controls.Add(this.responds_btn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.alljobs_cmb);
            this.Controls.Add(this.date_text);
            this.Controls.Add(this.stat_text);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.desc_tex);
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.compname_text);
            this.Controls.Add(this.name_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox compname_text;
        private System.Windows.Forms.Button Apply_btn;
        private System.Windows.Forms.TextBox desc_tex;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox stat_text;
        private System.Windows.Forms.TextBox date_text;
        private System.Windows.Forms.ComboBox alljobs_cmb;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button responds_btn;
        private System.Windows.Forms.ComboBox responds_cmb;
        private System.Windows.Forms.ComboBox jobId_cmb;
        private System.Windows.Forms.ComboBox jobId_hidden_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button addfav;
        private System.Windows.Forms.TextBox feed_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox feed_cmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cv_text;
    }
}

