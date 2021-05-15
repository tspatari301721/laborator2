using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase
{
    public partial class Form1 : Form
    {
        Guy ion;
        Guy alex;
        int bank = 100;
        public void UpdateForm()
        {
            ionCashLabel.Text = ion.Name + " are  $ " + ion.Cash;
            alexCashLabel.Text = alex.Name + " are  $ " + alex.Cash;
            bankCashLabel.Text = "In baca sunt acum  $ " + bank;
        }

        public Form1()
        {
            InitializeComponent();

            lbStatus.Visible = false;

            alex = new Guy();
            alex.Name = "Alex";
            alex.Cash = 100;

            ion = new Guy();
            ion.Name = "Ion";
            ion.Cash = 50;
            //UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= ion.ReceiveCash(10);
                procesOK("Au fost Oferiti cu succes bani lui ION");
                UpdateForm();
            }
            else
            {
                procesBad("Nu sau oferit bani lui ION");
                MessageBox.Show("In baca nu sunt bani");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int v = alex.GiveCash(5);

            if (v==0){procesBad("Alex nu are bani");}
            else{procesOK("Au fost incasati cu succes bani de la Alex");}

            bank += v;
            UpdateForm();
        }


        private void ionGivesToAlex_Click(object sender, EventArgs e)
        {
            int v = 10;
            if (ion.Cash>=v)
            {
                alex.Cash += ion.GiveCashOF(v, ion.Cash);
                ion.ReceiveCash(-v);
                procesOK(" au fost transferat de la ion " + v + " $ la Alex" );
                UpdateForm();
            }
            else { procesBad("Ion nu are $ suficiente"); }
        }

        private void alexGivesToIon_Click(object sender, EventArgs e)
        {
            int v = 5;
            if (alex.Cash >= v)
            {
                ion.Cash += alex.GiveCashOF(v, alex.Cash);
                alex.ReceiveCash(-v);
                procesOK(" au fost transferat de la Alex " + v + " $ la Ion");
                UpdateForm();
            }
            else { procesBad("Alex nu are $ suficiente"); }
        }

        void procesBad(string value)
        {
            lbStatus.BackColor = Color.IndianRed;
            lbStatus.ForeColor = Color.DarkRed;
            lbStatus.Text = value;
            lbStatus.Visible = true;
        }
        void procesOK(string value)
        {
            lbStatus.BackColor = Color.LightGreen;
            lbStatus.ForeColor = Color.DarkGreen;
            lbStatus.Text = value;
            lbStatus.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
