// Nick Ling
// Exercise 08
// 2/18/2015


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using _06._0_Console_As_Library;

namespace _07._1_Vend_Service
{
    public partial class VendingForm : Form
    {
        public VendingForm()
        {
            InitializeComponent();
        }

        private CoinBox mainCoinBox = new CoinBox(new List<Coin> { 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME), 
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER), 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

        private CoinBox tempCoinBox = new CoinBox();
        private PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        private CanRack theRack = new CanRack();

        private void putCoinInBoxAndUpdateInsertedTotal(Coin ACoin)
        {
            tempCoinBox.Deposit(ACoin);
            totalInsertedDisplayLabel.Text =
                 string.Format("{0:c}", tempCoinBox.ValueOf);
            ejectButtonsReset();
            CoinReturnButton.Enabled = tempCoinBox.ValueOf > 0M ? true : false;

        }

        private void ejectButtonsReset()
        {
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal)
            {
                regularEjectButton.Enabled = !theRack.IsEmpty(Flavor.REGULAR);
                orangeEjectButton.Enabled = !theRack.IsEmpty(Flavor.ORANGE);
                lemonEjectButton.Enabled = !theRack.IsEmpty(Flavor.LEMON);
            }
            else
            {
                regularEjectButton.Enabled = false;
                orangeEjectButton.Enabled = false;
                lemonEjectButton.Enabled = false;
            }
        }
 

        private void halfDollarButton_Click(object sender, EventArgs e)
        {
            Coin halfDollar = new Coin(Coin.Denomination.HALFDOLLAR);
            putCoinInBoxAndUpdateInsertedTotal(halfDollar);
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            Coin quarter = new Coin(Coin.Denomination.QUARTER);
            putCoinInBoxAndUpdateInsertedTotal(quarter);
        }

        private void dimeButton_Click(object sender, EventArgs e)
        {
            Coin dime = new Coin(Coin.Denomination.DIME);
            putCoinInBoxAndUpdateInsertedTotal(dime);
        }

        private void nickelButton_Click(object sender, EventArgs e)
        {
            Coin nickel = new Coin(Coin.Denomination.NICKEL);
            putCoinInBoxAndUpdateInsertedTotal(nickel);
        }

        private void regularEjectButton_Click(object sender, EventArgs e)
        {
            ejectCan(sender as Button, Flavor.REGULAR);
        }

        private void orangeEjectButton_Click(object sender, EventArgs e)
        {
            ejectCan(sender as Button, Flavor.ORANGE);
        }

        private void lemonEjectButton_Click(object sender, EventArgs e)
        {
            ejectCan(sender as Button, Flavor.LEMON);
        }

        private void ejectCan(Button sender, Flavor theFlavor)
        {
            decimal amountInserted = tempCoinBox.ValueOf;
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal && !theRack.IsEmpty(theFlavor))
            {
                tempCoinBox.Transfer(mainCoinBox);
                totalInsertedDisplayLabel.Text =
                    string.Format("{0:c}", tempCoinBox.ValueOf);
                theRack.RemoveACanOf(theFlavor);
                MessageBox.Show(string.Format("Thanks. Here is your {0} soda.",
                    theFlavor.ToString()));
                ejectButtonsReset();
                decimal changeDue = amountInserted - sodaPrice.PriceDecimal;
                if (changeDue > 0M && mainCoinBox.CanMakeChange)
                {
                    mainCoinBox.Withdraw(changeDue);
                    MessageBox.Show(string.Format("Here is your {0:c} in change", changeDue));
                }
                ExactChangeLabel.Visible = !mainCoinBox.CanMakeChange;
                CoinReturnButton.Enabled = tempCoinBox.ValueOf > 0M ? true : false;
            }
        }

        private void VendingForm_Load(object sender, EventArgs e)
        {
            pleaseInsertLabel.Text =
                string.Format("Please Insert {0} cents for a soda",
                sodaPrice.Price);
            if (!mainCoinBox.CanMakeChange) ExactChangeLabel.Visible = true;
        }

        private void CoinReturnButton_Click(object sender, EventArgs e)
        {
            decimal amountInserted = tempCoinBox.ValueOf;

            if (amountInserted > 0M)
            {
                tempCoinBox.Withdraw(tempCoinBox.ValueOf);
                totalInsertedDisplayLabel.Text =
                    string.Format("{0:c}", tempCoinBox.ValueOf);
                MessageBox.Show(string.Format(
                    "Here is your {0:c} back", amountInserted));
            }
            
            CoinReturnButton.Enabled = tempCoinBox.ValueOf > 0M ? true : false;
            ejectButtonsReset();

        }

        private Boolean machineLocked = true;

        private void setLockState(Boolean becomeLocked)
        {
            if (becomeLocked)
            {
                // turn the service related controls off
                CanRackGroupBox.Visible = false;
                CoinBoxGroup.Visible = false;
                buttonServiceNotes.Visible = false;

                // turn the password related controls on
                machineLocked = true;
                PasswordLabel.Visible = true;
                PasswordTextBox.Visible = true;
                PasswordOKButton.Visible = true;
                serviceLockButton.Visible = false;
                PasswordTextBox.Focus();
            }
            else
            {
                // turn the service related controls on
                constructRackDisplay();
                CanRackGroupBox.Visible = true; 
                constructCoinBoxDisplay(CoinBoxListView,mainCoinBox);
                constructCoinBoxDisplay(InsertedCoinsListView, tempCoinBox);
                CoinBoxGroup.Visible = true;
                buttonServiceNotes.Visible = true;

                // turn the password related controls off
                machineLocked = false;
                PasswordLabel.Visible = false;
                PasswordTextBox.Visible = false;
                PasswordOKButton.Visible = false;
                serviceLockButton.Visible = true;                
            }


        }

        private void constructCoinBoxDisplay(ListView CoinBoxDisplay, CoinBox CoinBoxToDisplay)
        {
            CoinBoxDisplay.Items.Clear();
            List<Coin.Denomination> reverseCoinList = new List<Coin.Denomination>(Coin.AllDenominations);
            reverseCoinList.Reverse();

            foreach (Coin.Denomination coinDenomination in reverseCoinList)
            {
                int coinCount = CoinBoxToDisplay.coinCount(coinDenomination);
                decimal coinsValue = coinCount * Coin.ValueOfCoin(coinDenomination);
                ListViewItem coinRow = new ListViewItem(coinDenomination.ToString());
                coinRow.SubItems.Add(coinCount.ToString());
                coinRow.SubItems.Add(string.Format("{0:c}", coinsValue));
                CoinBoxDisplay.Items.Add(coinRow);
            }

            ListViewItem totalRow = new ListViewItem("Total");
            totalRow.SubItems.Add(string.Empty);
            totalRow.SubItems.Add(string.Format("{0:c}",
                CoinBoxToDisplay.ValueOf));
            CoinBoxDisplay.Items.Add(totalRow);
        }

        private void constructRackDisplay()
        {
 
            CanRackListView.Items.Clear();

            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                ListViewItem row = new ListViewItem(aFlavor.ToString());
                row.SubItems.Add(theRack[aFlavor].ToString());
                CanRackListView.Items.Add(row);
            }
        }

        private void PasswordOKButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "cs")
            {
                setLockState(false);
            }
        }


        private void serviceLockButton_Click(object sender, EventArgs e)
        {
            setLockState(true);
        }

        private void PasswordTextBox_VisibleChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Visible) PasswordTextBox.Focus();
        }

        private void VendingTabControl_Click(object sender, EventArgs e)
        {
            setLockState(machineLocked);
        }

        private void fillTheCanRackButton_Click(object sender, EventArgs e)
        {
            theRack.FillTheCanRack();
            setLockState(machineLocked);
        }

        private void EmptyMainCoinBoxButton_Click(object sender, EventArgs e)
        {
            mainCoinBox.Withdraw(mainCoinBox.ValueOf);
            setLockState(machineLocked);
        }

        private void emptyInsertedCoinsCoinBoxButton_Click(object sender, EventArgs e)
        {
            tempCoinBox.Withdraw(tempCoinBox.ValueOf);
            setLockState(machineLocked);
        }

        private void buttonServiceNotes_Click(object sender, EventArgs e)
        {
            ServiceForm serviceF = new ServiceForm();
            serviceF.Show();
        }

    }
}

