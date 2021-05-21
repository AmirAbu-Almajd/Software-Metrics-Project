namespace Software_Metrics_Project
{
    partial class TCF_form
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TCFbox = new System.Windows.Forms.TextBox();
            this.FPbox = new System.Windows.Forms.TextBox();
            this.LOCformBtn = new System.Windows.Forms.Button();
            this.form1_backbtn = new System.Windows.Forms.Button();
            this.tcfLabel = new System.Windows.Forms.Label();
            this.fpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 480);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TCFbox
            // 
            this.TCFbox.Enabled = false;
            this.TCFbox.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCFbox.Location = new System.Drawing.Point(574, 14);
            this.TCFbox.Multiline = true;
            this.TCFbox.Name = "TCFbox";
            this.TCFbox.Size = new System.Drawing.Size(114, 41);
            this.TCFbox.TabIndex = 6;
            this.TCFbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FPbox
            // 
            this.FPbox.Enabled = false;
            this.FPbox.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPbox.Location = new System.Drawing.Point(574, 71);
            this.FPbox.Multiline = true;
            this.FPbox.Name = "FPbox";
            this.FPbox.Size = new System.Drawing.Size(114, 41);
            this.FPbox.TabIndex = 8;
            this.FPbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LOCformBtn
            // 
            this.LOCformBtn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOCformBtn.Location = new System.Drawing.Point(454, 118);
            this.LOCformBtn.Name = "LOCformBtn";
            this.LOCformBtn.Size = new System.Drawing.Size(234, 66);
            this.LOCformBtn.TabIndex = 9;
            this.LOCformBtn.Text = "Proceed";
            this.LOCformBtn.UseVisualStyleBackColor = true;
            this.LOCformBtn.Click += new System.EventHandler(this.LOCformBtn_Click);
            // 
            // form1_backbtn
            // 
            this.form1_backbtn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1_backbtn.Location = new System.Drawing.Point(454, 190);
            this.form1_backbtn.Name = "form1_backbtn";
            this.form1_backbtn.Size = new System.Drawing.Size(234, 66);
            this.form1_backbtn.TabIndex = 10;
            this.form1_backbtn.Text = "Back";
            this.form1_backbtn.UseVisualStyleBackColor = true;
            this.form1_backbtn.Click += new System.EventHandler(this.form1_backbtn_Click);
            // 
            // tcfLabel
            // 
            this.tcfLabel.AutoSize = true;
            this.tcfLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tcfLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcfLabel.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcfLabel.Location = new System.Drawing.Point(512, 28);
            this.tcfLabel.Name = "tcfLabel";
            this.tcfLabel.Size = new System.Drawing.Size(54, 29);
            this.tcfLabel.TabIndex = 11;
            this.tcfLabel.Text = "TCF";
            // 
            // fpLabel
            // 
            this.fpLabel.AutoSize = true;
            this.fpLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpLabel.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpLabel.Location = new System.Drawing.Point(512, 85);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(37, 29);
            this.fpLabel.TabIndex = 12;
            this.fpLabel.Text = "FP";
            // 
            // TCF_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 506);
            this.Controls.Add(this.fpLabel);
            this.Controls.Add(this.tcfLabel);
            this.Controls.Add(this.form1_backbtn);
            this.Controls.Add(this.LOCformBtn);
            this.Controls.Add(this.FPbox);
            this.Controls.Add(this.TCFbox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TCF_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCF_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.TCF_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TCFbox;
        private System.Windows.Forms.TextBox FPbox;
        private System.Windows.Forms.Button LOCformBtn;
        private System.Windows.Forms.Button form1_backbtn;
        private System.Windows.Forms.Label tcfLabel;
        private System.Windows.Forms.Label fpLabel;
    }
}