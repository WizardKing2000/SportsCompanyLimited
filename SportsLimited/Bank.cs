using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsLimited
{
    public partial class FrmBank : Form
    {
        public FrmBank()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUserName.Text;
                var email = tbEmail.Text;
                var cvv = tbCvv.Text;
                var password = tbPassword.Text;
                var typeofAccount = cbTypeofAccount.SelectedIndex;
                var IsValid = true;
                var errorMessage = "";


                if (string.IsNullOrEmpty(username))
                {
                    errorMessage += "Please enter User Name.\n\r";
                    tbUserName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(email))
                {
                    errorMessage += "Please enter you Email.\n\r";
                    tbEmail.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {
                    errorMessage += "Please enter you Password\n\r";
                    tbPassword.Focus();
                    return;
                }

                if (IsValid)
                {


                    MessageBox.Show("Account Succefully Added");

                    //MessageBox.Show($"Category:{category}\n\r" + $"Product Brand:{brand}\n\r" + $":{brand}\n\r" +
                    //$"Size:{size}\n\r" + $"Quantity:{quantity}\n\r" + $"Cost:{cost}\n\r" + $"Order was placed Successfully");


                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            
            }

        }
    }
}
