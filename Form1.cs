using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storing_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection=new SqlConnection("Data Source=DESKTOP-T3K84PN;Initial Catalog=Storing;Integrated Security=True;TrustServerCertificate=True");
        SqlCommand command = new SqlCommand();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "INSERT INTO STORE VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedItem.ToString()+ "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','"+textBox7.Text+"')";
            command= new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("you've regisered successfully");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
