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
            this.calculateTCFbtn = new System.Windows.Forms.Button();
            this.FPbox = new System.Windows.Forms.TextBox();
            this.calculateFPbtn = new System.Windows.Forms.Button();
            this.LOCformBtn = new System.Windows.Forms.Button();
            this.form1_backbtn = new System.Windows.Forms.Button();
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
            // calculateTCFbtn
            // 
            this.calculateTCFbtn.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTCFbtn.Location = new System.Drawing.Point(454, 14);
            this.calculateTCFbtn.Name = "calculateTCFbtn";
            this.calculateTCFbtn.Size = new System.Drawing.Size(114, 41);
            this.calculateTCFbtn.TabIndex = 5;
            this.calculateTCFbtn.Text = "Calculate TCF";
            this.calculateTCFbtn.UseVisualStyleBackColor = true;
            this.calculateTCFbtn.Click += new System.EventHandler(this.calculateTCFbtn_Click);
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
            // calculateFPbtn
            // 
            this.calculateFPbtn.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateFPbtn.Location = new System.Drawing.Point(454, 71);
            this.calculateFPbtn.Name = "calculateFPbtn";
            this.calculateFPbtn.Size = new System.Drawing.Size(114, 41);
            this.calculateFPbtn.TabIndex = 7;
            this.calculateFPbtn.Text = "Calculate FP";
            this.calculateFPbtn.UseVisualStyleBackColor = true;
            this.calculateFPbtn.Click += new System.EventHandler(this.calculateFPbtn_Click);
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
            // TCF_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 506);
            this.Controls.Add(this.form1_backbtn);
            this.Controls.Add(this.LOCformBtn);
            this.Controls.Add(this.FPbox);
            this.Controls.Add(this.calculateFPbtn);
            this.Controls.Add(this.TCFbox);
            this.Controls.Add(this.calculateTCFbtn);
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
        private System.Windows.Forms.Button calculateTCFbtn;
        private System.Windows.Forms.TextBox FPbox;
        private System.Windows.Forms.Button calculateFPbtn;
        private System.Windows.Forms.Button LOCformBtn;
        private System.Windows.Forms.Button form1_backbtn;
    }
}