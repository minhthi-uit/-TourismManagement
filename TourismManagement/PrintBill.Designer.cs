
namespace TourismManagement
{
    partial class PrintBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSurchageRatio = new System.Windows.Forms.TextBox();
            this.dtPaymentDay = new System.Windows.Forms.DateTimePicker();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.lbTG = new System.Windows.Forms.Label();
            this.lbNTT = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lbMHĐ = new System.Windows.Forms.Label();
            this.lbMKH = new System.Windows.Forms.Label();
            this.tableLayoutPanelHĐ = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbTT = new System.Windows.Forms.Label();
            this.lbTBĐG = new System.Windows.Forms.Label();
            this.lbSNT = new System.Windows.Forms.Label();
            this.txtApartment_Money = new System.Windows.Forms.TextBox();
            this.txtRentalDays = new System.Windows.Forms.TextBox();
            this.txtTypeOfApartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApartmentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServiceFee = new System.Windows.Forms.TextBox();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tableLayoutPanelHĐ.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILL";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSurchageRatio);
            this.panel2.Controls.Add(this.dtPaymentDay);
            this.panel2.Controls.Add(this.txtIdBill);
            this.panel2.Controls.Add(this.lbTG);
            this.panel2.Controls.Add(this.lbNTT);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.lbMHĐ);
            this.panel2.Controls.Add(this.lbMKH);
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 90);
            this.panel2.TabIndex = 3;
            // 
            // txtSurchageRatio
            // 
            this.txtSurchageRatio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSurchageRatio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurchageRatio.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSurchageRatio.Location = new System.Drawing.Point(846, 53);
            this.txtSurchageRatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurchageRatio.Name = "txtSurchageRatio";
            this.txtSurchageRatio.ReadOnly = true;
            this.txtSurchageRatio.Size = new System.Drawing.Size(142, 15);
            this.txtSurchageRatio.TabIndex = 18;
            // 
            // dtPaymentDay
            // 
            this.dtPaymentDay.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtPaymentDay.Enabled = false;
            this.dtPaymentDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDay.Location = new System.Drawing.Point(846, 14);
            this.dtPaymentDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPaymentDay.Name = "dtPaymentDay";
            this.dtPaymentDay.Size = new System.Drawing.Size(184, 22);
            this.dtPaymentDay.TabIndex = 8;
            // 
            // txtIdBill
            // 
            this.txtIdBill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdBill.Location = new System.Drawing.Point(300, 17);
            this.txtIdBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.ReadOnly = true;
            this.txtIdBill.Size = new System.Drawing.Size(184, 15);
            this.txtIdBill.TabIndex = 6;
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTG.Location = new System.Drawing.Point(653, 53);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(167, 19);
            this.lbTG.TabIndex = 16;
            this.lbTG.Text = "SURCHAGE_RATIO:";
            // 
            // lbNTT
            // 
            this.lbNTT.AutoSize = true;
            this.lbNTT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNTT.Location = new System.Drawing.Point(653, 17);
            this.lbNTT.Name = "lbNTT";
            this.lbNTT.Size = new System.Drawing.Size(129, 19);
            this.lbNTT.TabIndex = 2;
            this.lbNTT.Text = "PAYMENT_DAY:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCustomerName.Location = new System.Drawing.Point(300, 55);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(184, 15);
            this.txtCustomerName.TabIndex = 15;
            // 
            // lbMHĐ
            // 
            this.lbMHĐ.AutoSize = true;
            this.lbMHĐ.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMHĐ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMHĐ.Location = new System.Drawing.Point(79, 14);
            this.lbMHĐ.Name = "lbMHĐ";
            this.lbMHĐ.Size = new System.Drawing.Size(76, 19);
            this.lbMHĐ.TabIndex = 0;
            this.lbMHĐ.Text = "ID_BILL:";
            // 
            // lbMKH
            // 
            this.lbMKH.AutoSize = true;
            this.lbMKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMKH.Location = new System.Drawing.Point(79, 53);
            this.lbMKH.Name = "lbMKH";
            this.lbMKH.Size = new System.Drawing.Size(165, 19);
            this.lbMKH.TabIndex = 1;
            this.lbMKH.Text = "CUSTOMER_NAME:";
            // 
            // tableLayoutPanelHĐ
            // 
            this.tableLayoutPanelHĐ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanelHĐ.ColumnCount = 8;
            this.tableLayoutPanelHĐ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHĐ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHĐ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHĐ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHĐ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanelHĐ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanelHĐ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelHĐ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelHĐ.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanelHĐ.Controls.Add(this.txtUnitPrice, 4, 1);
            this.tableLayoutPanelHĐ.Controls.Add(this.lbTT, 5, 0);
            this.tableLayoutPanelHĐ.Controls.Add(this.lbTBĐG, 4, 0);
            this.tableLayoutPanelHĐ.Controls.Add(this.lbSNT, 2, 0);
            this.tableLayoutPanelHĐ.Controls.Add(this.txtApartment_Money, 5, 1);
            this.tableLayoutPanelHĐ.Controls.Add(this.txtRentalDays, 2, 1);
            this.tableLayoutPanelHĐ.Controls.Add(this.txtTypeOfApartment, 1, 1);
            this.tableLayoutPanelHĐ.Controls.Add(this.label2, 6, 0);
            this.tableLayoutPanelHĐ.Controls.Add(this.txtApartmentName, 0, 1);
            this.tableLayoutPanelHĐ.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelHĐ.Controls.Add(this.label5, 7, 0);
            this.tableLayoutPanelHĐ.Controls.Add(this.txtServiceFee, 6, 1);
            this.tableLayoutPanelHĐ.Controls.Add(this.txtTotalMoney, 7, 1);
            this.tableLayoutPanelHĐ.Location = new System.Drawing.Point(24, 253);
            this.tableLayoutPanelHĐ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelHĐ.Name = "tableLayoutPanelHĐ";
            this.tableLayoutPanelHĐ.RowCount = 2;
            this.tableLayoutPanelHĐ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHĐ.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHĐ.Size = new System.Drawing.Size(1184, 74);
            this.tableLayoutPanelHĐ.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type_Of_Apartment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(548, 48);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(163, 22);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTT.Location = new System.Drawing.Point(717, 0);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(135, 16);
            this.lbTT.TabIndex = 4;
            this.lbTT.Text = "Apartment_Money";
            this.lbTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTBĐG
            // 
            this.lbTBĐG.AutoSize = true;
            this.lbTBĐG.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTBĐG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTBĐG.Location = new System.Drawing.Point(548, 0);
            this.lbTBĐG.Name = "lbTBĐG";
            this.lbTBĐG.Size = new System.Drawing.Size(80, 16);
            this.lbTBĐG.TabIndex = 2;
            this.lbTBĐG.Text = "Unit_Price";
            this.lbTBĐG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSNT
            // 
            this.lbSNT.AutoSize = true;
            this.lbSNT.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSNT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSNT.Location = new System.Drawing.Point(377, 0);
            this.lbSNT.Name = "lbSNT";
            this.lbSNT.Size = new System.Drawing.Size(94, 16);
            this.lbSNT.TabIndex = 1;
            this.lbSNT.Text = "Rental_Days";
            this.lbSNT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApartment_Money
            // 
            this.txtApartment_Money.Location = new System.Drawing.Point(717, 48);
            this.txtApartment_Money.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApartment_Money.Name = "txtApartment_Money";
            this.txtApartment_Money.ReadOnly = true;
            this.txtApartment_Money.Size = new System.Drawing.Size(164, 22);
            this.txtApartment_Money.TabIndex = 12;
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Location = new System.Drawing.Point(377, 48);
            this.txtRentalDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.ReadOnly = true;
            this.txtRentalDays.Size = new System.Drawing.Size(165, 22);
            this.txtRentalDays.TabIndex = 9;
            // 
            // txtTypeOfApartment
            // 
            this.txtTypeOfApartment.Location = new System.Drawing.Point(200, 48);
            this.txtTypeOfApartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTypeOfApartment.Name = "txtTypeOfApartment";
            this.txtTypeOfApartment.ReadOnly = true;
            this.txtTypeOfApartment.Size = new System.Drawing.Size(171, 22);
            this.txtTypeOfApartment.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(887, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Service_Fee";
            // 
            // txtApartmentName
            // 
            this.txtApartmentName.BackColor = System.Drawing.SystemColors.Control;
            this.txtApartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApartmentName.Location = new System.Drawing.Point(3, 48);
            this.txtApartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApartmentName.Name = "txtApartmentName";
            this.txtApartmentName.ReadOnly = true;
            this.txtApartmentName.Size = new System.Drawing.Size(191, 22);
            this.txtApartmentName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apartment_Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1037, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total_Money";
            // 
            // txtServiceFee
            // 
            this.txtServiceFee.Location = new System.Drawing.Point(887, 49);
            this.txtServiceFee.Name = "txtServiceFee";
            this.txtServiceFee.Size = new System.Drawing.Size(144, 22);
            this.txtServiceFee.TabIndex = 16;
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Location = new System.Drawing.Point(1037, 49);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(144, 22);
            this.txtTotalMoney.TabIndex = 17;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(260, 408);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(273, 63);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print Bill";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(742, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(267, 63);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 490);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tableLayoutPanelHĐ);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "PrintBill";
            this.Text = "PrintBill";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanelHĐ.ResumeLayout(false);
            this.tableLayoutPanelHĐ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSurchageRatio;
        private System.Windows.Forms.DateTimePicker dtPaymentDay;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.Label lbNTT;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbMHĐ;
        private System.Windows.Forms.Label lbMKH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHĐ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.Label lbTBĐG;
        private System.Windows.Forms.Label lbSNT;
        private System.Windows.Forms.TextBox txtApartment_Money;
        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.TextBox txtTypeOfApartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApartmentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServiceFee;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
    }
}