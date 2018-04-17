using System.Collections.Generic;
using System.Windows.Forms;
using TesteMariana.Aplicacao;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Materias;
using TesteMariana.Infra.Data;

namespace TesteMariana.WinApp.Funcionalidades.Materias
{
    public partial class MateriaControl : UserControl
    {
        private IMateriaRepository _materiaRepository;
        private MateriaService _materiaService;

        public MateriaControl()
        {

            InitializeComponent();

            _materiaRepository = new MateriaRepository();
            _materiaService = new MateriaService(_materiaRepository);

        }

        public void PopularListagemMaterias(IList<Materia> materias)
        {
            listMaterias.Items.Clear();

            foreach (Materia item in materias)
            {
                listMaterias.Items.Add(item);
            }
        }

        public Materia ObtemMateriaSelecionada()
        {
            return (Materia)listMaterias.SelectedItem;
        }
    }
}