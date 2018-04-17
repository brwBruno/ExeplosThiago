using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Dominio;

namespace TesteMariana.WinApp.Funcionalidades.Materias
{
    public partial class CadastroMateriaDialog : Form
    {
        private Materia _materia;

        public Materia Materia
        {
            get { return _materia; }
            set
            {
                _materia = value;

                txtId.Text = _materia.Id.ToString();
                txtNome.Text = _materia.Nome;
                cmbDisciplina.SelectedItem = _materia.Disciplina;
                cmbSerie.SelectedItem = _materia.Serie;
            }
        }

        public CadastroMateriaDialog(IList<Disciplina> disciplinas, IList<Serie> series)
        {
            InitializeComponent();

            if (disciplinas == null || disciplinas.Count == 0)
                throw new ArgumentNullException("Deve ter disciplinas cadastradas");

            if (series == null || series.Count == 0)
                throw new ArgumentNullException("Deve ter series cadastradas");

            AtualizaCombobox(disciplinas, series);
        }

        public CadastroMateriaDialog(Materia materiaSelecionada, IList<Disciplina> disciplinas, IList<Serie> series)
        {
            InitializeComponent();

            AtualizaCombobox(disciplinas, series);

            Materia = materiaSelecionada;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (_materia == null)
            {
                _materia = new Materia();
            }

            _materia.Id = int.Parse(txtId.Text);
            _materia.Nome = txtNome.Text;
            _materia.Disciplina = cmbDisciplina.SelectedItem as Disciplina;
            _materia.Serie = cmbSerie.SelectedItem as Serie;

            try
            {
                _materia.Valida();
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizaCombobox(IList<Disciplina> disciplinas, IList<Serie> series)
        {
            cmbDisciplina.Items.Clear();

            foreach (var item in disciplinas)
            {
                cmbDisciplina.Items.Add(item);
            }

            cmbSerie.Items.Clear();

            foreach (var item in series)
            {
                cmbSerie.Items.Add(item);
            }
        }
    }
}