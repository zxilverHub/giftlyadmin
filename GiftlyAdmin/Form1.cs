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
    public partial class Form1 : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();
        String sql = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server=localhost;user id=root;database=giftly";
            conn.Open();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String email = usernameInput.Text;
            String password = passwordInput.Text;

            if (email == "giftly@admin.com" && password == "giftlyadmin")
            {
                new AdminScreen().Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Incorrect email or password");
            return;
        }

        private void deliveryTeamLoginBtn_Click(object sender, EventArgs e)
        {
            String email = usernameInput.Text;
            String password = passwordInput.Text;

            if (email == "giftly@deliveryteam.com" && password == "giftlydeliveryteam")
            {
                new DeliveryTeam().Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Incorrect email or password");
            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
