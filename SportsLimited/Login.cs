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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                var username = tbName.Text; 
                var password = tbPass.Text;
                var IsVaild =true;
                var errorMessage ="";

               var addNewLogin = new FrmMenu();
                addNewLogin.MdiParent = this.MdiParent;
                addNewLogin.Show();

                if (username == null || password == null)
                {
                    errorMessage += "Please enter Vaild Credentials";
                    return;
                }

                if(IsVaild)
                {


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
