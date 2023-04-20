using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SportsLimited
{
    public partial class FrmContactUs : Form
    {
        public FrmContactUs()
        {
            InitializeComponent();
        }

        private void btnSend1_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var email = tbEmail.Text;
            var phone = tbNumber.Text;
            var message = tbSubject.Text;


            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.");
                tbName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.");
                tbEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message.");
                tbSubject.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter a message.");
                tbNumber.Focus();
                return;
            }
            MessageBox.Show("Message Sent");
        }
    }
}
