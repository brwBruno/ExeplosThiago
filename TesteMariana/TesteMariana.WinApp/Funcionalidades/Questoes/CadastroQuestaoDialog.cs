using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Dominio;

namespace TesteMariana.WinApp.Funcionalidades.Questoes
{
    public partial class CadastroQuestaoDialog : Form
    {
        private Questao _questao;
        private Alternativa _alternativa;

        public Questao Questao
        {
            get { return _questao; }
            set
            {
                _questao = value;

                txtId.Text = _questao.Id.ToString();
                txtEnunciado.Text = _questao.Enunciado;
                cmbBimestre.SelectedItem = _questao.Bimestre;
                cmbMateria.SelectedItem = _questao.Materia;

                ListarAlternativas(_questao.Alternativas);
            }
        }

        private void ListarAlternativas(List<Alternativa> alternativas)
        {
            listAlternativas.Items.Clear();

            foreach (var item in alternativas)
            {
                listAlternativas.Items.Add(item);
            }
        }

        public CadastroQuestaoDialog()
        {
            InitializeComponent();
        }

        public CadastroQuestaoDialog(IList<Materia> materias) : this()
        {
            if (materias == null || materias.Count == 0)
                throw new ArgumentNullException( "Deve ter disciplinas cadastradas");

            AtualizaCombobox(materias);
        }

        private void AtualizaCombobox(IList<Materia> materias)
        {
            cmbMateria.Items.Clear();

            foreach (var item in materias)
            {
                cmbMateria.Items.Add(item);
            }
        }

        private void btnAdicionarAlteranativa_Click(object sender, EventArgs e)
        {
            AtualizaComboboxLetra();
            try
            {
                if (_alternativa == null)
                    _alternativa = new Alternativa();
                _alternativa.Letra = Char.Parse(cmbLetras.Text);
                _alternativa.Resposta = txtResposta.Text;
                _alternativa.Correta = cbCorreta.Checked;

                Questao.AdcicionaAlternativa(_alternativa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizaComboboxLetra()
        {
            cmbLetras.Items.Clear();

            cmbLetras.Items.Add("A");
        }

        private void btnRemoverAlternativa_Click(object sender, EventArgs e)
        {

        }
    }
}