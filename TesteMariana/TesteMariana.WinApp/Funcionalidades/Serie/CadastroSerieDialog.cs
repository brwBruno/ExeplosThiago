using System;
using System.Windows.Forms;
using TesteMariana.Dominio;

namespace TesteMariana.WinApp.Funcionalidades.Series
{
    public partial class CadastroSerieDialog : Form
    {
        private Serie _serie;

        public Serie Serie
        {
            get { return _serie; }
            set
            {
                _serie = value;

                txtId.Text = _serie.Id.ToString();
                txtDescricao.Text = _serie.Descricao;
            }
        }

        public CadastroSerieDialog()
        {
            InitializeComponent();
        }

        public CadastroSerieDialog(Serie serieSelecionada)
        {
            InitializeComponent();

            Serie = serieSelecionada;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (_serie == null)
            {
                _serie = new Serie();
            }

            _serie.Descricao = txtDescricao.Text + "ª Série";

            try
            {
                _serie.Valida();
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message);
            }
        }
    }
}