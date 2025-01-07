
namespace GiftlyAdmin
{
    partial class SetOrder
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
            this.recipientDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gifter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.preferenceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.preferencePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preferenceDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemNameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemPriceInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemDescInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.setOrderBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientDataGridView
            // 
            this.recipientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipientDataGridView.BackgroundColor = System.Drawing.Color.Crimson;
            this.recipientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.reciptName,
            this.gifter,
            this.relationship,
            this.budget,
            this.address,
            this.contactNumber});
            this.recipientDataGridView.Location = new System.Drawing.Point(52, 610);
            this.recipientDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.recipientDataGridView.Name = "recipientDataGridView";
            this.recipientDataGridView.RowHeadersWidth = 51;
            this.recipientDataGridView.Size = new System.Drawing.Size(1507, 174);
            this.recipientDataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // reciptName
            // 
            this.reciptName.HeaderText = "Recipient";
            this.reciptName.MinimumWidth = 6;
            this.reciptName.Name = "reciptName";
            // 
            // gifter
            // 
            this.gifter.HeaderText = "Gifter";
            this.gifter.MinimumWidth = 6;
            this.gifter.Name = "gifter";
            // 
            // relationship
            // 
            this.relationship.HeaderText = "Relationship";
            this.relationship.MinimumWidth = 6;
            this.relationship.Name = "relationship";
            // 
            // budget
            // 
            this.budget.HeaderText = "Budget";
            this.budget.MinimumWidth = 6;
            this.budget.Name = "budget";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.MinimumWidth = 6;
            this.contactNumber.Name = "contactNumber";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Crimson;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(53, 43);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(183, 38);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(798, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(1054, 387);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(499, 24);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // preferenceName
            // 
            this.preferenceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preferenceName.Enabled = false;
            this.preferenceName.Location = new System.Drawing.Point(233, 166);
            this.preferenceName.Margin = new System.Windows.Forms.Padding(4);
            this.preferenceName.Name = "preferenceName";
            this.preferenceName.Size = new System.Drawing.Size(440, 22);
            this.preferenceName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(53, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preference name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(53, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // preferencePrice
            // 
            this.preferencePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preferencePrice.Enabled = false;
            this.preferencePrice.Location = new System.Drawing.Point(233, 209);
            this.preferencePrice.Margin = new System.Windows.Forms.Padding(4);
            this.preferencePrice.Name = "preferencePrice";
            this.preferencePrice.Size = new System.Drawing.Size(440, 22);
            this.preferencePrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(53, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // preferenceDesc
            // 
            this.preferenceDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preferenceDesc.Enabled = false;
            this.preferenceDesc.Location = new System.Drawing.Point(233, 258);
            this.preferenceDesc.Margin = new System.Windows.Forms.Padding(4);
            this.preferenceDesc.Multiline = true;
            this.preferenceDesc.Name = "preferenceDesc";
            this.preferenceDesc.Size = new System.Drawing.Size(440, 90);
            this.preferenceDesc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(798, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item name";
            // 
            // itemNameInput
            // 
            this.itemNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameInput.Location = new System.Drawing.Point(1054, 153);
            this.itemNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameInput.Name = "itemNameInput";
            this.itemNameInput.Size = new System.Drawing.Size(499, 22);
            this.itemNameInput.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(798, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item price";
            // 
            // itemPriceInput
            // 
            this.itemPriceInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPriceInput.Location = new System.Drawing.Point(1054, 211);
            this.itemPriceInput.Margin = new System.Windows.Forms.Padding(4);
            this.itemPriceInput.Name = "itemPriceInput";
            this.itemPriceInput.Size = new System.Drawing.Size(499, 22);
            this.itemPriceInput.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(798, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Item description";
            // 
            // itemDescInput
            // 
            this.itemDescInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemDescInput.Location = new System.Drawing.Point(1054, 259);
            this.itemDescInput.Margin = new System.Windows.Forms.Padding(4);
            this.itemDescInput.Multiline = true;
            this.itemDescInput.Name = "itemDescInput";
            this.itemDescInput.Size = new System.Drawing.Size(499, 90);
            this.itemDescInput.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(798, 444);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantity";
            // 
            // quantityInput
            // 
            this.quantityInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityInput.Location = new System.Drawing.Point(1054, 439);
            this.quantityInput.Margin = new System.Windows.Forms.Padding(4);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(499, 22);
            this.quantityInput.TabIndex = 16;
            this.quantityInput.TextChanged += new System.EventHandler(this.quantityInput_TextChanged);
            // 
            // setOrderBtn
            // 
            this.setOrderBtn.BackColor = System.Drawing.Color.Crimson;
            this.setOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setOrderBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setOrderBtn.ForeColor = System.Drawing.Color.White;
            this.setOrderBtn.Location = new System.Drawing.Point(1054, 503);
            this.setOrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.setOrderBtn.Name = "setOrderBtn";
            this.setOrderBtn.Size = new System.Drawing.Size(505, 49);
            this.setOrderBtn.TabIndex = 18;
            this.setOrderBtn.Text = "Set order";
            this.setOrderBtn.UseVisualStyleBackColor = false;
            this.setOrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(51, 552);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Preference Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(730, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 34);
            this.label10.TabIndex = 20;
            this.label10.Text = "SET ORDERS";
            // 
            // SetOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 849);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.setOrderBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itemDescInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemPriceInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemNameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.preferenceDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preferencePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.preferenceName);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.recipientDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetOrder";
            this.Text = "SetOrder";
            this.Load += new System.EventHandler(this.SetOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recipientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gifter;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox preferenceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox preferencePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox preferenceDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemNameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemPriceInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemDescInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.Button setOrderBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}