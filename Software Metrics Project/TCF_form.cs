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
    public partial class TCF_form : Form
    {
        int i = 0;
        //These lists contain all the technical complexity factors and their ratings that are chosen by the user
        List<ComboBox> Ratings = new List<ComboBox>();
        public TCF_form()
        {
            InitializeComponent();
        }

        private void TCF_form_Load(object sender, EventArgs e)
        {
            Ratings.Add(addRatingBox(i));
            Label l1 = addFactorsLabel(i++, "Data communications");
            Ratings.Add(addRatingBox(i));
            Label l2 = addFactorsLabel(i++, "Distributed data processing");
            Ratings.Add(addRatingBox(i));
            Label l3 = addFactorsLabel(i++, "Performance");
            Ratings.Add(addRatingBox(i));
            Label l4 = addFactorsLabel(i++, "Heavily used configuration");
            Ratings.Add(addRatingBox(i));
            Label l5 = addFactorsLabel(i++, "Transaction rate");
            Ratings.Add(addRatingBox(i));
            Label l6 = addFactorsLabel(i++, "On-Line data entry");
            Ratings.Add(addRatingBox(i));
            Label l7 = addFactorsLabel(i++, "End-user efficiency");
            Ratings.Add(addRatingBox(i));
            Label l8 = addFactorsLabel(i++, "On-Line update");
            Ratings.Add(addRatingBox(i));
            Label l9 = addFactorsLabel(i++, "Complex processing");
            Ratings.Add(addRatingBox(i));
            Label l10 = addFactorsLabel(i++, "Reusability");
            Ratings.Add(addRatingBox(i));
            Label l11 = addFactorsLabel(i++, "Installation ease");
            Ratings.Add(addRatingBox(i));
            Label l12 = addFactorsLabel(i++, "Operational ease");
            Ratings.Add(addRatingBox(i));
            Label l13 = addFactorsLabel(i++, "Multiple sites");
            Ratings.Add(addRatingBox(i));
            Label l14 = addFactorsLabel(i++, "Facilitate change");
            i = 0;
            flowLayoutPanel1.Controls.Add(l1);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l2);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l3);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l4);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l5);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l6);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l7);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l8);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l9);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l10);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l11);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l12);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l13);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
            flowLayoutPanel1.Controls.Add(l14);
            flowLayoutPanel1.Controls.Add(Ratings[i++]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        ComboBox addRatingBox(int i)
        {
            ComboBox cmb = new ComboBox();
            cmb.Name = "RatingsComboBox" + i.ToString();
            cmb.Items.AddRange(new string[] { "No Influence","Incidental","Moderate","Average","Significant","Essential" });
            cmb.Width = 170;
            cmb.Height = 70;
            cmb.SelectedIndex = 0;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            return cmb;
        }

        Label addFactorsLabel(int i , String placeHolder)
        {
            Label l = new Label();
            l.Name = "Factors label" + i.ToString();
            l.Text = placeHolder;
            l.Width = 220;
            l.Height = 30;
            l.Margin = new Padding(0,5,0,5);
            l.TextAlign = ContentAlignment.MiddleCenter;
            return l;
        }

        private void LOCformBtn_Click(object sender, EventArgs e)
        {
            //We need to pass the FP value to the next form as parameter for the next calculations
            LOC_form f = new LOC_form();
            this.Hide();
            f.Show();
        }

        private void form1_backbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void calculateTCFbtn_Click(object sender, EventArgs e)
        {
            //Calculate the TCF using the rating values of the factors chosen by the user
        }

        private void calculateFPbtn_Click(object sender, EventArgs e)
        {
            //Calculate the FP
        }
    }
}
