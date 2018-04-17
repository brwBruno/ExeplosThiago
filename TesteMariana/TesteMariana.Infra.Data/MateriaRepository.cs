using System;
using System.Collections.Generic;
using System.Data;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Materias;

namespace TesteMariana.Infra.Data
{
    public class MateriaRepository : IMateriaRepository
    {
        #region QUERYS

        private const string SqlInsereMateria =
            @"INSERT INTO TBMATERIA
                (NOME, DISCIPLINAID, SERIEID)
            VALUES
                ({0}NOME, {0}DISCIPLINAID, {0}SERIEID)";

        private const string SqlEditaMateria =
            @"UPDATE TBMATERIA
                SET
                    NOME = {0}NOME,
                    DISCIPLINAID = {0}DISCIPLINAID,
                    SERIEID = {0}SERIEID
                WHERE ID = {0}ID";

        private const string SqlDeletaMateria =
           @"DELETE FROM TBMATERIA
                WHERE ID = {0}ID";

        private const string SqlSelecionaTodasMaterias =
           @"SELECT
                M.ID,
                M.NOME,
                M.DISCIPLINAID,
                M.SERIEID,
				D.NOME AS DISCIPLINANOME,
				S.DESCRICAO

            FROM
                TBMATERIA AS M
				INNER JOIN
				TBDISCIPLINA AS D ON D.ID = M.DISCIPLINAID
				INNER JOIN
				TBSERIE AS S ON S.ID = M.SERIEID";

        private const string SqlSelecionaMateriaPorId =
           @"SELECT
                M.ID,
                M.NOME,
                M.DISCIPLINAID,
                M.SERIEID,
			    D.NOME AS DISCIPLINANOME,
				S.DESCRICAO

            FROM
                TBMATERIA AS M
				INNER JOIN
				TBDISCIPLINA AS D ON D.ID = M.DISCIPLINAID
				INNER JOIN
				TBSERIE AS S ON S.ID = M.SERIEID
            WHERE M.ID = {0}ID";

        private const string SqlSelecionaMateriaPorNome =
            @"SELECT
                M.ID,
                M.NOME,
                M.DISCIPLINAID,
                M.SERIEID,
				D.NOME AS DISCIPLINANOME,
				S.DESCRICAO

            FROM
                TBMATERIA AS M
				INNER JOIN
				TBDISCIPLINA AS D ON D.ID = M.DISCIPLINAID
				INNER JOIN
				TBSERIE AS S ON S.ID = M.SERIEID
            WHERE M.NOME = {0}NOME";

        private const string SqlVerificaDependencia =
        @"SELECT
                ENUNCIADO
            FROM
                TBQUESTAO
            WHERE MATERIAID = {0}ID_MATERIA";

        public object disciplina { get; private set; }

        #endregion QUERYS

        public Materia Adicionar(Materia novaMateria)
        {
            novaMateria.Id = Db.Insert(SqlInsereMateria, GetParametros(novaMateria));

            return novaMateria;
        }

        public Materia Editar(Materia materiaEditada)
        {
            Db.Update(SqlEditaMateria, GetParametros(materiaEditada));

            return materiaEditada;
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            Db.Delete(SqlDeletaMateria, parms);
        }

        public Materia SelecionaPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            return Db.Get(SqlSelecionaMateriaPorId, Converter, parms);
        }

        public List<Materia> SelecionaTudo()
        {
            return Db.GetAll(SqlSelecionaTodasMaterias, Converter);
        }

        public bool Existe(string nome)
        {
            var parms = new Dictionary<string, object> { { "NOME", nome } };

            var resultado = Db.Get(SqlSelecionaMateriaPorNome, Converter, parms);

            return resultado != null;
        }

        public bool RegistroComDependecia(int id)
        {
            var parms = new Dictionary<string, object> { { "ID_MATERIA", id } };

            var resultado = Db.Get(SqlVerificaDependencia, ConverterQuestao, parms);

            return resultado != null;
        }

        private Dictionary<string, object> GetParametros(Materia materia)
        {
            return new Dictionary<string, object>
            {
                { "ID", materia.Id },
                { "NOME", materia.Nome },
                { "SERIEID", materia.Serie.Id },
                { "DISCIPLINAID", materia.Disciplina.Id },
            };
        }

        private static Func<IDataReader, Materia> Converter = reader =>
          new Materia
          {
              Id = Convert.ToInt32(reader["ID"]),
              Nome = Convert.ToString(reader["NOME"]),
              Serie = new Serie
              {
                  Id = Convert.ToInt32(reader["SERIEID"]),
                  Descricao = Convert.ToString(reader["DESCRICAO"]),
              },
              Disciplina = new Disciplina
              {
                  Id = Convert.ToInt32(reader["DISCIPLINAID"]),
                  Nome = Convert.ToString(reader["DISCIPLINANOME"])
              },
          };

        private static Func<IDataReader, Questao> ConverterQuestao = reader =>
          new Questao
          {
              Enunciado = Convert.ToString(reader["ENUNCIADO"])
          };
        }
}