using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a = 0;

        private bool CheckradioButtons()
        {
            bool gb1 = false;
            bool gb2 = false;
            bool gb3 = false;
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                    gb1 = true;
            }
            foreach (RadioButton rb in groupBox2.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                    gb2 = true;
            }
            foreach (RadioButton rb in groupBox3.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                    gb3 = true;
            }
            if (gb1 == true && gb2 == true && gb3 == true)
            {
                return true;
            }
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckradioButtons() == true)
            {
                decimal sum = 0;
                foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                        sum += Convert.ToDecimal(rb.Tag);
                }
                foreach (RadioButton rb in groupBox2.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                        sum += Convert.ToDecimal(rb.Tag);
                }
                foreach (RadioButton rb in groupBox3.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                        sum += Convert.ToDecimal(rb.Tag);
                }

                a++;
                string b = a.ToString();
                string str = "Result: ";
                str += sum.ToString() + "грн";
                MessageBox.Show(str + " Date: " + DateTime.Now.ToShortDateString() + " Time: " + DateTime.Now.ToShortTimeString());
                str = str + " Date: " + DateTime.Now.ToShortDateString() + " Time: " + DateTime.Now.ToShortTimeString();

                textBox1.Text += a + " - " + str + Environment.NewLine;
            }
        }
    }
}
