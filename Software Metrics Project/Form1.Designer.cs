namespace Software_Metrics_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.TCFformBtn = new System.Windows.Forms.Button();
            this.calculateUFPbtn = new System.Windows.Forms.Button();
            this.UFPbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(612, 419);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(630, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(61, 63);
            this.addButton.TabIndex = 1;
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // TCFformBtn
            // 
            this.TCFformBtn.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCFformBtn.Location = new System.Drawing.Point(576, 451);
            this.TCFformBtn.Name = "TCFformBtn";
            this.TCFformBtn.Size = new System.Drawing.Size(114, 42);
            this.TCFformBtn.TabIndex = 2;
            this.TCFformBtn.Text = "Proceed";
            this.TCFformBtn.UseVisualStyleBackColor = true;
            this.TCFformBtn.Click += new System.EventHandler(this.TCFformBtn_Click);
            // 
            // calculateUFPbtn
            // 
            this.calculateUFPbtn.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateUFPbtn.Location = new System.Drawing.Point(10, 451);
            this.calculateUFPbtn.Name = "calculateUFPbtn";
            this.calculateUFPbtn.Size = new System.Drawing.Size(114, 42);
            this.calculateUFPbtn.TabIndex = 3;
            this.calculateUFPbtn.Text = "Calculate UFP";
            this.calculateUFPbtn.UseVisualStyleBackColor = true;
            this.calculateUFPbtn.Click += new System.EventHandler(this.calculateUFPbtn_Click);
            // 
            // UFPbox
            // 
            this.UFPbox.Enabled = false;
            this.UFPbox.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFPbox.Location = new System.Drawing.Point(130, 451);
            this.UFPbox.Multiline = true;
            this.UFPbox.Name = "UFPbox";
            this.UFPbox.Size = new System.Drawing.Size(114, 41);
            this.UFPbox.TabIndex = 4;
            this.UFPbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 506);
            this.Controls.Add(this.UFPbox);
            this.Controls.Add(this.calculateUFPbtn);
            this.Controls.Add(this.TCFformBtn);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button TCFformBtn;
        private System.Windows.Forms.Button calculateUFPbtn;
        private System.Windows.Forms.TextBox UFPbox;
    }
}

