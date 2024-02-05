using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CoinDispenser
{
    public partial class Form1 : Form
    {
        double AmountPurchased, AmountTendered, ChangeAmount;
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            AmountPurchased = Convert.ToDouble(PurchasedTextbox.Text);
            AmountTendered = Convert.ToDouble(TenderedTextbox.Text);
            ChangeAmount = AmountTendered - AmountPurchased;
            ChangeLabel.Text = ChangeAmount.ToString();
            TenPesoLabel.Text = ((int) (ChangeAmount / 10)).ToString();
            FivePesoLabel.Text = ((int) (ChangeAmount % 10 / 5)).ToString();
            OnePesoLabel.Text = ((int) (ChangeAmount % 10 % 5 / 1)).ToString();
            TwentyFiveCentLabel.Text = ((int) (ChangeAmount % 10 % 5 % 1 / .25)).ToString();
            TenCentLabel.Text = ((int) (ChangeAmount % 10 % 5 % 1 % .25 /.1)).ToString();
            FiveCentLabel.Text = ((int) (ChangeAmount % 10 % 5 % 1 % .25 % .10 / .05)).ToString();
            OneCentLabel.Text = Convert.ToInt16((ChangeAmount % 10 % 5 % 1 % .25 % .10 % .05 / .01)).ToString();
        }
    }
}
