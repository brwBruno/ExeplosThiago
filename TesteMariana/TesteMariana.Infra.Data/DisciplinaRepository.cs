using System;
using System.Collections.Generic;
using System.Data;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Disciplinas;

namespace TesteMariana.Infra.Data
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        #region QUERYS

        private const string SqlInsereDisciplina =
            @"INSERT INTO TBDISCIPLINA
                (NOME)
            VALUES
                ({0}NOME)";

        private const string SqlEditaDisciplina =
            @"UPDATE TBDISCIPLINA
                SET
                    NOME = {0}NOME

                WHERE ID = {0}ID";

        private const string SqlDeletaDisciplina =
           @"DELETE FROM TBDISCIPLINA
                WHERE ID = {0}ID";

        private const string SqlSelecionaTodasDisciplinas =
           @"SELECT
                ID,
                NOME
            FROM
                TBDISCIPLINA";

        private const string SqlSelecionaDisciplinaPorId =
           @"SELECT
                ID,
                NOME
            FROM
                TBDISCIPLINA
            WHERE ID = {0}ID";

        private const string SqlSelecionaDisciplinaPorNome =
           @"SELECT
                ID,
                NOME
            FROM
                TBDISCIPLINA
            WHERE NOME = {0}NOME";

        private const string SqlVerificaDependencia =
           @"SELECT
                NOME
            FROM
                TBMATERIA
            WHERE DISCIPLINAID = {0}ID_DISCIPLINA";

        #endregion QUERYS

        public Disciplina Adicionar(Disciplina novaDisciplina)
        {
            novaDisciplina.Id = Db.Insert(SqlInsereDisciplina, GetParametros(novaDisciplina));

            return novaDisciplina;
        }

        public Disciplina Editar(Disciplina disciplinaEditada)
        {
            Db.Update(SqlEditaDisciplina, GetParametros(disciplinaEditada));

            return disciplinaEditada;
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            Db.Delete(SqlDeletaDisciplina, parms);
        }

        public Disciplina SelecionaPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            return Db.Get(SqlSelecionaDisciplinaPorId, Converter, parms);
        }

        public List<Disciplina> SelecionaTudo()
        {
            return Db.GetAll(SqlSelecionaTodasDisciplinas, Converter);
        }

        public bool Existe(string nome)
        {
            var parms = new Dictionary<string, object> { { "NOME", nome } };

            var resultado = Db.Get(SqlSelecionaDisciplinaPorNome, Converter, parms);

            return resultado != null;
        }

        private Dictionary<string, object> GetParametros(Disciplina disciplina)
        {
            return new Dictionary<string, object>
            {
                { "ID", disciplina.Id },
                { "NOME", disciplina.Nome },
            };
        }

        public bool RegistroComDependencia(int id)
        {
            var parms = new Dictionary<string, object> { { "ID_DISCIPLINA", id } };

            var resultado = Db.Get(SqlVerificaDependencia, ConverterMateria, parms);

            return resultado != null;
        }

        private static Func<IDataReader, Disciplina> Converter = reader =>
          new Disciplina
          {
              Id = Convert.ToInt32(reader["ID"]),
              Nome = Convert.ToString(reader["NOME"])
          };

        private static Func<IDataReader, Materia> ConverterMateria = reader =>
            new Materia
            {
                Nome = Convert.ToString(reader["NOME"])
            };
    }
}