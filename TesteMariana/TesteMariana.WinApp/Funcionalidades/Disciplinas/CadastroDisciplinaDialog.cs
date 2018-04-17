using System;
using System.Windows.Forms;
using TesteMariana.Dominio;

namespace TesteMariana.WinApp.Funcionalidades.Disciplinas
{
    public partial class CadastroDisciplinaDialog : Form
    {
        private Disciplina _disciplina;

        public Disciplina Disciplina
        {
            get { return _disciplina; }
            set
            {
                _disciplina = value;

                txtId.Text = _disciplina.Id.ToString();
                txtNome.Text = _disciplina.Nome;
            }
        }

        public CadastroDisciplinaDialog()
        {
            InitializeComponent();
        }

        public CadastroDisciplinaDialog(Disciplina disciplinaSelecionada)
        {
            InitializeComponent();

            Disciplina = disciplinaSelecionada;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (_disciplina == null)
            {
                _disciplina = new Disciplina();
            }

            _disciplina.Nome = txtNome.Text;

            try
            {
                _disciplina.Valida();
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message);
            }
        }
    }
}