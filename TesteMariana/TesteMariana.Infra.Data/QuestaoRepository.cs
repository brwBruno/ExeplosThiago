using System;
using System.Collections.Generic;
using System.Data;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Questoes;

namespace TesteMariana.Infra.Data
{
    public class QuestaoRepository : IQuestaoRepository
    {
        #region QUERYS

        private const string SqlInsereQuestao =
            @"INSERT INTO TBQUESTAO
                   (ENUNCIADO
                   ,MATERIAID
                   ,BIMESTRE)
             VALUES
                   ({0}ENUNCIADO
                   ,{0}MATERIAID
                   ,{0}BIMESTRE)";

        private const string SqlEditaQuestao =
            @"UPDATE TBQUESTAO
                SET
                   ENUNCIADO = {0}ENUNCIADO,
                   MATERIAID = {0}MATERIAID,
                   BIMESTRE = {0}BIMESTRE
                WHERE ID = {0}ID";

        private const string SqlExcluiQuestao =
           @"DELETE FROM TBQUESTAO
                WHERE ID = {0}ID";

        private const string SqlSelecionaTodasQuestaos =
           @"SELECT
                Q.ID,
                Q.ENUNCIADO,
                Q.MATERIAID,
                Q.BIMESTRE,
				M.NOME
            FROM
                TBQUESTAO AS Q
				INNER JOIN TBMATERIA AS M
				ON Q.MATERIAID = M.ID";

        private const string SqlSelecionaQuestaoPorId =
           @"SELECT
                Q.ID,
                Q.ENUNCIADO,
                Q.MATERIAID,
                Q.BIMESTRE,
				M.NOME
            FROM
                TBQUESTAO AS Q
				INNER JOIN TBMATERIA AS M
				ON Q.MATERIAID = M.ID
            WHERE Q.ID = {0}ID";

        private const string SqlSelecionaQuestaoPorEnunciado =
            @"SELECT
                Q.ID,
                Q.ENUNCIADO,
                Q.MATERIAID,
                Q.BIMESTRE,
				M.NOME
            FROM
                TBQUESTAO AS Q
				INNER JOIN TBMATERIA AS M
				ON Q.MATERIAID = M.ID
            WHERE Q.ENUNCIADO = {0}ENUNCIADO";

        #endregion QUERYS

        public Questao Adicionar(Questao novaQuestao)
        {
            novaQuestao.Id = Db.Insert(SqlInsereQuestao, GetParametros(novaQuestao));

            return novaQuestao;
        }

        public Questao Editar(Questao questaoEditada)
        {
            Db.Update(SqlEditaQuestao, GetParametros(questaoEditada));

            return questaoEditada;
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            Db.Delete(SqlExcluiQuestao, parms);
        }

        public Questao SelecionaPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            return Db.Get(SqlSelecionaQuestaoPorId, Converter, parms);
        }

        public List<Questao> SelecionaTudo()
        {
            return Db.GetAll(SqlSelecionaTodasQuestaos, Converter);
        }

        public bool Existe(string enunciado)
        {
            var parms = new Dictionary<string, object> { { "ENUNCIADO", enunciado } };

            var resultado = Db.Get(SqlSelecionaQuestaoPorEnunciado, Converter, parms);

            return resultado != null;
        }

        private Dictionary<string, object> GetParametros(Questao questao)
        {
            return new Dictionary<string, object>
            {
                { "ID", questao.Id },
                { "ENUNCIADO", questao.Enunciado },
                { "BIMESTRE", questao.Bimestre },
                { "MATERIAID", questao.Materia.Id },
            };
        }

        private static Func<IDataReader, Questao> Converter = reader =>
          new Questao
          {
              Id = Convert.ToInt32(reader["ID"]),
              Enunciado = Convert.ToString(reader["ENUNCIADO"]),
              Bimestre = Convert.ToInt32(reader["BIMESTRE"]),
              Materia = new Materia
              {
                  Id = Convert.ToInt32(reader["MATERIAID"]),
                  Nome = Convert.ToString(reader["NOME"])
              }
          };
    }
}