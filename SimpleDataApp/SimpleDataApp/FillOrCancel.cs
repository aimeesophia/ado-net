using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SimpleDataApp
{
    public partial class FillOrCancel : Form
    {
        private int _parsedOrderId;

        public FillOrCancel()
        {
            InitializeComponent();
        }

        private void btnFindByOrderID_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    const string sql = "SELECT * FROM Sales.Orders WHERE orderID = @orderID";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = _parsedOrderId;

                        try
                        {
                            connection.Open();

                            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                            {
                                DataTable dataTable = new DataTable();

                                dataTable.Load(dataReader);

                                dgvCustomerOrders.DataSource = dataTable;

                                dataReader.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("The requested order could not be loaded into the form.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspCancelOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = _parsedOrderId;

                        try
                        {
                            connection.Open();

                            sqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("The cancel operation was not completed.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnFillOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspFillOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = _parsedOrderId;

                        sqlCommand.Parameters.Add(new SqlParameter("@FilledDate", SqlDbType.DateTime, 8));
                        sqlCommand.Parameters["@FilledDate"].Value = dtpFillDate.Value;

                        try
                        {
                            connection.Open();

                            sqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("The fill operation was not completed.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnFinishUpdates_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsOrderIDValid()
        {
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Please specify the Order ID.");
                return false;
            }

            if (Regex.IsMatch(txtOrderID.Text, @"^\D*$"))
            {
                MessageBox.Show("Customer ID must contain only numbers.");
                txtOrderID.Clear();
                return false;
            }

            _parsedOrderId = int.Parse(txtOrderID.Text);
            return true;
        }
    }
}
