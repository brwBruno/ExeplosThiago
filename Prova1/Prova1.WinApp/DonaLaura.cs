using Prova1.Applications;
using Prova1.Domain;
using System;
using System.Windows.Forms;

namespace Prova1.WinApp
{
    // Realizando o cadastro
    public partial class DonaLaura : Form
    {
        public DonaLaura()
        {
            InitializeComponent();

            ListOrders();
            ListProducts();
        }

        /// <summary>
        /// Estancias de serviços e objetos para manipulação do Windows Forms
        /// </summary>

        private Product _product = new Product();
        private Product _productSelected = new Product();
        private ProductService _productService = new ProductService();

        private Order _order = new Order();
        private OrderService _orderService = new OrderService();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FormProductToObject();

                if (_product.Id == 0)
                {
                    _productService.AddProduct(_product);
                }
                else
                {
                    _productService.UpdateProduct(_product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ClearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tabDonaLoura.SelectedIndex = 0;
            txtId.Text = _product.Id.ToString();
            txtName.Text = _product.Name;
            txtSale.Text = _product.Sale.ToString();
            txtExpense.Text = _product.Expense.ToString();
            cbIsAvailable.Checked = _product.IsAvailable ? true : false;
            dtpExpiration.Value = _product.Expiration;
            dtpManufacture.Value = _product.Manufacture;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_product != null)
            {
                var message = MessageBox.Show("Deseja excluir o produto " + _product.Name + "?", "Atenção",
                    MessageBoxButtons.YesNo);

                if (message == DialogResult.Yes)
                {
                    try
                    {
                        _productService.DeleteProduct(_product);
                        ListProducts();
                        ClearFields();
                    }
                    catch
                    {
                        MessageBox.Show("O prduto está relacionado a uma venda! Delete a venda primeiro!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir!");
            }
        }

        private void tabLivraria_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDeleteOrder.Enabled = false;
            btnEditOrder.Enabled = false;
            btnTotal.Enabled = false;
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _product = lbProducts.SelectedItem as Product;

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                FormOrderToObject();

                if (_order.Id == 0)
                {
                    _orderService.AddOrder(_order);
                }
                else
                {
                    FormOrderToObject();

                    _orderService.UpdateOrder(_order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearFields();
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _productSelected = cmbProducts.SelectedItem as Product;
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order = lbOrders.SelectedItem as Order;

            btnDeleteOrder.Enabled = true;
            btnEditOrder.Enabled = true;
            btnTotal.Enabled = true;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (_order != null)
            {
                var message = MessageBox.Show("Deseja excluir a venda " + _order.Customer + "?", "Atenção",
                    MessageBoxButtons.YesNo);

                if (message == DialogResult.Yes)
                {
                    _orderService.DeleteOrder(_order);

                    ListOrders();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma venda para excluir!");
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            txtCustomer.Text = _order.Customer;

            numQty.Value = _order.Quantity;

            cmbProducts.SelectedItem = _order.Product;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O lucro do produto selecionado é de: " + _order.Total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Converte os campos da tela de cadastro de produto para o objeto produto
        /// </summary>
        private void FormProductToObject()
        {
            if (txtSale.Text != "" || txtExpense.Text != "")
            {

           
            //Validação do componente txtBox para numérico
            if (!char.IsNumber(txtSale.Text.ToCharArray()[0])
                || !char.IsNumber(txtExpense.Text.ToCharArray()[0]))
            {
                throw new Exception("O valor deve ser numérico!");
            }
 }
            _product.Sale = double.Parse(txtSale.Text); //Convertendo string para double
            _product.Expense = Convert.ToDouble(txtExpense.Text); //Convertendo string para double
            _product.Name = txtName.Text;
            _product.IsAvailable = cbIsAvailable.Checked ? true : false; //Operador ternário
            _product.Expiration = dtpExpiration.Value;
            _product.Manufacture = dtpManufacture.Value;
        }

        /// <summary>
        /// Converte os campos da tela de cadastro de vendas para o objeto vendas
        /// </summary>
        private void FormOrderToObject()
        {
            _order.Customer = txtCustomer.Text;
            _order.Product = _productSelected;
            _order.Quantity = (int)numQty.Value; //cast de conversão do tipo decimal para int
        }

        /// <summary>
        /// Método privado que limpa a lista de vendas e lista novamente
        /// </summary>
        private void ListOrders()
        {
            lbOrders.Items.Clear();

            var list = _orderService.GetAllOrders();

            foreach (var item in list)
            {
                lbOrders.Items.Add(item);
            }
        }

        /// <summary>
        /// Método privado que limpa a lista de produtos e lista novamente
        /// </summary>
        private void ListProducts()
        {
            lbProducts.Items.Clear();
            cmbProducts.Items.Clear();

            var list = _productService.GetAllProducts();

            foreach (var item in list)
            {
                lbProducts.Items.Add(item);

                if (item.IsAvailable)
                {
                    cmbProducts.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Método privado que limpa capos do form de produtos e vendas
        /// Estancia um novos objetos
        /// Atualiza a lista de produtos e vendas
        /// </summary>
        private void ClearFields()
        {
            _product = new Product();
            _order = new Order();
            _productSelected = null;

            txtId.Text = "0";
            txtExpense.Clear();
            txtSale.Clear();
            txtName.Clear();
            dtpExpiration.Value = DateTime.Now;
            dtpManufacture.Value = DateTime.Now;
            cbIsAvailable.Checked = false;

            _order = new Order();
            txtCustomer.Clear();
            cmbProducts.SelectedIndex = -1;
            numQty.Value = 0;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteOrder.Enabled = false;
            btnTotal.Enabled = false;
            btnEditOrder.Enabled = false;

            ListOrders();
            ListProducts();
        }

        private void btnProductReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF|*.pdf";
                saveFileDialog1.Title = "Salvar";
                saveFileDialog1.ShowDialog();

                _productService.ReportList(saveFileDialog1.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}