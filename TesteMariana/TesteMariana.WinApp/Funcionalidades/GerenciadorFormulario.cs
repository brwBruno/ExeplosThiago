using System.Windows.Forms;

namespace TesteMariana.WinApp.Funcionalidades
{
    public abstract class GerenciadorFormulario
    {
        public abstract void Adicionar();

        public abstract UserControl CarregarListagem();

        public abstract string ObtemTipoCadastro();

        public abstract void Excluir();

        public abstract void Editar();

        public abstract void AtualizarLista();
    }
}