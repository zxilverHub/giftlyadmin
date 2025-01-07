
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(1223, 89);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(183, 38);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // myBoxBtn
            // 
            this.myBoxBtn.BackColor = System.Drawing.Color.Crimson;
            this.myBoxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBoxBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myBoxBtn.ForeColor = System.Drawing.Color.White;
            this.myBoxBtn.Location = new System.Drawing.Point(974, 89);
            this.myBoxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myBoxBtn.Name = "myBoxBtn";
            this.myBoxBtn.Size = new System.Drawing.Size(183, 38);
            this.myBoxBtn.TabIndex = 4;
            this.myBoxBtn.Text = "My box";
            this.myBoxBtn.UseVisualStyleBackColor = false;
            this.myBoxBtn.Click += new System.EventHandler(this.myBoxBtn_Click);
            // 
            // addToBox
            // 
            this.addToBox.BackColor = System.Drawing.Color.Crimson;
            this.addToBox.Enabled = false;
            this.addToBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToBox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBox.ForeColor = System.Drawing.Color.White;
            this.addToBox.Location = new System.Drawing.Point(730, 89);
            this.addToBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addToBox.Name = "addToBox";
            this.addToBox.Size = new System.Drawing.Size(183, 38);
            this.addToBox.TabIndex = 5;
            this.addToBox.Text = "Add to box";
            this.addToBox.UseVisualStyleBackColor = false;
            this.addToBox.Click += new System.EventHandler(this.addToBox_Click);
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsDataGridView.BackgroundColor = System.Drawing.Color.Crimson;
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
            this.transactionsDataGridView.Location = new System.Drawing.Point(45, 153);
            this.transactionsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.RowHeadersWidth = 51;
            this.transactionsDataGridView.Size = new System.Drawing.Size(1361, 426);
            this.transactionsDataGridView.TabIndex = 6;
            this.transactionsDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transactionsDataGridView_RowHeaderMouseDoubleClick);
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
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delivery Team";
            // 
            // DeliveryTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1456, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionsDataGridView);
            this.Controls.Add(this.addToBox);
            this.Controls.Add(this.myBoxBtn);
            this.Controls.Add(this.logOutBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeliveryTeam";
            this.Text = "DeliveryTeam";
            this.Load += new System.EventHandler(this.DeliveryTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}