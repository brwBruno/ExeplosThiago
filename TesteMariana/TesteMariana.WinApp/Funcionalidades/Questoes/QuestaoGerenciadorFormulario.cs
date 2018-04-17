using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio;
using TesteMariana.WinApp.Funcionalidades.Questoes;

namespace TesteMariana.WinApp.Funcionalidades.Questaos
{
    public class QuestaoGerenciadorFormulario : GerenciadorFormulario
    {
        private readonly QuestaoService _questaoService;
        private readonly DisciplinaService _disciplinaService;
        private readonly MateriaService _materiaService;

        private QuestaoControl _questaoControl;
        private IList<Disciplina> _disciplinas;
        private IList<Materia> _materias;

        public QuestaoGerenciadorFormulario(QuestaoService questaoService, DisciplinaService disciplinaService, MateriaService materiaService)
        {
            _questaoService = questaoService;
            _disciplinaService = disciplinaService;
            _materiaService = materiaService;
        }

        public override void Adicionar()
        {
            AtualizaComboBox();

            CadastroQuestaoDialog dialog = new CadastroQuestaoDialog(_materias);
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _questaoService.Adicionar(dialog.Questao);
                ListarQuestaos();
            }
        }

        private void ListarQuestaos()
        {
            IList<Questao> questaos = _questaoService.SelecionaTodas();

            _questaoControl.PopularListagemQuestaos(questaos);
        }

        public override UserControl CarregarListagem()
        {
            if (_questaoControl == null)
                _questaoControl = new QuestaoControl();

            return _questaoControl;
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = _questaoControl.ObtemQuestaoSelecionada();

            if (questaoSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Excluir Questao",
                    "Tem certeza que deseja excluir a questao " + questaoSelecionada.Enunciado,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    _questaoService.Deletar(questaoSelecionada);

                    ListarQuestaos();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma questao!");
            }
        }

        public override void Editar()
        {
            AtualizaComboBox();

            Questao questaoSelecionada = _questaoControl.ObtemQuestaoSelecionada();

            if (questaoSelecionada != null)
            {
                //CadastroQuestaoDialog dialog = new CadastroQuestaoDialog(questaoSelecionada, _disciplinas, _series);
                //DialogResult resultado = dialog.ShowDialog();

                //if (resultado == DialogResult.OK)
                //{
                //    _questaoService.Edita(questaoSelecionada);
                //}

                ListarQuestaos();
            }
            else
            {
                MessageBox.Show("Selecione uma questao!");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Questaos";
        }

        public override void AtualizarLista()
        {
            ListarQuestaos();
        }

        private void AtualizaComboBox()
        {
            _materias = _materiaService.SelecionaTudo();
        }
    }
}