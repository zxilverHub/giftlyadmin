
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gifter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.itemPriceInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemDescInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.setOrderBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientDataGridView
            // 
            this.recipientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.reciptName,
            this.gifter,
            this.relationship,
            this.budget,
            this.address,
            this.contactNumber});
            this.recipientDataGridView.Location = new System.Drawing.Point(12, 51);
            this.recipientDataGridView.Name = "recipientDataGridView";
            this.recipientDataGridView.Size = new System.Drawing.Size(1004, 105);
            this.recipientDataGridView.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(846, 350);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(173, 21);
            this.categoryComboBox.TabIndex = 3;
            // 
            // preferenceName
            // 
            this.preferenceName.Enabled = false;
            this.preferenceName.Location = new System.Drawing.Point(15, 202);
            this.preferenceName.Name = "preferenceName";
            this.preferenceName.Size = new System.Drawing.Size(173, 20);
            this.preferenceName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preference name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // preferencePrice
            // 
            this.preferencePrice.Enabled = false;
            this.preferencePrice.Location = new System.Drawing.Point(213, 202);
            this.preferencePrice.Name = "preferencePrice";
            this.preferencePrice.Size = new System.Drawing.Size(133, 20);
            this.preferencePrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // preferenceDesc
            // 
            this.preferenceDesc.Enabled = false;
            this.preferenceDesc.Location = new System.Drawing.Point(15, 251);
            this.preferenceDesc.Multiline = true;
            this.preferenceDesc.Name = "preferenceDesc";
            this.preferenceDesc.Size = new System.Drawing.Size(331, 74);
            this.preferenceDesc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item name";
            // 
            // itemNameInput
            // 
            this.itemNameInput.Location = new System.Drawing.Point(644, 203);
            this.itemNameInput.Name = "itemNameInput";
            this.itemNameInput.Size = new System.Drawing.Size(173, 20);
            this.itemNameInput.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 137;
            // 
            // reciptName
            // 
            this.reciptName.HeaderText = "Recipient";
            this.reciptName.Name = "reciptName";
            this.reciptName.Width = 138;
            // 
            // gifter
            // 
            this.gifter.HeaderText = "Gifter";
            this.gifter.Name = "gifter";
            this.gifter.Width = 137;
            // 
            // relationship
            // 
            this.relationship.HeaderText = "Relationship";
            this.relationship.Name = "relationship";
            this.relationship.Width = 137;
            // 
            // budget
            // 
            this.budget.HeaderText = "Budget";
            this.budget.Name = "budget";
            this.budget.Width = 137;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Width = 138;
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Width = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(846, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item price";
            // 
            // itemPriceInput
            // 
            this.itemPriceInput.Location = new System.Drawing.Point(846, 203);
            this.itemPriceInput.Name = "itemPriceInput";
            this.itemPriceInput.Size = new System.Drawing.Size(173, 20);
            this.itemPriceInput.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Item description";
            // 
            // itemDescInput
            // 
            this.itemDescInput.Location = new System.Drawing.Point(644, 251);
            this.itemDescInput.Multiline = true;
            this.itemDescInput.Name = "itemDescInput";
            this.itemDescInput.Size = new System.Drawing.Size(375, 74);
            this.itemDescInput.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantity";
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(647, 350);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(173, 20);
            this.quantityInput.TabIndex = 16;
            // 
            // setOrderBtn
            // 
            this.setOrderBtn.Location = new System.Drawing.Point(922, 386);
            this.setOrderBtn.Name = "setOrderBtn";
            this.setOrderBtn.Size = new System.Drawing.Size(97, 32);
            this.setOrderBtn.TabIndex = 18;
            this.setOrderBtn.Text = "Set order";
            this.setOrderBtn.UseVisualStyleBackColor = true;
            this.setOrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Preference name";
            // 
            // SetOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
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
    }
}