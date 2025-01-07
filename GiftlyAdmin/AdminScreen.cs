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
    public partial class AdminScreen : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();
        String sql = "";

        int reciptId = 0;
        List<String> reciptIds = new List<string> { };
        List<String> recipContent = new List<string> { };

        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server=localhost;user id=root;database=giftly";
            conn.Open();
            DisplayRecipients("");
            DisplayOrders("");
        }

        private void DisplayOrders(string keyword)
        {
            ordersDataGridView.Rows.Clear();
            string where = "";

            // Add filtering condition based on the keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                where = @"WHERE (
            recipient.firstname LIKE @keyword OR
            recipient.lastname LIKE @keyword OR
            `user`.firstname LIKE @keyword OR
            `user`.lastname LIKE @keyword
        )";
            }

            sql = $@"SELECT transaction.trans_id, 
                    recipient.firstname, 
                    recipient.lastname, 
                    `user`.firstname AS Expr1, 
                    `user`.lastname AS Expr2, 
                    item.item_name, 
                    item.item_price, 
                    transaction.item_quantity, 
                    transaction.total_price, 
                    orders.is_delivered
             FROM transaction 
             INNER JOIN item ON transaction.item_id = item.item_id 
             INNER JOIN orders ON transaction.order_id = orders.order_id 
             INNER JOIN recipient ON orders.recipient_id = recipient.recipient_id 
             INNER JOIN `user` ON orders.user_id = `user`.user_id AND recipient.user_id = `user`.user_id
             {where}";

            using (var cmd = new MySqlCommand(sql, conn))
            {
                // Add the parameter if keyword is provided
                if (!string.IsNullOrEmpty(keyword))
                {
                    cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
                }

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            String status = "";
                            switch (dr[9].ToString())
                            {
                                case "0":
                                    status = "Ready to pick up";
                                    break;
                                case "1":
                                    status = "Picked up";
                                    break;
                                case "2":
                                    status = "Delivered";
                                    break;
                                default:
                                    status = "Unknown";
                                    break;
                            }

                            ordersDataGridView.Rows.Add(
                                dr[0].ToString(),
                                dr[1].ToString() + " " + dr[2].ToString(),
                                dr[3].ToString() + " " + dr[4].ToString(),
                                dr[5].ToString(),
                                dr[6].ToString(),
                                dr[7].ToString(),
                                dr[8].ToString(),
                                status
                            );
                        }
                    }
                }
            }
        }


        private void DisplayRecipients(string keyword)
        {
            recipientDataGridView.Rows.Clear();
            string conditions = "";
            string where = "";
            int recipCount = 0;

            // Get all orders that have recipients
            sql = "SELECT recipient_id FROM orders";
            using (var cmd = new MySqlCommand(sql, conn))
            {
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        recipCount++;
                        reciptIds.Add(dr[0].ToString());
                    }
                }
            }

            foreach (var id in reciptIds)
            {
                conditions += $"{id},";
            }

            if (recipCount > 0)
            {
                where = "WHERE recipient.recipient_id NOT IN (" + conditions.Substring(0, conditions.Length - 1) + ")";
            }

            // Add filtering based on keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                if (!string.IsNullOrEmpty(where))
                {
                    where += " AND";
                }
                else
                {
                    where = "WHERE";
                }

                // Add filtering by recipient name, user name, or address
                where += @" (
            recipient.firstname LIKE @keyword OR
            recipient.lastname LIKE @keyword OR
            recipient.address LIKE @keyword OR
            `user`.firstname LIKE @keyword OR
            `user`.lastname LIKE @keyword
        )";
            }

            sql = $@"SELECT recipient.recipient_id, 
                    recipient.firstname, 
                    recipient.lastname, 
                    `user`.firstname AS Expr1, 
                    `user`.lastname AS Expr2, 
                    recipient.relationship, 
                    recipient.budget, 
                    recipient.address, 
                    recipient.contact_number
             FROM `user` 
             INNER JOIN recipient ON `user`.user_id = recipient.user_id {where}";

            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (!string.IsNullOrEmpty(keyword))
                {
                    cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
                }

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int reciptId = int.Parse(dr[0].ToString());
                        recipientDataGridView.Rows.Add(
                            dr[0].ToString(),
                            dr[1].ToString() + " " + dr[2].ToString(),
                            dr[3].ToString() + " " + dr[4].ToString(),
                            dr[5].ToString(),
                            dr[6].ToString(),
                            dr[7].ToString(),
                            dr[8].ToString()
                        );
                    }
                }
            }
        }


        private void recipientDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            reciptId = int.Parse(recipientDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            new SetOrder(reciptId).Show();
            this.Close();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void recipientsSearch_TextChanged(object sender, EventArgs e)
        {
            DisplayRecipients(recipientsSearch.Text);
        }

        private void ordersSearch_TextChanged(object sender, EventArgs e)
        {
            DisplayOrders(ordersSearch.Text);
        }
    }
}
