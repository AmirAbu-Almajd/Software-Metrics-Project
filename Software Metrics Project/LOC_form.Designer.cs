namespace Software_Metrics_Project
{
    partial class LOC_form
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
            this.LOCbox = new System.Windows.Forms.TextBox();
            this.calculateLOCbtn = new System.Windows.Forms.Button();
            this.TCFformBackBtn = new System.Windows.Forms.Button();
            this.languagesView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LOCbox
            // 
            this.LOCbox.Enabled = false;
            this.LOCbox.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOCbox.Location = new System.Drawing.Point(201, 431);
            this.LOCbox.Multiline = true;
            this.LOCbox.Name = "LOCbox";
            this.LOCbox.Size = new System.Drawing.Size(161, 52);
            this.LOCbox.TabIndex = 7;
            this.LOCbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateLOCbtn
            // 
            this.calculateLOCbtn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateLOCbtn.Location = new System.Drawing.Point(12, 430);
            this.calculateLOCbtn.Name = "calculateLOCbtn";
            this.calculateLOCbtn.Size = new System.Drawing.Size(183, 53);
            this.calculateLOCbtn.TabIndex = 6;
            this.calculateLOCbtn.Text = "Calculate LOC";
            this.calculateLOCbtn.UseVisualStyleBackColor = true;
            this.calculateLOCbtn.Click += new System.EventHandler(this.calculateLOCbtn_Click);
            // 
            // TCFformBackBtn
            // 
            this.TCFformBackBtn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCFformBackBtn.Location = new System.Drawing.Point(529, 430);
            this.TCFformBackBtn.Name = "TCFformBackBtn";
            this.TCFformBackBtn.Size = new System.Drawing.Size(161, 53);
            this.TCFformBackBtn.TabIndex = 5;
            this.TCFformBackBtn.Text = "Back";
            this.TCFformBackBtn.UseVisualStyleBackColor = true;
            this.TCFformBackBtn.Click += new System.EventHandler(this.TCFformBackBtn_Click);
            // 
            // languagesView
            // 
            this.languagesView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.languagesView.Location = new System.Drawing.Point(12, 12);
            this.languagesView.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.languagesView.Name = "languagesView";
            this.languagesView.Size = new System.Drawing.Size(678, 389);
            this.languagesView.TabIndex = 8;
            this.languagesView.UseCompatibleStateImageBehavior = false;
            this.languagesView.View = System.Windows.Forms.View.Details;
            this.languagesView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.languagesView_ItemSelectionChanged);
            // 
            // LOC_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 506);
            this.Controls.Add(this.languagesView);
            this.Controls.Add(this.LOCbox);
            this.Controls.Add(this.calculateLOCbtn);
            this.Controls.Add(this.TCFformBackBtn);
            this.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LOC_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOC_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.LOC_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LOCbox;
        private System.Windows.Forms.Button calculateLOCbtn;
        private System.Windows.Forms.Button TCFformBackBtn;
        private System.Windows.Forms.ListView languagesView;
    }
}