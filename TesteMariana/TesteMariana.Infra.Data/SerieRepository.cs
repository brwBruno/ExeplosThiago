using System;
using System.Collections.Generic;
using System.Data;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Series;

namespace TesteMariana.Infra.Data
{
    public class SerieRepository : ISerieRepository
    {
        #region QUERYS

        private const string SqlInsereSerie =
            @"INSERT INTO TBSERIE
                (DESCRICAO)
            VALUES
                ({0}DESCRICAO)";

        private const string SqlEditaSerie =
            @"UPDATE TBSERIE
                SET
                    DESCRICAO = {0}DESCRICAO

                WHERE ID = {0}ID";

        private const string SqlExcluiSerie =
           @"DELETE FROM TBSERIE
                WHERE ID = {0}ID";

        private const string SqlSelecionaTodasSeries =
           @"SELECT
                ID,
                DESCRICAO
            FROM
                TBSERIE ORDER BY DESCRICAO";

        private const string SqlSelecionaSeriePorId =
           @"SELECT
                ID,
                DESCRICAO
            FROM
                TBSERIE
            WHERE ID = {0}ID ORDER BY DESCRICAO";

        private const string SqlSelecionaSeriePorNome =
         @"SELECT
                ID,
                DESCRICAO
            FROM
                TBSERIE
            WHERE DESCRICAO = {0}DESCRICAO ORDER BY DESCRICAO";

        private const string SqlVerificaDependencia =
         @"SELECT
                NOME
            FROM
                TBMATERIA
            WHERE SERIEID = {0}ID_SERIE";

        #endregion QUERYS

        public Serie Adicionar(Serie novaSerie)
        {
            novaSerie.Id = Db.Insert(SqlInsereSerie, GetParametros(novaSerie));

            return novaSerie;
        }

        public Serie Editar(Serie serieEditada)
        {
            Db.Update(SqlEditaSerie, GetParametros(serieEditada));

            return serieEditada;
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            Db.Delete(SqlExcluiSerie, parms);
        }

        public Serie SelecionaPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            return Db.Get(SqlSelecionaSeriePorId, ConverterSerie, parms);
        }

        public List<Serie> SelecionaTudo()
        {
            return Db.GetAll(SqlSelecionaTodasSeries, ConverterSerie);
        }

        public bool Existe(string descricao)
        {
            var parms = new Dictionary<string, object> { { "DESCRICAO", descricao } };

            var resultado = Db.Get(SqlSelecionaSeriePorNome, ConverterSerie, parms);

            return resultado != null;
        }


        public bool RegistroComDependecia(int id)
        {
            var parms = new Dictionary<string, object> { { "ID_SERIE", id } };

            var resultado = Db.Get(SqlVerificaDependencia, ConverterMateria, parms);

            return resultado != null;
        }

        private Dictionary<string, object> GetParametros(Serie serie)
        {
            return new Dictionary<string, object>
            {
                { "ID", serie.Id },
                { "DESCRICAO", serie.Descricao },
            };
        }

        private static Func<IDataReader, Serie> ConverterSerie = reader =>
          new Serie
          {
              Id = Convert.ToInt32(reader["ID"]),
              Descricao = Convert.ToString(reader["DESCRICAO"])
          };

        private static Func<IDataReader, Materia> ConverterMateria = reader =>
        new Materia
        {
            Nome = Convert.ToString(reader["NOME"])
        };
    }
}