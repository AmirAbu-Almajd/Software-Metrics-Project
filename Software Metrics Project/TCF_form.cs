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
        double TCF;
        public static double FP;
        int i = 0;
        //These lists contain all the technical complexity factors and their ratings that are chosen by the user
        static values value = new values();
        List<ComboBox> Ratings = new List<ComboBox>();
        public TCF_form()
        {
            InitializeComponent();
        }

        private void TCF_form_Load(object sender, EventArgs e)
        {
            tcfLabel.AutoSize = false; 
            tcfLabel.Location = new Point(456, 14);
            tcfLabel.Height = 40;
            tcfLabel.Width = 114;
            tcfLabel.TextAlign = ContentAlignment.MiddleCenter;
            fpLabel.AutoSize = false;
            fpLabel.Location = new Point(456, 71);
            fpLabel.Height = 40;
            fpLabel.Width = 114;
            setAllLabel.AutoSize = false;
            setAllLabel.Location = new Point(456, 283);
            setAllLabel.Height = 22;
            setAllLabel.Width = 114;
            setAllLabel.TextAlign = ContentAlignment.MiddleCenter;
            allBox.Items.AddRange(new string[] { "No Influence", "Incidental", "Moderate", "Average", "Significant", "Essential" });
            allBox.SelectedIndex = 0;
            allBox.DropDownStyle = ComboBoxStyle.DropDownList;
            allBox.SelectedIndexChanged += new System.EventHandler(this.changeAllBoxes);
            value.Add_TCF_values();
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
            for(int i = 0; i < Ratings.Count; i++)
            {
                Ratings[i].SelectedIndexChanged += new System.EventHandler(this.calculateTCFandFP);
            }
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
            calculateTCFandFP(null, null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        ComboBox addRatingBox(int i)
        {
            ComboBox cmb = new ComboBox();
            cmb.Name = "RatingsComboBox" + i.ToString();
            cmb.Items.AddRange(new string[] { "No Influence", "Incidental", "Moderate", "Average", "Significant", "Essential" });
            cmb.Width = 170;
            cmb.Height = 70;
            cmb.SelectedIndex = 0;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            return cmb;
        }

        Label addFactorsLabel(int i, String placeHolder)
        {
            Label l = new Label();
            l.Name = "Factors label" + i.ToString();
            l.Text = placeHolder;
            l.Width = 220;
            l.Height = 23;
            l.Margin = new Padding(0, 5, 0, 5);
            l.TextAlign = ContentAlignment.MiddleCenter;
            return l;
        }

        private void LOCformBtn_Click(object sender, EventArgs e)
        {
            LOC_form f = new LOC_form();
            this.Hide();
            f.Show();
        }

        private void form1_backbtn_Click(object sender, EventArgs e)
        {
            values.valuesDict.Clear();
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void calculateTCFbtn_Click(object sender, EventArgs e)
        {
            int Total_fs = 0;
            for (int i = 0; i < Ratings.Count; i++)
            {
                Total_fs = Total_fs + values.factorScale[Ratings[i].SelectedItem.ToString()];
            }
            TCF = 0.65 + 0.01 * Total_fs;
            TCFbox.Text = TCF.ToString();
            //Calculate the TCF using the rating values of the factors chosen by the user
        }

        private void calculateFPbtn_Click(object sender, EventArgs e)
        {
            FP = Form1.UFP * TCF;
            FPbox.Text = FP.ToString();
            //Calculate the FP
        }
        private void calculateTCFandFP(object sender, EventArgs e)
        {

            //Calculate the TCF using the rating values of the factors chosen by the user
            int Total_fs = 0;
            for (int i = 0; i < Ratings.Count; i++)
            {
                Total_fs = Total_fs + values.factorScale[Ratings[i].SelectedItem.ToString()];
            }
            TCF = 0.65 + (0.01 * Total_fs);
            TCFbox.Text = TCF.ToString();
            //Calculate the FP
            FP = Form1.UFP * TCF;
            FPbox.Text = FP.ToString();
        }

        private void changeAllBoxes(object sender, EventArgs e)
        {
            ComboBox temp = (ComboBox)sender;
            for(int i = 0; i < Ratings.Count(); i++)
            {
                Ratings[i].SelectedIndex = temp.SelectedIndex;
            }

        }
    }
}
