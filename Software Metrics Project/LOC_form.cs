using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Metrics_Project
{
    public partial class LOC_form : Form
    {
        double LOC;
        public LOC_form()
        {
            InitializeComponent();
        }

        private void TCFformBackBtn_Click(object sender, EventArgs e)
        {
            //We need to pass the FP value also back to the TCF form as a parameter so that it doesn't crash 
            values.factorScale.Clear();
            TCF_form f = new TCF_form();
            f.Show();
            this.Hide();
        }
        private void LOC_form_Load(object sender, EventArgs e)
        {
            locLabel.AutoSize = false;
            locLabel.Height = 51;
            locLabel.Width = 70;
            locLabel.Location = new Point(20, 430);
            locLabel.TextAlign = ContentAlignment.MiddleCenter;
            locLabel.Margin = new Padding(15, 15, 15, 15);
            //Row spacing
            int itemHeight = 25;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, itemHeight);
            languagesView.SmallImageList = imgList;
            /////////////
            languagesView.Columns.Add("Programming language", 335, HorizontalAlignment.Center);
            languagesView.Columns.Add("LOC/FP (average)", 335, HorizontalAlignment.Center);
            ListViewItem lang1 = new ListViewItem("Assembly");
            lang1.SubItems.Add("320");
            lang1.BackColor = Color.LightGray;
            ListViewItem lang2 = new ListViewItem("C");
            lang2.SubItems.Add("128");
            ListViewItem lang3 = new ListViewItem("COBOL/Fortran");
            lang3.SubItems.Add("105");
            lang3.BackColor = Color.LightGray;
            ListViewItem lang4 = new ListViewItem("Pascal");
            lang4.SubItems.Add("90");
            ListViewItem lang5 = new ListViewItem("Ada");
            lang5.SubItems.Add("70");
            lang5.BackColor = Color.LightGray;
            ListViewItem lang6 = new ListViewItem("C++");
            lang6.SubItems.Add("64");
            ListViewItem lang7 = new ListViewItem("Visual Basic");
            lang7.SubItems.Add("32");
            lang7.BackColor = Color.LightGray;
            ListViewItem lang8 = new ListViewItem("Object Oriented Languages");
            lang8.SubItems.Add("30");
            ListViewItem lang9 = new ListViewItem("Smalltalk");
            lang9.SubItems.Add("22");
            lang9.BackColor = Color.LightGray;
            ListViewItem lang10 = new ListViewItem("Code Generators (PowerBuilder)");
            lang10.SubItems.Add("15");
            ListViewItem lang11 = new ListViewItem("SQL/Oracle");
            lang11.SubItems.Add("12");
            lang11.BackColor = Color.LightGray;
            ListViewItem lang12 = new ListViewItem("Spreadsheets");
            lang12.SubItems.Add("6");
            ListViewItem lang13 = new ListViewItem("Graphical Languages (icons)");
            lang13.SubItems.Add("4");
            lang13.BackColor = Color.LightGray;
            languagesView.Items.Add(lang1);
            languagesView.Items.Add(lang2);
            languagesView.Items.Add(lang3);
            languagesView.Items.Add(lang4);
            languagesView.Items.Add(lang5);
            languagesView.Items.Add(lang6);
            languagesView.Items.Add(lang7);
            languagesView.Items.Add(lang8);
            languagesView.Items.Add(lang9);
            languagesView.Items.Add(lang10);
            languagesView.Items.Add(lang11);
            languagesView.Items.Add(lang12);
            languagesView.Items.Add(lang13);
            languagesView.MultiSelect = false;
            languagesView.FullRowSelect = true;


            languagesView.Focus();
            languagesView.Select();
            languagesView.Items[0].Selected = true;
            languagesView.Items[0].Focused = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void calculateLOC(object sender, EventArgs e)
        {
            LOC = TCF_form.FP * double.Parse(languagesView.SelectedItems[0].SubItems[1].Text);
            LOCbox.Text = LOC.ToString();
        }

        private void languagesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (languagesView.SelectedItems.Count == 0)
                return;
            calculateLOC(null, null);
        }

    }
}
