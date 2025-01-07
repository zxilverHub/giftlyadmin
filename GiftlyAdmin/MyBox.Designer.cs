
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
            this.setAsDelivered = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.myboxDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(12, 12);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Back";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // myboxDataGridView
            // 
            this.myboxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.myboxDataGridView.Location = new System.Drawing.Point(12, 55);
            this.myboxDataGridView.Name = "myboxDataGridView";
            this.myboxDataGridView.Size = new System.Drawing.Size(1182, 380);
            this.myboxDataGridView.TabIndex = 4;
            this.myboxDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.myboxDataGridView_RowHeaderMouseDoubleClick);
            // 
            // setAsDelivered
            // 
            this.setAsDelivered.Enabled = false;
            this.setAsDelivered.Location = new System.Drawing.Point(1080, 441);
            this.setAsDelivered.Name = "setAsDelivered";
            this.setAsDelivered.Size = new System.Drawing.Size(114, 33);
            this.setAsDelivered.TabIndex = 5;
            this.setAsDelivered.Text = "Delivered";
            this.setAsDelivered.UseVisualStyleBackColor = true;
            this.setAsDelivered.Click += new System.EventHandler(this.setAsDelivered_Click);
            // 
            // colOrderId
            // 
            this.colOrderId.HeaderText = "ID";
            this.colOrderId.Name = "colOrderId";
            // 
            // recipientname
            // 
            this.recipientname.HeaderText = "Recipient";
            this.recipientname.Name = "recipientname";
            // 
            // giftername
            // 
            this.giftername.HeaderText = "Gifter";
            this.giftername.Name = "giftername";
            // 
            // relationship
            // 
            this.relationship.HeaderText = "Relationship";
            this.relationship.Name = "relationship";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact number";
            this.contactNumber.Name = "contactNumber";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item";
            this.itemName.Name = "itemName";
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.Name = "itemPrice";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total";
            this.totalPrice.Name = "totalPrice";
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Order date";
            this.orderDate.Name = "orderDate";
            // 
            // MyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 486);
            this.Controls.Add(this.setAsDelivered);
            this.Controls.Add(this.myboxDataGridView);
            this.Controls.Add(this.logOutBtn);
            this.Name = "MyBox";
            this.Text = "MyBox";
            this.Load += new System.EventHandler(this.MyBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myboxDataGridView)).EndInit();
            this.ResumeLayout(false);

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
    }
}