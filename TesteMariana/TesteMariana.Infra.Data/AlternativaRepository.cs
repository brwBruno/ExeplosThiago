using System;
using System.Collections.Generic;
using System.Data;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Alternativas;

namespace TesteMariana.Infra.Data
{
    public class AlternativaRepository : IAlternativaRepository
    {
        #region QUERYS

        private const string SqlInsereAlternativa =
            @"INSERT INTO TBALTERNATIVA
                (LETRA, RESPOSTA, CORRETA, QUESTAOID)
            VALUES
                ({0}LETRA,{0}RESPOSTA,{0}CORRETA, {0}QUESTAOID)";

        private const string SqlEditaAlternativa =
            @"UPDATE TBALTERNATIVA
                SET
                    LETRA = {0}LETRA,
                    RESPOSTA = {0}RESPOSTA,
                    CORRETA = {0}CORRETA,
                    QUESTAOID = {0}QUESTAOID
                WHERE ID = {0}ID";

        private const string SqlExcluiAlternativa =
           @"DELETE FROM TBALTERNATIVA
                WHERE ID = {0}ID";

        private const string SqlSelecionaTodasAlternativas =
           @"SELECT
                ID,
                LETRA,
                RESPOSTA,
                CORRETA,
                QUESTAOID
            FROM
                TBALTERNATIVA";

        private const string SqlSelecionaAlternativaPorId =
           @"SELECT
                ID,
                LETRA,
                RESPOSTA,
                CORRETA,
                QUESTAOID
            FROM
                TBALTERNATIVA
            WHERE ID = {0}ID";

        #endregion QUERYS

        public Alternativa Adicionar(Alternativa novaAlternativa)
        {
            novaAlternativa.Id = Db.Insert(SqlInsereAlternativa, GetParametros(novaAlternativa));

            return novaAlternativa;
        }

        public Alternativa Editar(Alternativa alternativaEditada)
        {
            Db.Update(SqlEditaAlternativa, GetParametros(alternativaEditada));

            return alternativaEditada;
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            Db.Delete(SqlExcluiAlternativa, parms);
        }

        public Alternativa SelecionaPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            return Db.Get(SqlSelecionaAlternativaPorId, Converter, parms);
        }

        public List<Alternativa> SelecionaTudo()
        {
            return Db.GetAll(SqlSelecionaTodasAlternativas, Converter);
        }

        private Dictionary<string, object> GetParametros(Alternativa alternativa)
        {
            return new Dictionary<string, object>
            {
                { "ID", alternativa.Id },
                { "LETRA", alternativa.Letra },
                { "RESPOSTA", alternativa.Resposta },
                { "CORRETA", alternativa.Correta },
                { "QUESTAOID", alternativa.Questao.Id }
            };
        }

        public bool Existe(string resposta)
        {
            throw new NotImplementedException();
        }

        private static Func<IDataReader, Alternativa> Converter = reader =>
          new Alternativa
          {
              Id = Convert.ToInt32(reader["ID"]),
              Letra = Convert.ToChar(reader["LETRA"]),
              Resposta = Convert.ToString(reader["RESPOSTA"]),
              Correta = Convert.ToBoolean(reader["CORRETA"]),
              Questao = new Questao { Id = Convert.ToInt32(reader["QUESTAOID"]) }
          };
    }
}