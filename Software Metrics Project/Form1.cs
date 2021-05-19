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
    public partial class Form1 : Form
    {
        int i = 0;
        //These lists contain all the function points and their complexities that are chosen by the user
        List<ComboBox> Complexities = new List<ComboBox>();
        List<ComboBox> FPs = new List<ComboBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox cmb1 = addFPBox(i);
            ComboBox cmb2 = addComplexityBox(i);
            Label l1 = addFPLabel(i);
            Label l2 = addComplexityLabel(i);
            FPs.Add(cmb1);
            Complexities.Add(cmb2);
            flowLayoutPanel1.Controls.Add(l1);
            flowLayoutPanel1.Controls.Add(FPs[i]);
            flowLayoutPanel1.Controls.Add(l2);
            flowLayoutPanel1.Controls.Add(Complexities[i]);
            i++;
        }

        ComboBox addFPBox(int i)
        {
            ComboBox cmb = new ComboBox();
            cmb.Name = "FPComboBox" + i.ToString();
            cmb.Items.AddRange(new string[] { "External Input", "External Output", "External Inquiry", "Internal Logical Files" , "External Interface Files" });
            cmb.Width = 120;
            cmb.Height = 70;
            cmb.SelectedIndex = 0;

            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            return cmb;
        }

        ComboBox addComplexityBox(int i)
        {
            ComboBox cmb = new ComboBox();
            cmb.Name = "ComplexityComboBox" + i.ToString();
            cmb.Items.AddRange(new string[] { "Simple",  "Average", "Complex" });
            cmb.Width = 120;
            cmb.Height = 70;
            cmb.SelectedIndex = 0;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            return cmb;
        }
        Label addFPLabel(int i)
        {
            Label l = new Label();
            l.Name = "FP label" + i.ToString();
            l.Text = "Choose the Function Point";
            l.Width = 160;
            l.Height = 30;
            l.TextAlign = ContentAlignment.MiddleCenter;
            return l;
        }
        Label addComplexityLabel(int i)
        {
            Label l = new Label();
            l.Name = "Complexity label" + i.ToString();
            l.Text = "Choose the Complexity";
            l.Width = 160;
            l.Height = 30;
            l.TextAlign = ContentAlignment.MiddleCenter;
            return l;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            ComboBox cmb1 = addFPBox(i);
            ComboBox cmb2 = addComplexityBox(i);
            Label l1 = addFPLabel(i);
            Label l2 = addComplexityLabel(i);
            FPs.Add(cmb1);
            Complexities.Add(cmb2);
            flowLayoutPanel1.Controls.Add(l1);
            flowLayoutPanel1.Controls.Add(FPs[i]);
            flowLayoutPanel1.Controls.Add(l2);
            flowLayoutPanel1.Controls.Add(Complexities[i]);
            i++;
        }

        private void calculateUFPbtn_Click(object sender, EventArgs e)
        {
            //Calculate the UFP for the user and add the calculate value to UFPbox (textbox)
        }

        private void TCFformBtn_Click(object sender, EventArgs e)
        {
            //We need to pass the UFP value to the next form as parameter for the next calculations
            TCF_form f = new TCF_form(); 
            f.Show();
            this.Hide();
        }


    }
}
