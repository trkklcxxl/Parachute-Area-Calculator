using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parachute
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
            try
            {
                Atmosphere atmosphere = new Atmosphere(Convert.ToDouble(txtH.Text));
                Parachute parachute = new Parachute(Convert.ToDouble(txtCd.Text), Convert.ToDouble(txtV.Text), Convert.ToDouble(txtH.Text), Convert.ToDouble(txtW.Text), atmosphere);
                parachute.CalcArea();
                parachute.CalcDiameter();
                parachute.CalcShockCord();
                txtConsole.AppendText("Area: " + parachute.area.ToString() + "\r\n");
                txtConsole.AppendText("Diameter: " + parachute.diameter.ToString() + "\r\n");
                txtConsole.AppendText("Shock Cord Length: " + parachute.shocCord.ToString() + "\n");
            }
            catch
            {
                MessageBox.Show("Please give all the values properly"); 
            }
           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   

}
