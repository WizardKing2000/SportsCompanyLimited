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
    public partial class FrmItem : Form
    {
        private readonly SportsLimitedEntities sportsLimitedEntities;
        public FrmItem()
        {
            InitializeComponent();
            sportsLimitedEntities = new SportsLimitedEntities();
        }

        public string Model { get; internal set; }
        public string Year { get; internal set; }
        public string Id { get; internal set; }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var category = cbCategory.Text;
                
                var brand = tbBrand.Text;
                 var size = tbSize.Text;
                var quantity = tbQuantity.Text;
                var item = cbItem.Text;
                var cost = tbCost.Text;
                var IsValid = true;
                var errorMessage = "";


                if (string.IsNullOrEmpty(category))
                {
                    errorMessage += "Please select a category.\n\r";
                    cbCategory.Focus();
                    return;
                }


                if (string.IsNullOrEmpty(brand))
                {
                    MessageBox.Show("Please enter a Item.");
                    tbBrand.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(size))
                {
                    MessageBox.Show("Please enter a Brand.");
                    tbSize.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(quantity))
                {
                    MessageBox.Show("Please enter the amount.");
                    tbQuantity.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(size))
                {
                    MessageBox.Show("Please enter size.");
                    tbSize.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cost))
                {
                    MessageBox.Show("Please enter cost.");
                    tbCost.Focus();
                    return;
                }

                if (IsValid)
                {
                    var itemRecord = new ItemRecord();
                    itemRecord.Category = category;
                    itemRecord.Brand = brand;
                    itemRecord.Size = int.Parse(size);
                    itemRecord.Quantity = int.Parse(quantity);
                    itemRecord.Cost= float.Parse(cost);
               
                    itemRecord.TypeofItemId = (int)cbItem.SelectedValue;

                    sportsLimitedEntities.ItemRecords.Add(itemRecord);
                    sportsLimitedEntities.SaveChanges();

         
                    MessageBox.Show($"Category:{category}\n\r" + $"Product Brand:{brand}\n\r" + $":{brand}\n\r" +
                    $"Size:{size}\n\r" + $"Quantity:{quantity}\n\r" +$"Cost:{cost}\n\r"+ $"Order was placed Successfully");
                 

                }
                else
                {
                    MessageBox.Show(errorMessage);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            var items = sportsLimitedEntities.TypesofItems.
            Select(q=> new { Id= q.Id, Name = q.Name+""+q.Model}).ToList();
            cbItem.DisplayMember = "Name"; 
            cbItem.ValueMember = "Id";
            cbItem.DataSource = items;
        }

        
    }
}
