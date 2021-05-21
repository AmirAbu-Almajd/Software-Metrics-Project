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
        public static int UFP;
        int i = 0;
        //These lists contain all the function points , their complexities and their amounts that are chosen by the user
        static values value = new values();
        List<ComboBox> Complexities = new List<ComboBox>();
        List<ComboBox> FPs = new List<ComboBox>();
        List<TextBox> amounts = new List<TextBox>();
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

            ufpLabel.AutoSize = false;
            ufpLabel.Location = new Point(10, 451);
            ufpLabel.Height = 40;
            ufpLabel.Width = 114;
            ufpLabel.TextAlign = ContentAlignment.MiddleCenter;
            value.add_UFP_Values();
            ComboBox cmb1 = addFPBox(i);
            ComboBox cmb2 = addComplexityBox(i);
            cmb1.SelectedIndexChanged += new System.EventHandler(this.calculateUFP);
            cmb2.SelectedIndexChanged += new System.EventHandler(this.calculateUFP);
            Label l1 = addFPLabel(i);
            Label l2 = addComplexityLabel(i);
            TextBox amountText = addAmountTxt(i);
            amountText.TextChanged += new System.EventHandler(this.validateText);
            amountText.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.handleAmount);
            amounts.Add(amountText);
            FPs.Add(cmb1);
            Complexities.Add(cmb2);
            flowLayoutPanel1.Controls.Add(l1);
            flowLayoutPanel1.Controls.Add(FPs[i]);
            flowLayoutPanel1.Controls.Add(l2);
            flowLayoutPanel1.Controls.Add(Complexities[i]);
            flowLayoutPanel1.Controls.Add(addAmountLabel(i));
            flowLayoutPanel1.Controls.Add(amounts[i]);

            i++;
            calculateUFP(null, null);
        }

        ComboBox addFPBox(int i)
        {
            ComboBox cmb = new ComboBox();
            cmb.Name = "FPComboBox" + i.ToString();
            cmb.Items.AddRange(new string[] { "External Input", "External Output", "External Inquiry", "Internal Logical Files", "External Interface Files" });
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
            cmb.Items.AddRange(new string[] { "Simple", "Average", "Complex" });
            cmb.Width = 75;
            cmb.Height = 70;
            cmb.SelectedIndex = 0;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            return cmb;
        }
        TextBox addAmountTxt(int i)
        {
            TextBox amounttxt = new TextBox();
            amounttxt.Name = "AmountTextBox" + i.ToString();
            amounttxt.Width = 30;
            amounttxt.Height = 23;
            amounttxt.TextAlign = HorizontalAlignment.Center;
            amounttxt.Multiline = true;
            amounttxt.Text = "0";

            return amounttxt;
        }
        Label addAmountLabel(int i)
        {
            Label l = new Label();
            l.Name = "Amount label" + i.ToString();
            l.Text = "Amount";
            l.Width = 50;
            l.Height = 30;
            l.TextAlign = ContentAlignment.MiddleCenter;
            return l;
        }
        Label addFPLabel(int i)
        {
            Label l = new Label();
            l.Name = "FP label" + i.ToString();
            l.Text = "Choose the Function Point";
            l.Width = 140;
            l.Height = 30;
            l.TextAlign = ContentAlignment.MiddleCenter;
            return l;
        }
        Label addComplexityLabel(int i)
        {
            Label l = new Label();
            l.Name = "Complexity label" + i.ToString();
            l.Text = "Choose the Complexity";
            l.Width = 120;
            l.Height = 30;
            l.TextAlign = ContentAlignment.MiddleCenter;
            return l;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            ComboBox cmb1 = addFPBox(i);
            ComboBox cmb2 = addComplexityBox(i);
            cmb1.SelectedIndexChanged += new System.EventHandler(this.calculateUFP);
            cmb2.SelectedIndexChanged += new System.EventHandler(this.calculateUFP);
            Label l1 = addFPLabel(i);
            Label l2 = addComplexityLabel(i);
            TextBox amountText = addAmountTxt(i);
            amountText.TextChanged += new System.EventHandler(this.validateText);
            amountText.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.handleAmount);
            amounts.Add(amountText);
            FPs.Add(cmb1);
            Complexities.Add(cmb2);
            flowLayoutPanel1.Controls.Add(l1);
            flowLayoutPanel1.Controls.Add(FPs[i]);
            flowLayoutPanel1.Controls.Add(l2);
            flowLayoutPanel1.Controls.Add(Complexities[i]);
            flowLayoutPanel1.Controls.Add(addAmountLabel(i));
            flowLayoutPanel1.Controls.Add(amounts[i]);
            i++;
            calculateUFP(null, null);
        }


        private void calculateUFP(object sender, EventArgs e)
        {
            UFP = 0;
            for (int i = 0; i < FPs.Count; i++)
            {
                UFP = UFP + (values.valuesDict[FPs[i].SelectedItem.ToString()][Complexities[i].SelectedItem.ToString()] * Int32.Parse(amounts[i].Text.ToString()));
            }
            UFPbox.Text = UFP.ToString();
        }

        private void handleAmount(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (e.Delta > 0)
            {
                int x = int.Parse(temp.Text);
                x++;
                temp.Text = x.ToString();

            }
            else
            {
                int x = int.Parse(temp.Text);
                if (x != 0)
                    x--;
                temp.Text = x.ToString();
            }
            sender = temp;
        }

        private void validateText(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            var isNumeric = int.TryParse(temp.Text, out int n);
            if(isNumeric && n>=0)
                calculateUFP(null, null);
            else
            {
                temp.Text = "0";
                sender = temp;
            }
                
        }
        private void TCFformBtn_Click(object sender, EventArgs e)
        {
            TCF_form f = new TCF_form();
            f.Show();
            this.Hide();
        }


    }
}
