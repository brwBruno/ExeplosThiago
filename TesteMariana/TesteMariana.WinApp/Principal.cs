using System;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio.Funcionalidades.Alternativas;
using TesteMariana.Dominio.Funcionalidades.Disciplinas;
using TesteMariana.Dominio.Funcionalidades.Materias;
using TesteMariana.Dominio.Funcionalidades.Questoes;
using TesteMariana.Dominio.Funcionalidades.Series;
using TesteMariana.Infra.Data;
using TesteMariana.WinApp.Funcionalidades;
using TesteMariana.WinApp.Funcionalidades.Disciplinas;
using TesteMariana.WinApp.Funcionalidades.Materias;
using TesteMariana.WinApp.Funcionalidades.Questaos;
using TesteMariana.WinApp.Funcionalidades.Series;

namespace TesteMariana.WinApp
{
    public partial class Principal : Form
    {
        private static IDisciplinaRepository _disciplinaRepository = new DisciplinaRepository();
        private static ISerieRepository _serieRepository = new SerieRepository();
        private static IMateriaRepository _materiaRepository = new MateriaRepository();
        private static IQuestaoRepository _questaoRepository = new QuestaoRepository();
        private static IAlternativaRepository _alternativaRepository = new AlternativaRepository();

        private DisciplinaService _disciplinaService = new DisciplinaService(_disciplinaRepository);
        private SerieService _serieService = new SerieService(_serieRepository);
        private MateriaService _materiaService = new MateriaService(_materiaRepository);
        private QuestaoService _questaoService = new QuestaoService(_questaoRepository, _alternativaRepository);
        private GerenciadorFormulario _gerenciador;

        private DisciplinaGerenciadorFormulario _disciplinaGerenciador;
        private SerieGerenciadorFormulario _serieGerenciador;
        private MateriaGerenciadorFormulario _materiaGerenciador;
        private QuestaoGerenciadorFormulario _questaoGerenciador;



        public Principal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_disciplinaGerenciador == null)
                _disciplinaGerenciador = new DisciplinaGerenciadorFormulario(_disciplinaService);

            CarregarCadastro(_disciplinaGerenciador);
        }

        private void CarregarCadastro(GerenciadorFormulario gerenciador)
        {
            _gerenciador = gerenciador;

            lblStatus.Text = _gerenciador.ObtemTipoCadastro();

            UserControl listagem = _gerenciador.CarregarListagem();

            listagem.Dock = DockStyle.Fill;

            panControl.Controls.Clear();

            panControl.Controls.Add(listagem);

            _gerenciador.AtualizarLista();

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSet.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _gerenciador.Adicionar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");

                _gerenciador.Adicionar();
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            _gerenciador.Excluir();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _gerenciador.Editar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");

                _gerenciador.Editar();
            }
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serieGerenciador == null)
                _serieGerenciador = new SerieGerenciadorFormulario(_serieService);

            CarregarCadastro(_serieGerenciador);
        }

        private void matériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_materiaGerenciador == null)
                _materiaGerenciador = new MateriaGerenciadorFormulario(_materiaService,_disciplinaService, _serieService);

            CarregarCadastro(_materiaGerenciador);
        }

        private void questãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_questaoGerenciador == null)
                _questaoGerenciador = new QuestaoGerenciadorFormulario(_questaoService,_disciplinaService, _materiaService);

            CarregarCadastro(_questaoGerenciador);
        }
    }
}