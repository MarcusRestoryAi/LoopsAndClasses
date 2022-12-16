using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopsAndClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!");

            //Hämta meddelande och antal
            string strMessage = txtMessage.Text;
            int intCount = Convert.ToInt32( txtAntal.Text );

            //Rensa lblOutput
            lblOutput.Text = "";

            // ForLoop
            for (int i = 0; i < intCount; i++)
            {
                //Skriva ut meddelande till label + radbrytning
                lblOutput.Text += strMessage + Environment.NewLine;
            }
        }
    }
}
