using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingApp;

namespace BankingApp
{
    public partial class Form1 : Form
    {

        Customer aCustomer;

        string[] name = new string[2];
        int acc;
        double bal;
        double dep;
        double with;

        public Form1()
        {
            InitializeComponent();
        }

        public void btnAddAcc_Click(object sender, EventArgs e)
        {
            

            name = txtBxName.Text.Split(' ');


            while (double.TryParse(txtBxBal.Text, out bal) == false)
            {
                MessageBox.Show("Numeric value should be entered for balance.");
                txtBxBal.Text = "0";
                txtBxBal.Focus();
            }

            if (name.Length < 2)
            {
                MessageBox.Show("Please enter full name.");
                txtBxName.Text = "";
                txtBxName.Focus();
            }

            if (int.TryParse(txtBxAcc.Text, out acc) == false)
            {
                MessageBox.Show("Please enter account number.");
                txtBxAcc.Text = "0";
                txtBxAcc.Focus();
            }



            else
            {
                aCustomer = new Customer(name[0], name[1], acc, bal);

                lblAccountBal.Text = bal.ToString("C");

                txtBxName.Enabled = false;
                txtBxAcc.Enabled = false;
                txtBxBal.Visible = false;
                lblIniBal.Visible = false;
                txtBxDep.Visible = true;
                txtBxWith.Visible = true;
                lblDep.Visible = true;
                lblWith.Visible = true;
                lblAccBalName.Visible = true;
                lblAccountBal.Visible = true;
                btnUpdate.Visible = true;

            }

        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {

            if ((double.TryParse(txtBxDep.Text, out dep) == true) && dep >= 0)
            {
                double newBalance = aCustomer.DepositTo(dep);
                lblAccountBal.Text = newBalance.ToString("C");
                txtBxDep.Text = "";
                txtBxDep.Focus();
            }

            if (dep < 0)
            {
                MessageBox.Show("Must enter positive numeric value for a deposit.");
            }

            if ((double.TryParse(txtBxWith.Text, out with) == true) && with >= 0)
            {
                double newBalance = aCustomer.WithdrawalFrom(with);
                lblAccountBal.Text = newBalance.ToString("C");
                txtBxDep.Text = "";
                txtBxDep.Focus();
            }

            if (with < 0)
            {
                MessageBox.Show("Must enter positive numeric value for a withdrawal.");
            }

        }

    }
        
}

