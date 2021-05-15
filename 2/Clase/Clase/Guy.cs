using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase
{
    class Guy
    {
        public string Name;
        public int Cash;
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(
                    "Nu am suficienti bani ",
                   Name + " spune");
                return 0;
            }
        }
        public int GiveCashOF(int amount, int CashOf)
        {
            if (amount <= CashOf && amount > 0)
            {
                CashOf -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(
                    "Nu am suficienti bani ",
                   Name + " spune");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            //if (amount > 0)
            //{
                Cash += amount;
                return amount;
            //}
            //else
            //{
            //    MessageBox.Show(amount + "Nu am nevoie",
            //       "spune" + Name);
            //    return 0;
            //}

        }

    }
}
