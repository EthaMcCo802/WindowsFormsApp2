using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usernameinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void pin_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                string userName;
                int pin;

                userName = Usernameinput.Text;
                pin = Convert.ToInt32(pinInput.Text);


                outputLabel.Text = $"{userName} {pin}";

            }
            catch
            {
                outputLabel.Text = "Please enter numbers only for PIN.";
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {

        }
    }
}
           

        
