using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio;

namespace TesteMariana.WinApp.Funcionalidades.Materias
{
    public class MateriaGerenciadorFormulario : GerenciadorFormulario
    {
        private readonly MateriaService _materiaService;
        private readonly DisciplinaService _disciplinaService;
        private readonly SerieService _serieService;

        private MateriaControl _materiaControl;
        private IList<Disciplina> _disciplinas;
        private IList<Serie> _series;

        public MateriaGerenciadorFormulario(MateriaService materiaService, DisciplinaService disciplinaService, SerieService serieService)
        {
            _materiaService = materiaService;
            _disciplinaService = disciplinaService;
            _serieService = serieService;
        }

        public override void Adicionar()
        {
            AtualizaComboBox();

            CadastroMateriaDialog dialog = new CadastroMateriaDialog(_disciplinas, _series);
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _materiaService.Adiciona(dialog.Materia);
                ListarMaterias();
            }
        }

        private void ListarMaterias()
        {
            IList<Materia> materias = _materiaService.SelecionaTudo();

            _materiaControl.PopularListagemMaterias(materias);
        }

        public override UserControl CarregarListagem()
        {
            if (_materiaControl == null)
                _materiaControl = new MateriaControl();

            return _materiaControl;
        }

        public override void Excluir()
        {
            Materia materiaSelecionada = _materiaControl.ObtemMateriaSelecionada();

            if (materiaSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Excluir Materia",
                    "Tem certeza que deseja excluir a materia " + materiaSelecionada.Nome,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        _materiaService.Deletar(materiaSelecionada);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    ListarMaterias();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma materia!");
            }
        }

        public override void Editar()
        {
            AtualizaComboBox();

            Materia materiaSelecionada = _materiaControl.ObtemMateriaSelecionada();

            if (materiaSelecionada != null)
            {
                CadastroMateriaDialog dialog = new CadastroMateriaDialog(materiaSelecionada, _disciplinas, _series);
                DialogResult resultado = dialog.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    _materiaService.Editar(materiaSelecionada);
                }

                ListarMaterias();
            }
            else
            {
                MessageBox.Show("Selecione uma materia!");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Materias";
        }

        public override void AtualizarLista()
        {
            ListarMaterias();
        }

        private void AtualizaComboBox()
        {
            _disciplinas = _disciplinaService.SelecionaTudo();
            _series = _serieService.SelecionaTudo();
        }
    }
}