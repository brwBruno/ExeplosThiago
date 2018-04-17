using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio;
using TesteMariana.Infra.Data;

namespace TesteMariana.WinApp.Funcionalidades.Questaos
{
    public partial class QuestaoControl : UserControl
    {
        private QuestaoRepository _questaoDAO;
        private AlternativaRepository _alternativaDAO;
        private QuestaoService _questaoService;

        public QuestaoControl()
        {
            InitializeComponent();

            _questaoDAO = new QuestaoRepository();
            _alternativaDAO = new AlternativaRepository();
            _questaoService = new QuestaoService(_questaoDAO, _alternativaDAO);
        }

        public void PopularListagemQuestaos(IList<Questao> questaos)
        {
            listQuestoes.Items.Clear();

            foreach (Questao item in questaos)
            {
                listQuestoes.Items.Add(item);
            }
        }

        public Questao ObtemQuestaoSelecionada()
        {
            return (Questao)listQuestoes.SelectedItem;
        }
    }
}