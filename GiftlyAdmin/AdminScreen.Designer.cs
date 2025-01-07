
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
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientDataGridView
            // 
            this.recipientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipientDataGridView.BackgroundColor = System.Drawing.Color.Crimson;
            this.recipientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecipient,
            this.colRecipientName,
            this.colGifterName,
            this.colRelationship,
            this.colBudget,
            this.colAddress,
            this.colContactNumber});
            this.recipientDataGridView.Location = new System.Drawing.Point(36, 209);
            this.recipientDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recipientDataGridView.Name = "recipientDataGridView";
            this.recipientDataGridView.RowHeadersWidth = 51;
            this.recipientDataGridView.Size = new System.Drawing.Size(1353, 281);
            this.recipientDataGridView.TabIndex = 0;
            this.recipientDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recipientDataGridView_RowHeaderMouseDoubleClick);
            // 
            // colRecipient
            // 
            this.colRecipient.HeaderText = "ID";
            this.colRecipient.MinimumWidth = 6;
            this.colRecipient.Name = "colRecipient";
            // 
            // colRecipientName
            // 
            this.colRecipientName.HeaderText = "Recipient";
            this.colRecipientName.MinimumWidth = 6;
            this.colRecipientName.Name = "colRecipientName";
            // 
            // colGifterName
            // 
            this.colGifterName.HeaderText = "Gifter";
            this.colGifterName.MinimumWidth = 6;
            this.colGifterName.Name = "colGifterName";
            // 
            // colRelationship
            // 
            this.colRelationship.HeaderText = "Relationship";
            this.colRelationship.MinimumWidth = 6;
            this.colRelationship.Name = "colRelationship";
            // 
            // colBudget
            // 
            this.colBudget.HeaderText = "Budget";
            this.colBudget.MinimumWidth = 6;
            this.colBudget.Name = "colBudget";
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            // 
            // colContactNumber
            // 
            this.colContactNumber.HeaderText = "Contact Number";
            this.colContactNumber.MinimumWidth = 6;
            this.colContactNumber.Name = "colContactNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(28, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipients";
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.White;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(1206, 46);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(183, 38);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.Crimson;
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
            this.ordersDataGridView.Location = new System.Drawing.Point(36, 597);
            this.ordersDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.Size = new System.Drawing.Size(1353, 273);
            this.ordersDataGridView.TabIndex = 3;
            // 
            // colOrderId
            // 
            this.colOrderId.HeaderText = "ID";
            this.colOrderId.MinimumWidth = 6;
            this.colOrderId.Name = "colOrderId";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Recipient";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Gifter";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item name";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            // 
            // colItemPrice
            // 
            this.colItemPrice.HeaderText = "Price";
            this.colItemPrice.MinimumWidth = 6;
            this.colItemPrice.Name = "colItemPrice";
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.HeaderText = "Quantity";
            this.colItemQuantity.MinimumWidth = 6;
            this.colItemQuantity.Name = "colItemQuantity";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Order status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(28, 528);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orders";
            // 
            // ordersSearch
            // 
            this.ordersSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordersSearch.Location = new System.Drawing.Point(1134, 552);
            this.ordersSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordersSearch.Multiline = true;
            this.ordersSearch.Name = "ordersSearch";
            this.ordersSearch.Size = new System.Drawing.Size(255, 22);
            this.ordersSearch.TabIndex = 5;
            this.ordersSearch.TextChanged += new System.EventHandler(this.ordersSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1057, 554);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1057, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search";
            // 
            // recipientsSearch
            // 
            this.recipientsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recipientsSearch.Location = new System.Drawing.Point(1134, 162);
            this.recipientsSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recipientsSearch.Name = "recipientsSearch";
            this.recipientsSearch.Size = new System.Drawing.Size(255, 22);
            this.recipientsSearch.TabIndex = 7;
            this.recipientsSearch.TextChanged += new System.EventHandler(this.recipientsSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(449, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 53);
            this.label5.TabIndex = 9;
            this.label5.Text = "ADMIN DASHBOARD";
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 994);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recipientsSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordersSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipientDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label5;
    }
}