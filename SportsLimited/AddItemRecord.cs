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
    public partial class FrmAddItemRecord : Form
    {

        private readonly SportsLimitedEntities _db = new SportsLimitedEntities();
        private bool isEditMode;
        public FrmAddItemRecord()
        {
            InitializeComponent();
            lblProItem.Text = "Add new Product or Item";
            isEditMode = false;
        }

        public FrmAddItemRecord(TypesofItem itemToEdit)
        {
            InitializeComponent();
            lblProItem.Text = "Edit Product or Item";
            PopulateFields(itemToEdit);
            isEditMode = true;
        }

        private void PopulateFields(TypesofItem item)
        {
            lblId.Text = item.Id.ToString();
            tbName.Text =item.Name;
            tbModel.Text =item.Model;
            tbYear.Text = item.Year.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            { 
            // edit code
              var id =int.Parse(lblId.Text);
                var item = _db.TypesofItems.FirstOrDefault(x => x.Id == id);
                item.Name = tbName.Text;
                item.Model = tbModel.Text;
                item.Year = int.Parse(tbYear.Text);
                _db.SaveChanges();

            }
            else
            {
                //add code
                var newItem = new TypesofItem
                {
                    Name = tbName.Text,
                    Model = tbModel.Text,
                    Year = int.Parse(tbYear.Text)
                };

                _db.TypesofItems.Add(newItem);  
                _db.SaveChanges();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
