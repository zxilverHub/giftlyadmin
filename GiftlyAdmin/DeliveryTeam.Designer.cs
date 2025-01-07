
namespace GiftlyAdmin
{
    partial class DeliveryTeam
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
            this.logOutBtn = new System.Windows.Forms.Button();
            this.myBoxBtn = new System.Windows.Forms.Button();
            this.addToBox = new System.Windows.Forms.Button();
            this.transactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(12, 12);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // myBoxBtn
            // 
            this.myBoxBtn.Location = new System.Drawing.Point(909, 12);
            this.myBoxBtn.Name = "myBoxBtn";
            this.myBoxBtn.Size = new System.Drawing.Size(124, 31);
            this.myBoxBtn.TabIndex = 4;
            this.myBoxBtn.Text = "My box";
            this.myBoxBtn.UseVisualStyleBackColor = true;
            this.myBoxBtn.Click += new System.EventHandler(this.myBoxBtn_Click);
            // 
            // addToBox
            // 
            this.addToBox.Enabled = false;
            this.addToBox.Location = new System.Drawing.Point(909, 401);
            this.addToBox.Name = "addToBox";
            this.addToBox.Size = new System.Drawing.Size(124, 31);
            this.addToBox.TabIndex = 5;
            this.addToBox.Text = "Add to box";
            this.addToBox.UseVisualStyleBackColor = true;
            this.addToBox.Click += new System.EventHandler(this.addToBox_Click);
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colItemName,
            this.colItemPrice,
            this.colItemQuantity,
            this.colTotal,
            this.colAddress});
            this.transactionsDataGridView.Location = new System.Drawing.Point(12, 49);
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.Size = new System.Drawing.Size(1021, 346);
            this.transactionsDataGridView.TabIndex = 6;
            this.transactionsDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transactionsDataGridView_RowHeaderMouseDoubleClick);
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
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // DeliveryTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.transactionsDataGridView);
            this.Controls.Add(this.addToBox);
            this.Controls.Add(this.myBoxBtn);
            this.Controls.Add(this.logOutBtn);
            this.Name = "DeliveryTeam";
            this.Text = "DeliveryTeam";
            this.Load += new System.EventHandler(this.DeliveryTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button myBoxBtn;
        private System.Windows.Forms.Button addToBox;
        private System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    }
}