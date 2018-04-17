namespace Prova1.WinApp
{
    partial class DonaLaura
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
            this.tabDonaLoura = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpManufacture = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIsAvailable = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabPage();
            this.btnProductReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClearOrders = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.tabDonaLoura.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tabList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDonaLoura
            // 
            this.tabDonaLoura.Controls.Add(this.tabRegister);
            this.tabDonaLoura.Controls.Add(this.tabList);
            this.tabDonaLoura.Controls.Add(this.tabPage1);
            this.tabDonaLoura.Location = new System.Drawing.Point(1, 1);
            this.tabDonaLoura.Name = "tabDonaLoura";
            this.tabDonaLoura.SelectedIndex = 0;
            this.tabDonaLoura.Size = new System.Drawing.Size(342, 237);
            this.tabDonaLoura.TabIndex = 2;
            this.tabDonaLoura.SelectedIndexChanged += new System.EventHandler(this.tabLivraria_SelectedIndexChanged);
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.btnClear);
            this.tabRegister.Controls.Add(this.txtExpense);
            this.tabRegister.Controls.Add(this.txtSale);
            this.tabRegister.Controls.Add(this.dtpExpiration);
            this.tabRegister.Controls.Add(this.label3);
            this.tabRegister.Controls.Add(this.label11);
            this.tabRegister.Controls.Add(this.dtpManufacture);
            this.tabRegister.Controls.Add(this.label4);
            this.tabRegister.Controls.Add(this.btnCancel);
            this.tabRegister.Controls.Add(this.btnSave);
            this.tabRegister.Controls.Add(this.txtId);
            this.tabRegister.Controls.Add(this.label6);
            this.tabRegister.Controls.Add(this.cbIsAvailable);
            this.tabRegister.Controls.Add(this.txtName);
            this.tabRegister.Controls.Add(this.label2);
            this.tabRegister.Controls.Add(this.label1);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(334, 211);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Cadastro";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(131, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(254, 72);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(67, 20);
            this.txtExpense.TabIndex = 27;
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(90, 72);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(67, 20);
            this.txtSale.TabIndex = 26;
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiration.Location = new System.Drawing.Point(90, 131);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(96, 20);
            this.dtpExpiration.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fabricação:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Compra:";
            // 
            // dtpManufacture
            // 
            this.dtpManufacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManufacture.Location = new System.Drawing.Point(90, 100);
            this.dtpManufacture.Name = "dtpManufacture";
            this.dtpManufacture.Size = new System.Drawing.Size(96, 20);
            this.dtpManufacture.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Validade:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DimGray;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Location = new System.Drawing.Point(90, 16);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(42, 20);
            this.txtId.TabIndex = 12;
            this.txtId.Text = "0";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id:";
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.AutoSize = true;
            this.cbIsAvailable.Location = new System.Drawing.Point(215, 117);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(83, 17);
            this.cbIsAvailable.TabIndex = 8;
            this.cbIsAvailable.Text = "Disponível?";
            this.cbIsAvailable.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.btnProductReport);
            this.tabList.Controls.Add(this.btnDelete);
            this.tabList.Controls.Add(this.btnEdit);
            this.tabList.Controls.Add(this.lbProducts);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(334, 211);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "Lista";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // btnProductReport
            // 
            this.btnProductReport.Location = new System.Drawing.Point(88, 11);
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Size = new System.Drawing.Size(75, 23);
            this.btnProductReport.TabIndex = 3;
            this.btnProductReport.Text = "Relatório";
            this.btnProductReport.UseVisualStyleBackColor = true;
            this.btnProductReport.Click += new System.EventHandler(this.btnProductReport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(254, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(169, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(6, 40);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(325, 160);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClearOrders);
            this.tabPage1.Controls.Add(this.btnTotal);
            this.tabPage1.Controls.Add(this.btnDeleteOrder);
            this.tabPage1.Controls.Add(this.btnEditOrder);
            this.tabPage1.Controls.Add(this.numQty);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtCustomer);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbProducts);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lbOrders);
            this.tabPage1.Controls.Add(this.btnSaveOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 211);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Venda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClearOrders
            // 
            this.btnClearOrders.Location = new System.Drawing.Point(177, 84);
            this.btnClearOrders.Name = "btnClearOrders";
            this.btnClearOrders.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrders.TabIndex = 11;
            this.btnClearOrders.Text = "Limpar";
            this.btnClearOrders.UseVisualStyleBackColor = true;
            this.btnClearOrders.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Enabled = false;
            this.btnTotal.Location = new System.Drawing.Point(253, 182);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 10;
            this.btnTotal.Text = "Lucro";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Enabled = false;
            this.btnDeleteOrder.Location = new System.Drawing.Point(253, 153);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 9;
            this.btnDeleteOrder.Text = "Excluir";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Enabled = false;
            this.btnEditOrder.Location = new System.Drawing.Point(253, 124);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(75, 23);
            this.btnEditOrder.TabIndex = 8;
            this.btnEditOrder.Text = "Editar";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(258, 34);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(44, 20);
            this.numQty.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Quantidade:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(60, 20);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(121, 20);
            this.txtCustomer.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Produto:";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(60, 46);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 21);
            this.cmbProducts.TabIndex = 3;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cliente:";
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(10, 124);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(240, 82);
            this.lbOrders.TabIndex = 1;
            this.lbOrders.SelectedIndexChanged += new System.EventHandler(this.lbOrders_SelectedIndexChanged);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(96, 84);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrder.TabIndex = 0;
            this.btnSaveOrder.Text = "Salvar";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // DonaLaura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 240);
            this.Controls.Add(this.tabDonaLoura);
            this.MaximizeBox = false;
            this.Name = "DonaLaura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dona Laura";
            this.tabDonaLoura.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDonaLoura;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpManufacture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbIsAvailable;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Button btnClearOrders;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProductReport;
    }
}

