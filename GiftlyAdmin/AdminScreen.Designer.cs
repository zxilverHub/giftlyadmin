
namespace GiftlyAdmin
{
    partial class AdminScreen
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
            this.colRecipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecipientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGifterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRelationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ordersSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recipientsSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientDataGridView
            // 
            this.recipientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecipient,
            this.colRecipientName,
            this.colGifterName,
            this.colRelationship,
            this.colBudget,
            this.colAddress,
            this.colContactNumber});
            this.recipientDataGridView.Location = new System.Drawing.Point(27, 61);
            this.recipientDataGridView.Name = "recipientDataGridView";
            this.recipientDataGridView.Size = new System.Drawing.Size(1015, 228);
            this.recipientDataGridView.TabIndex = 0;
            this.recipientDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recipientDataGridView_RowHeaderMouseDoubleClick);
            // 
            // colRecipient
            // 
            this.colRecipient.HeaderText = "ID";
            this.colRecipient.Name = "colRecipient";
            // 
            // colRecipientName
            // 
            this.colRecipientName.HeaderText = "Recipient";
            this.colRecipientName.Name = "colRecipientName";
            // 
            // colGifterName
            // 
            this.colGifterName.HeaderText = "Gifter";
            this.colGifterName.Name = "colGifterName";
            // 
            // colRelationship
            // 
            this.colRelationship.HeaderText = "Relationship";
            this.colRelationship.Name = "colRelationship";
            // 
            // colBudget
            // 
            this.colBudget.HeaderText = "Budget";
            this.colBudget.Name = "colBudget";
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // colContactNumber
            // 
            this.colContactNumber.HeaderText = "Contact Number";
            this.colContactNumber.Name = "colContactNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipients";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(27, 12);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colItemName,
            this.colItemPrice,
            this.colItemQuantity,
            this.colTotal,
            this.colStatus});
            this.ordersDataGridView.Location = new System.Drawing.Point(27, 328);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(1015, 228);
            this.ordersDataGridView.TabIndex = 3;
            // 
            // colOrderId
            // 
            this.colOrderId.HeaderText = "ID";
            this.colOrderId.Name = "colOrderId";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Recipient";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Gifter";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item name";
            this.colItemName.Name = "colItemName";
            // 
            // colItemPrice
            // 
            this.colItemPrice.HeaderText = "Price";
            this.colItemPrice.Name = "colItemPrice";
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.HeaderText = "Quantity";
            this.colItemQuantity.Name = "colItemQuantity";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Order status";
            this.colStatus.Name = "colStatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orders";
            // 
            // ordersSearch
            // 
            this.ordersSearch.Location = new System.Drawing.Point(849, 302);
            this.ordersSearch.Name = "ordersSearch";
            this.ordersSearch.Size = new System.Drawing.Size(192, 20);
            this.ordersSearch.TabIndex = 5;
            this.ordersSearch.TextChanged += new System.EventHandler(this.ordersSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(803, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search";
            // 
            // recipientsSearch
            // 
            this.recipientsSearch.Location = new System.Drawing.Point(850, 35);
            this.recipientsSearch.Name = "recipientsSearch";
            this.recipientsSearch.Size = new System.Drawing.Size(192, 20);
            this.recipientsSearch.TabIndex = 7;
            this.recipientsSearch.TextChanged += new System.EventHandler(this.recipientsSearch_TextChanged);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recipientsSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordersSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipientDataGridView);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recipientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecipientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGifterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ordersSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recipientsSearch;
    }
}