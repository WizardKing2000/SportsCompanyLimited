namespace SportsLimited
{
    partial class FrmItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuantit = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(373, 353);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 29);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(43, 135);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 22);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(133, 201);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(200, 22);
            this.tbBrand.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Men",
            "Women"});
            this.cbCategory.Location = new System.Drawing.Point(133, 146);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 24);
            this.cbCategory.TabIndex = 3;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(133, 268);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(200, 22);
            this.tbSize.TabIndex = 4;
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(561, 133);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(200, 24);
            this.cbItem.TabIndex = 5;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(414, 133);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(114, 22);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "Type of Item ";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(46, 198);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(63, 22);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "Brand ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(46, 272);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 22);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add Products ";
            // 
            // tbQuantit
            // 
            this.tbQuantit.AutoSize = true;
            this.tbQuantit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantit.Location = new System.Drawing.Point(429, 199);
            this.tbQuantit.Name = "tbQuantit";
            this.tbQuantit.Size = new System.Drawing.Size(77, 22);
            this.tbQuantit.TabIndex = 11;
            this.tbQuantit.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(561, 198);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(167, 22);
            this.tbQuantity.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(561, 266);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(200, 22);
            this.tbCost.TabIndex = 12;
            // 
            // FrmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbQuantit);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnSend);
            this.Name = "FrmItem";
            this.Text = "Items ";
            this.Load += new System.EventHandler(this.FrmItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbQuantit;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCost;
    }
}

