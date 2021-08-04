
namespace SimpleDataApp
{
    partial class FillOrCancel
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
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.specifyFilledDateLabel = new System.Windows.Forms.Label();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.orderIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOrderID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFindByOrderID, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFillDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.specifyFilledDateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomerOrders, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelOrder, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnFillOrder, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnFinishUpdates, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Location = new System.Drawing.Point(105, 19);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(85, 25);
            this.orderIDLabel.TabIndex = 0;
            this.orderIDLabel.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtOrderID, 2);
            this.txtOrderID.Location = new System.Drawing.Point(203, 16);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(366, 31);
            this.txtOrderID.TabIndex = 1;
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindByOrderID.Location = new System.Drawing.Point(621, 14);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Size = new System.Drawing.Size(112, 34);
            this.btnFindByOrderID.TabIndex = 2;
            this.btnFindByOrderID.Text = "Find Order";
            this.btnFindByOrderID.UseVisualStyleBackColor = true;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.dtpFillDate, 2);
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(430, 79);
            this.dtpFillDate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(300, 31);
            this.dtpFillDate.TabIndex = 3;
            // 
            // specifyFilledDateLabel
            // 
            this.specifyFilledDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.specifyFilledDateLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.specifyFilledDateLabel, 2);
            this.specifyFilledDateLabel.Location = new System.Drawing.Point(93, 82);
            this.specifyFilledDateLabel.Name = "specifyFilledDateLabel";
            this.specifyFilledDateLabel.Size = new System.Drawing.Size(290, 25);
            this.specifyFilledDateLabel.TabIndex = 4;
            this.specifyFilledDateLabel.Text = "If filling an order, specify filled date";
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCustomerOrders, 4);
            this.dgvCustomerOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(3, 129);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.ReadOnly = true;
            this.dgvCustomerOrders.RowHeadersVisible = false;
            this.dgvCustomerOrders.RowHeadersWidth = 62;
            this.dgvCustomerOrders.RowTemplate.Height = 33;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(769, 206);
            this.dgvCustomerOrders.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelOrder.Location = new System.Drawing.Point(21, 364);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(150, 34);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Canel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFillOrder.Location = new System.Drawing.Point(214, 364);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(150, 34);
            this.btnFillOrder.TabIndex = 7;
            this.btnFillOrder.Text = "Fill Order";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinishUpdates.Location = new System.Drawing.Point(621, 364);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(112, 34);
            this.btnFinishUpdates.TabIndex = 8;
            this.btnFinishUpdates.Text = "Finish";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FillOrCancel";
            this.Text = "FillOrCancel";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnFindByOrderID;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.Label specifyFilledDateLabel;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnFinishUpdates;
    }
}