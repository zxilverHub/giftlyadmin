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
    public partial class SetOrder : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();
        String sql = "";
        int reciptId = 0;
        int userId = 0;
        int itemid;
        int orderid;

        List<String> cats = new List<string> { };

        double itemPrice = 0;
        int itemQuanti = 0;
        String itemDesc = "";
        String itemName = "";
        String itemCat = "";

        public SetOrder(int id)
        {
            this.reciptId = id;
            InitializeComponent();
        }

        private void SetOrder_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server=localhost;user id=root;database=giftly";
            conn.Open();

            DisplayGiftReference();
            initializedAddItemInputs();
            DisplayRecipient();
        }

        private void initializedAddItemInputs()
        {
            sql = "SELECT * FROM category";
            using(var cmd = new MySqlCommand(sql, conn))
            {
                using(var dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        categoryComboBox.Items.Add($"{dr[0]}. {dr[1]}");
                        cats.Add($"{dr[0]}. {dr[1]}");
                    }
                }
            }
            categoryComboBox.Text = cats[0];

        }

        private void DisplayGiftReference()
        {
            sql = "SELECT * FROM gift_preference WHERE recipient_id = @repid";

            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@repid", reciptId);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        preferenceName.Text = dr[3].ToString();
                        preferenceDesc.Text = dr[4].ToString();
                        preferencePrice.Text = dr[5].ToString();
                    }
                }
            }
        }

        private void DisplayRecipient()
        {
            recipientDataGridView.Rows.Clear();
            sql = @"SELECT recipient.recipient_id, recipient.firstname, recipient.lastname, `user`.firstname AS Expr1, `user`.lastname AS Expr2, recipient.relationship, recipient.budget, recipient.address, recipient.contact_number, `user`.user_id
                    FROM  `user` INNER JOIN
                    recipient ON `user`.user_id = recipient.user_id WHERE recipient.recipient_id = @repid";

            try
            {

            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@repid", reciptId);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                            userId = int.Parse(dr[9].ToString());
                            recipientDataGridView.Rows.Add(
                                    dr[0].ToString(),
                                    dr[1].ToString() + dr[2].ToString(),
                                    dr[3].ToString() + dr[4].ToString(),
                                    dr[5].ToString(),
                                    dr[6].ToString(),
                                    dr[7].ToString(),
                                    dr[8].ToString()
                                );
                        }
                }
            }
            } catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new AdminScreen().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(itemNameInput.Text == "" || itemDescInput.Text == "" || itemPriceInput.Text == "")
            {
                MessageBox.Show("Please fill inputs");
                return;
            }

            bool isValidCat = false;
            foreach(var c  in cats)
            {
                if(c == categoryComboBox.Text)
                {
                    isValidCat = true;
                }
            }

            if(!isValidCat)
            {
                MessageBox.Show("Please choose valid category");
                return;
            }

            try
            {
                itemName = itemNameInput.Text;
                itemDesc = itemDescInput.Text;
                itemPrice = double.Parse(itemPriceInput.Text);
                itemQuanti = int.Parse(quantityInput.Text);
                itemCat = categoryComboBox.Text;
            } catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }

                sql = "INSERT INTO item VALUES (null, @name, @desc, @price, @stock, @cat)";
                using(var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@desc", itemDesc);
                    cmd.Parameters.AddWithValue("@price", itemPrice);
                    cmd.Parameters.AddWithValue("@stock", itemQuanti);
                    cmd.Parameters.AddWithValue("@cat", int.Parse(itemCat.Substring(0, 1)));
                    cmd.ExecuteNonQuery();
                }

                sql = "SELECT LAST_INSERT_ID();";

                using(var cmd = new MySqlCommand(sql, conn))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            itemid = int.Parse(dr[0].ToString());
                        }
                    }
                }


                sql = "INSERT INTO `orders` VALUES (null, @userid, @repid, NOW(), null, 0, 1)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", userId);
                    cmd.Parameters.AddWithValue("@repid", reciptId);
                    cmd.ExecuteNonQuery();
                }

                sql = "SELECT LAST_INSERT_ID();";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            orderid = int.Parse(dr[0].ToString());
                        }
                    }
                }

            sql = "INSERT INTO `transaction` VALUES (null, @orderid, @itemid , @total, @quantity, 1)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    double total = itemPrice * itemQuanti;
                    cmd.Parameters.AddWithValue("@orderid", orderid);
                    cmd.Parameters.AddWithValue("@itemid", itemid);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@quantity", itemQuanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully");
                }

                new AdminScreen().Show();
                this.Close();
        }
    }
}
