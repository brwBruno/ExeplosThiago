using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio;
using TesteMariana.Infra.Data;

namespace TesteMariana.WinApp.Funcionalidades.Series
{
    public partial class SerieControl : UserControl
    {
        private SerieRepository _serieDAO;
        private SerieService _serieService;

        public SerieControl()
        {

            InitializeComponent();

            _serieDAO = new SerieRepository();
            _serieService = new SerieService(_serieDAO);

        }

        public void PopularListagemSeries(IList<Serie> series)
        {
            listSeries.Items.Clear();

            foreach (Serie item in series)
            {
                listSeries.Items.Add(item);
            }
        }

        public Serie ObtemSerieSelecionada()
        {
            return (Serie)listSeries.SelectedItem;
        }
    }
}