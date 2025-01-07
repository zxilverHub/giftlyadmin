using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GiftlyAdmin
{
    public partial class MyBox : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();
        String sql = "";

        String recipientName = "";
        String orderItemName = "";
        int orderid;
        int userid;

        List<int> usersIds = new List<int> { };

        public MyBox()
        {
            InitializeComponent();
        }

        private void MyBox_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server=localhost;user id=root;database=giftly";
            conn.Open();
            DisplayBox();
        }

        private void DisplayBox()
        {
            myboxDataGridView.Rows.Clear();
            sql = @"SELECT orders.order_id, recipient.firstname, recipient.lastname, `user`.firstname AS Expr1, `user`.lastname AS Expr2, recipient.relationship, recipient.address, recipient.contact_number, item.item_name, item.item_price,
                         transaction.item_quantity, transaction.total_price, orders.order_date, user.user_id
                         FROM item INNER JOIN
                         transaction ON item.item_id = transaction.item_id INNER JOIN
                         orders ON transaction.order_id = orders.order_id INNER JOIN
                         `user` ON orders.user_id = `user`.user_id INNER JOIN
                         recipient ON orders.recipient_id = recipient.recipient_id AND `user`.user_id = recipient.user_id
                         WHERE orders.is_delivered = 1";

            using(var cmd = new MySqlCommand(sql, conn))
            {
                using(var dr = cmd.ExecuteReader())
                {
                    if(dr.HasRows)
                    {
                        while(dr.Read())
                        {
                            usersIds.Add(int.Parse(dr[13].ToString()));
                            myboxDataGridView.Rows.Add(
                                dr[0].ToString(),
                                dr[1].ToString() + " " + dr[2].ToString(),
                                dr[3].ToString() + " " + dr[4].ToString(),
                                dr[5].ToString(),
                                dr[6].ToString(),
                                dr[7].ToString(),
                                dr[8].ToString(),
                                dr[9].ToString(),
                                dr[10].ToString(),
                                dr[11].ToString(),
                                dr[12].ToString()
                            );
                        }
                    }
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            new DeliveryTeam().Show();
            this.Close();
        }

        private void myboxDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderid = int.Parse(myboxDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            orderItemName = myboxDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            recipientName = myboxDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            userid = usersIds[e.RowIndex];
            setAsDelivered.Enabled = true;
        }

        private void setAsDelivered_Click(object sender, EventArgs e)
        {
            setAsDelivered.Enabled = false;

            sql = "UPDATE orders SET is_delivered = 2 WHERE order_id = @orderid";
            
            using(var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@orderid", orderid);
                cmd.ExecuteNonQuery();
            }

            sql = $"INSERT INTO notification VALUES (null, 'The {orderItemName} for {recipientName} has been delivered.', @userid)";
            using(var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Order delivered {sql}");
                DisplayBox();
            }

        }
    }
}
