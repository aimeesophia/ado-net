using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleDataApp
{
    public partial class NewCustomer : Form
    {
        private int _parsedCustomerId;
        private int _orderId;

        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsCustomerNameValid())
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspNewCustomer", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@CustomerName"].Value = txtCustomerName.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                        sqlCommand.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            sqlCommand.ExecuteNonQuery();

                            _parsedCustomerId = (int)sqlCommand.Parameters["@CustomerID"].Value;

                            txtCustomerID.Text = Convert.ToString(_parsedCustomerId);
                        }
                        catch
                        {
                            MessageBox.Show("Customer ID was not returned. Account could not be created.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderDataValid())
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspPlaceNewOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                        sqlCommand.Parameters["@CustomerID"].Value = _parsedCustomerId;

                        sqlCommand.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime, 8));
                        sqlCommand.Parameters["@OrderDate"].Value = dtpOrderDate.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
                        sqlCommand.Parameters["@Amount"].Value = numOrderAmount.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.Char, 1));
                        sqlCommand.Parameters["@Status"].Value = "O";

                        sqlCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
                        sqlCommand.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;

                        try
                        {
                            connection.Open();

                            sqlCommand.ExecuteNonQuery();

                            _orderId = (int)sqlCommand.Parameters["@RC"].Value;
                            MessageBox.Show("Order number " + _orderId + " has been submitted.");
                        }
                        catch
                        {
                            MessageBox.Show("Order could not be placed.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnAddFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddAnotherAccount_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool IsCustomerNameValid()
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }

            return true;
        }

        private bool IsOrderDataValid()
        {
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please create customer account before placing order.");
                return false;
            }
            
            if (numOrderAmount.Value < 1)
            {
                MessageBox.Show("Please specify an order amount.");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtCustomerID.Clear();
            dtpOrderDate.Value = DateTime.Now;
            numOrderAmount.Value = 0;
            _parsedCustomerId = 0;
        }
    }
}
