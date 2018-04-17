using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio;

namespace TesteMariana.WinApp.Funcionalidades.Series
{
    public class SerieGerenciadorFormulario : GerenciadorFormulario
    {
        private readonly SerieService _serieService;

        private SerieControl _serieControl;

        public SerieGerenciadorFormulario(SerieService serieService)
        {
            _serieService = serieService;
        }

        public override void Adicionar()
        {
            CadastroSerieDialog dialog = new CadastroSerieDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _serieService.Adicionar(dialog.Serie);
                ListarSeries();
            }
        }

        private void ListarSeries()
        {
            IList<Serie> series = _serieService.SelecionaTudo();

            _serieControl.PopularListagemSeries(series);
        }

        public override UserControl CarregarListagem()
        {
            if (_serieControl == null)
                _serieControl = new SerieControl();

            return _serieControl;
        }

        public override void Excluir()
        {
            Serie serieSelecionada = _serieControl.ObtemSerieSelecionada();

            if (serieSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a serie " 
                    + serieSelecionada.Descricao, "Excluir Serie",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        _serieService.Deletar(serieSelecionada);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    ListarSeries();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma serie!");
            }
        }

        public override void Editar()
        {
            Serie serieSelecionada = _serieControl.ObtemSerieSelecionada();

            if (serieSelecionada != null)
            {
                CadastroSerieDialog dialog = new CadastroSerieDialog(serieSelecionada);
                DialogResult resultado = dialog.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    _serieService.Editar(serieSelecionada);
                }

                ListarSeries();
            }
            else
            {
                MessageBox.Show("Selecione uma serie!");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Series";
        }

        public override void AtualizarLista()
        {
            ListarSeries();
        }
    }
}