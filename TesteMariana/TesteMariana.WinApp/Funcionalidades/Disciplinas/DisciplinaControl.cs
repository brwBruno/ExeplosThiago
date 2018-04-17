using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Disciplinas;
using TesteMariana.Infra.Data;

namespace TesteMariana.WinApp.Funcionalidades.Disciplinas
{
    public partial class DisciplinaControl : UserControl
    {
        private IDisciplinaRepository _disciplinaRepository;
        private DisciplinaService _disciplinaService;

        public DisciplinaControl()
        {

            InitializeComponent();

            _disciplinaRepository = new DisciplinaRepository();
            _disciplinaService = new DisciplinaService(_disciplinaRepository);

        }

        public void PopularListagemDisciplinas(IList<Disciplina> disciplinas)
        {
            listDisciplinas.Items.Clear();

            foreach (Disciplina item in disciplinas)
            {
                listDisciplinas.Items.Add(item);
            }
        }

        public Disciplina ObtemDisciplinaSelecionada()
        {
            return (Disciplina)listDisciplinas.SelectedItem;
        }
    }
}