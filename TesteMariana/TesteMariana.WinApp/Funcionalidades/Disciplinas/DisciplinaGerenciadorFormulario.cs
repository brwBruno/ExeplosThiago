using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio;

namespace TesteMariana.WinApp.Funcionalidades.Disciplinas
{
    public class DisciplinaGerenciadorFormulario : GerenciadorFormulario
    {
        private readonly DisciplinaService _disciplinaService;

        private DisciplinaControl _disciplinaControl;

        public DisciplinaGerenciadorFormulario(DisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        public override void Adicionar()
        {
            CadastroDisciplinaDialog dialog = new CadastroDisciplinaDialog();

            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _disciplinaService.Adicionar(dialog.Disciplina);
                ListarDisciplinas();
            }
        }

        private void ListarDisciplinas()
        {
            IList<Disciplina> disciplinas = _disciplinaService.SelecionaTudo();

            _disciplinaControl.PopularListagemDisciplinas(disciplinas);
        }

        //TODO: ANALISAR NOME
        public override UserControl CarregarListagem()
        {
            if (_disciplinaControl == null)
                _disciplinaControl = new DisciplinaControl();

            return _disciplinaControl;
        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = _disciplinaControl.ObtemDisciplinaSelecionada();

            if (disciplinaSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a disciplina " 
                    + disciplinaSelecionada.Nome, "Excluir Disciplina",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        _disciplinaService.Deletar(disciplinaSelecionada);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    ListarDisciplinas();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma disciplina!");
            }
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionada = _disciplinaControl.ObtemDisciplinaSelecionada();

            if (disciplinaSelecionada != null)
            {
                CadastroDisciplinaDialog dialog = new CadastroDisciplinaDialog(disciplinaSelecionada);
                DialogResult resultado = dialog.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    _disciplinaService.Editar(disciplinaSelecionada);
                }

                ListarDisciplinas();
            }
            else
            {
                MessageBox.Show("Selecione uma disciplina!");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Disciplinas";
        }

        public override void AtualizarLista()
        {
            ListarDisciplinas();
        }
    }
}