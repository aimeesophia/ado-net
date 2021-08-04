
namespace SimpleDataApp
{
    partial class NewCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.accountGroupBox = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.orderAmountLabel = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.accountGroupBox.SuspendLayout();
            this.orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.accountGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateAccount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPlaceOrder, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddAnotherAccount, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddFinish, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // accountGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.accountGroupBox, 2);
            this.accountGroupBox.Controls.Add(this.txtCustomerID);
            this.accountGroupBox.Controls.Add(this.txtCustomerName);
            this.accountGroupBox.Controls.Add(this.customerIDLabel);
            this.accountGroupBox.Controls.Add(this.customerNameLabel);
            this.accountGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountGroupBox.Location = new System.Drawing.Point(3, 3);
            this.accountGroupBox.Name = "accountGroupBox";
            this.accountGroupBox.Size = new System.Drawing.Size(380, 142);
            this.accountGroupBox.TabIndex = 0;
            this.accountGroupBox.TabStop = false;
            this.accountGroupBox.Text = "Add Account";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(159, 68);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(200, 31);
            this.txtCustomerID.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(159, 31);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 31);
            this.txtCustomerName.TabIndex = 2;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(6, 74);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(116, 25);
            this.customerIDLabel.TabIndex = 1;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(6, 37);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(145, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // orderGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.orderGroupBox, 2);
            this.orderGroupBox.Controls.Add(this.orderDateLabel);
            this.orderGroupBox.Controls.Add(this.dtpOrderDate);
            this.orderGroupBox.Controls.Add(this.numOrderAmount);
            this.orderGroupBox.Controls.Add(this.orderAmountLabel);
            this.orderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGroupBox.Location = new System.Drawing.Point(3, 151);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(380, 142);
            this.orderGroupBox.TabIndex = 1;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Create Order";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(6, 75);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(104, 25);
            this.orderDateLabel.TabIndex = 3;
            this.orderDateLabel.Text = "Order Date:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(159, 69);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 31);
            this.dtpOrderDate.TabIndex = 2;
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(159, 31);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(200, 31);
            this.numOrderAmount.TabIndex = 1;
            this.numOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOrderAmount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // orderAmountLabel
            // 
            this.orderAmountLabel.AutoSize = true;
            this.orderAmountLabel.Location = new System.Drawing.Point(6, 37);
            this.orderAmountLabel.Name = "orderAmountLabel";
            this.orderAmountLabel.Size = new System.Drawing.Size(128, 25);
            this.orderAmountLabel.TabIndex = 0;
            this.orderAmountLabel.Text = "Order Amount";
            // 
            // btnCreateAccount
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCreateAccount, 2);
            this.btnCreateAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateAccount.Location = new System.Drawing.Point(389, 111);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(383, 34);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnPlaceOrder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnPlaceOrder, 2);
            this.btnPlaceOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlaceOrder.Location = new System.Drawing.Point(389, 259);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(383, 34);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnAddAnotherAccount, 2);
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(480, 343);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(200, 34);
            this.btnAddAnotherAccount.TabIndex = 5;
            this.btnAddAnotherAccount.Text = "Add Another Account";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnAddFinish, 2);
            this.btnAddFinish.Location = new System.Drawing.Point(93, 343);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(200, 34);
            this.btnAddFinish.TabIndex = 4;
            this.btnAddFinish.Text = "Finish";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewCustomer";
            this.Text = "New Account and Order";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.accountGroupBox.ResumeLayout(false);
            this.accountGroupBox.PerformLayout();
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox accountGroupBox;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.Label orderAmountLabel;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddAnotherAccount;
        private System.Windows.Forms.Button btnAddFinish;
    }
}