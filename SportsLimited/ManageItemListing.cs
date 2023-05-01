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
    public partial class FrmManageItemListing : Form
    {
        private readonly SportsLimitedEntities _db;
        private ItemRecord items;

        public FrmManageItemListing()
        {
            InitializeComponent();
            _db = new SportsLimitedEntities();    
        }

        private void FrmManageItemListing_Load(object sender, EventArgs e)
        {
            //var item =_db.TypesofItems.ToList();

            var items =_db.TypesofItems.Select(q=> new { ID = q.Id, ItemName 
                = q.Name, model = q.Model, year = q.Year
            } ).ToList();

            gvItemList.DataSource = items;
            gvItemList.Columns[0].Visible= false;
            //gvItemList.Columns[1].HeaderText = "Name";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var addItemRecord = new FrmAddItemRecord();
            addItemRecord.MdiParent = this.MdiParent;
            addItemRecord.Show();
            MessageBox.Show("Item added Successfully.");
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvItemList.SelectedRows[0].Cells["Id"].Value;
                var items = _db.TypesofItems.FirstOrDefault(q => q.Id == id);
                var addItemRecord = new FrmAddItemRecord(items);
                addItemRecord.MdiParent = this.MdiParent;
                addItemRecord.Show();
                MessageBox.Show("Item edited Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvItemList.SelectedRows[0].Cells["Id"].Value;
                var item = _db.TypesofItems.FirstOrDefault(q => q.Id == id);
                _db.TypesofItems.Remove(item);
                _db.SaveChanges();
                gvItemList.Refresh();
                MessageBox.Show("Item delete Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmManageItemListing_Load(this, EventArgs.Empty);

        }
    }
}
