
namespace GiftlyAdmin
{
    partial class MyBox
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
            this.myboxDataGridView = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setAsDelivered = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myboxDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Crimson;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(48, 74);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(183, 38);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Back";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // myboxDataGridView
            // 
            this.myboxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myboxDataGridView.BackgroundColor = System.Drawing.Color.Crimson;
            this.myboxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myboxDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.recipientname,
            this.giftername,
            this.relationship,
            this.address,
            this.contactNumber,
            this.itemName,
            this.itemPrice,
            this.quantity,
            this.totalPrice,
            this.orderDate});
            this.myboxDataGridView.Location = new System.Drawing.Point(45, 145);
            this.myboxDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myboxDataGridView.Name = "myboxDataGridView";
            this.myboxDataGridView.RowHeadersWidth = 51;
            this.myboxDataGridView.Size = new System.Drawing.Size(1461, 468);
            this.myboxDataGridView.TabIndex = 4;
            this.myboxDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.myboxDataGridView_RowHeaderMouseDoubleClick);
            // 
            // colOrderId
            // 
            this.colOrderId.HeaderText = "ID";
            this.colOrderId.MinimumWidth = 6;
            this.colOrderId.Name = "colOrderId";
            // 
            // recipientname
            // 
            this.recipientname.HeaderText = "Recipient";
            this.recipientname.MinimumWidth = 6;
            this.recipientname.Name = "recipientname";
            // 
            // giftername
            // 
            this.giftername.HeaderText = "Gifter";
            this.giftername.MinimumWidth = 6;
            this.giftername.Name = "giftername";
            // 
            // relationship
            // 
            this.relationship.HeaderText = "Relationship";
            this.relationship.MinimumWidth = 6;
            this.relationship.Name = "relationship";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact number";
            this.contactNumber.MinimumWidth = 6;
            this.contactNumber.Name = "contactNumber";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.MinimumWidth = 6;
            this.itemPrice.Name = "itemPrice";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Order date";
            this.orderDate.MinimumWidth = 6;
            this.orderDate.Name = "orderDate";
            // 
            // setAsDelivered
            // 
            this.setAsDelivered.BackColor = System.Drawing.Color.Crimson;
            this.setAsDelivered.Enabled = false;
            this.setAsDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAsDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAsDelivered.ForeColor = System.Drawing.Color.White;
            this.setAsDelivered.Location = new System.Drawing.Point(1356, 74);
            this.setAsDelivered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setAsDelivered.Name = "setAsDelivered";
            this.setAsDelivered.Size = new System.Drawing.Size(152, 38);
            this.setAsDelivered.TabIndex = 5;
            this.setAsDelivered.Text = "Delivered";
            this.setAsDelivered.UseVisualStyleBackColor = false;
            this.setAsDelivered.Click += new System.EventHandler(this.setAsDelivered_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(703, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "My Box";
            // 
            // MyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1608, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setAsDelivered);
            this.Controls.Add(this.myboxDataGridView);
            this.Controls.Add(this.logOutBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MyBox";
            this.Text = "MyBox";
            this.Load += new System.EventHandler(this.MyBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myboxDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.DataGridView myboxDataGridView;
        private System.Windows.Forms.Button setAsDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientname;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftername;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.Label label2;
    }
}