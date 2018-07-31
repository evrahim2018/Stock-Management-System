using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.UI
{
    public partial class Category : Form
    {
        public SqlConnection con = new SqlConnection(@"server=DESKTOP-0KVRI9B\NAYANCSE; database=SMS; integrated security=true");

        SqlDataAdapter sd;
        SqlCommandBuilder sc;
        DataTable dt;

        public Category()
        {
            InitializeComponent();

            sd = new SqlDataAdapter(@"SELECT * FROM  Category", con);
            dt = new DataTable();
            sd.Fill(dt);
            categoryDataGridView.DataSource = dt;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (categoryNameTextBox.Text != "")
                {

                    SqlDataAdapter sda = new SqlDataAdapter(@"INSERT INTO Category (Name) VALUES ('" + categoryNameTextBox.Text + "') ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("Sucessfully Save");
                    categoryNameTextBox.Clear();

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

        private void DeletedButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dataGridview1.Rows.count > 1 && dataGriedView1.SelectedRows[0].Index != dataGriedView1.Rows.count - 1)
            //    if(categoryDataGridView.Rows.Count> 1 && categoryDataGridView.)
            //    {
            //        String a = dataGridView1.SelectedRows[0].Cells[0].value.Tostring();
            //        String sql = "Delete from Department Where id='" + a + "'";
            //        con.Open();
            //        sqlCommand delcmd = new sqlcommand(sql, con);
            //        delcmd.Commection = con;
            //        delcmd.ExecutedNonQuery();
            //        con.close();
            //        dataGeidView1.Rows.RemoveAt(dateGridView1.SelectedRows[0].Index);
            //        messageBox.show("Department delected Successfullly !");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    messagebox.show(ex.message);
            //}
        }
    }
}
