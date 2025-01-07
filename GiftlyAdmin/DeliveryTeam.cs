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
    public partial class DeliveryTeam : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();
        String sql = "";

        int trans_id;
        int order_id;

        public DeliveryTeam()
        {
            InitializeComponent();
        }

        private void DeliveryTeam_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server=localhost;user id=root;database=giftly";
            conn.Open();
            DisplayOrders();
        }
        private void DisplayOrders()
        {
            transactionsDataGridView.Rows.Clear();
            sql = @"SELECT transaction.trans_id, recipient.firstname, recipient.lastname, user.firstname AS Expr1, user.lastname AS Expr2, item.item_name, item.item_price, transaction.item_quantity, transaction.total_price, recipient.address
                    FROM transaction INNER JOIN
                    item ON transaction.item_id = item.item_id INNER JOIN
                    orders ON transaction.order_id = orders.order_id INNER JOIN
                    recipient ON orders.recipient_id = recipient.recipient_id INNER JOIN
                    user ON orders.user_id = user.user_id AND recipient.user_id = user.user_id
                    WHERE orders.is_delivered = 0
                    ";

            using (var cmd = new MySqlCommand(sql, conn))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            transactionsDataGridView.Rows.Add(
                                dr[0].ToString(),
                                dr[1].ToString() + dr[2].ToString(),
                                dr[3].ToString() + dr[4].ToString(),
                                dr[5].ToString(),
                                dr[6].ToString(),
                                dr[7].ToString(),
                                dr[8].ToString(),
                                dr[9].ToString()
                            );
                        }
                    }
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void addToBox_Click(object sender, EventArgs e)
        {

            sql = "UPDATE orders SET is_delivered = 1 WHERE order_id = @orderid";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@orderid", order_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order added to box");
            }

            DisplayOrders();
            addToBox.Enabled = false;
        }

        private void transactionsDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            trans_id = int.Parse(transactionsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            sql = "SELECT order_id FROM transaction WHERE trans_id = @transid";

            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@transid", trans_id);
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            order_id = int.Parse(dr[0].ToString());
                        }
                    }
                }
            }

            addToBox.Enabled = true;
        }

        private void myBoxBtn_Click(object sender, EventArgs e)
        {
            new MyBox().Show();
            this.Close();
        }
    }
}
