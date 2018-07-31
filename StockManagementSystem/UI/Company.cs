using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockManagementSystem.UI
{
    public partial class Company : Form
    {
        public SqlConnection con = new SqlConnection(@"server=DESKTOP-0KVRI9B\NAYANCSE; database=SMS; integrated security=true");

        public Company()
        {
            InitializeComponent();
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(companyNameTextBox.Text != "")
                {

                    SqlDataAdapter sda = new SqlDataAdapter(@"INSERT INTO Company (Name) VALUES ('" + companyNameTextBox.Text + "') ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("Sucessfully Save");

                }
                else
                {
                    MessageBox.Show("Invalid input !!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void companyGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
