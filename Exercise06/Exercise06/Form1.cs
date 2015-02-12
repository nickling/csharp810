// Nick Ling
// 02/11/2015
// Exercise 06


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06._0_Console_As_Library;

namespace Exercise06
{

    public partial class Form1 : Form
    {

        private CoinBox currentCoinBox;
        private CanRack myCanRack;

        public Form1()
        {
            InitializeComponent();
            myCanRack = new CanRack();
            currentCoinBox = new CoinBox();
            enableSodaEjectButtons();
        }

        private void buttonNickel_Click(object sender, EventArgs e)
        {
            Coin Nickel = new Coin(Coin.Denomination.NICKEL);
            currentCoinBox.Deposit(Nickel);
            labelTotalChange.Text = currentCoinBox.ValueOf.ToString();
            enableSodaEjectButtons();
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            Coin Dime = new Coin(Coin.Denomination.DIME);
            currentCoinBox.Deposit(Dime);
            labelTotalChange.Text = currentCoinBox.ValueOf.ToString();
            enableSodaEjectButtons();
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            Coin Quarter = new Coin(Coin.Denomination.QUARTER);
            currentCoinBox.Deposit(Quarter);
            labelTotalChange.Text = currentCoinBox.ValueOf.ToString();
            enableSodaEjectButtons();
        }

        private void buttonHalfDollar_Click(object sender, EventArgs e)
        {
            Coin HalfDollar = new Coin(Coin.Denomination.HALFDOLLAR);
            currentCoinBox.Deposit(HalfDollar);
            labelTotalChange.Text = currentCoinBox.ValueOf.ToString();
            enableSodaEjectButtons();
        }

        private void buttonReturnMoney_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We're returning $" + currentCoinBox.ValueOf.ToString() + " to you.");
            currentCoinBox.Withdraw(currentCoinBox.ValueOf);
            labelTotalChange.Text = "0.00";
            enableSodaEjectButtons();
        }

        private void buttonEjectRegular_Click(object sender, EventArgs e)
        {
            myCanRack.RemoveACanOf(Flavor.REGULAR);
            removeMoney();
            changeTotalChangeLabel();
            enableSodaEjectButtons();
            MessageBox.Show("Here is your Regular Soda!");
        }

        private void buttonEjectOrange_Click(object sender, EventArgs e)
        {
            myCanRack.RemoveACanOf(Flavor.ORANGE);
            removeMoney();
            changeTotalChangeLabel();
            enableSodaEjectButtons();
            MessageBox.Show("Here is your Orange Soda!");
        }

        private void buttonEjectLemon_Click(object sender, EventArgs e)
        {
            myCanRack.RemoveACanOf(Flavor.LEMON);
            removeMoney();
            changeTotalChangeLabel();
            enableSodaEjectButtons();
            MessageBox.Show("Here is your Lemon Soda!");
        }       

        // user defined methods
        private void enableSodaEjectButtons()
        {
            buttonEjectLemon.Enabled = false;
            buttonEjectOrange.Enabled = false;
            buttonEjectRegular.Enabled = false;

            if (!myCanRack.IsEmpty(Flavor.LEMON) && currentCoinBox.ValueOf == 0.35M)
            {
                buttonEjectLemon.Enabled = true;
            }
            if (!myCanRack.IsEmpty(Flavor.REGULAR) && currentCoinBox.ValueOf == 0.35M)
            {
                buttonEjectRegular.Enabled = true;
            }
            if (!myCanRack.IsEmpty(Flavor.ORANGE) && currentCoinBox.ValueOf == 0.35M)
            {
                buttonEjectOrange.Enabled = true;
            }
        }

        private void removeMoney()
        {
            currentCoinBox.Withdraw(0.35M);
        }

        private void changeTotalChangeLabel()
        {
            labelTotalChange.Text = currentCoinBox.ValueOf.ToString();
        }
    }
}
