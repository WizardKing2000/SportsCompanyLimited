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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addNewItem = new FrmItem();
            addNewItem.MdiParent = this;
            addNewItem.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void manageRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRecord = new FrmManageItemListing();
            manageRecord.MdiParent = this;
            manageRecord.Show();
        }

        
        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var addNewAccount = new FrmBank();
            addNewAccount.MdiParent = this.MdiParent;
            addNewAccount.Show();
        }

        private void liveChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is the Contact us button please Note; 

            var addNewContact = new FrmContactUs();
            addNewContact.MdiParent = this.MdiParent;
            addNewContact.Show();
        }
    }
}
