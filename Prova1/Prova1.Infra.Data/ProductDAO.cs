using Prova1.Domain;
using Prova1.Infra.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Prova1.Infra.Data
{
    /// <summary>
    /// Objeto de acesso a dados de produtos
    /// Essa classe será responsável pelo Create, Read, Update e Delete (CRUD).
    /// </summary>
    /// <summary>
    /// Objeto de acesso a dados de produtos
    /// Essa classe será responsável pelo Create, Read, Edit e Delete (CRUD)
    /// </summary>
    public class ProductDAO
    {
        #region Scripts SQL

        /// <summary>
        /// Scripts para manipulação das tabelas do banco de dados
        /// </summary>
        public const string _sqlInsert = @"INSERT INTO PRODUCT
                                                       (NAME,
                                                        SALE,
                                                        EXPENSE,
                                                        ISAVAILABLE,
                                                        MANUFACTURE,
                                                        EXPIRATION)
                                                  VALUES
                                                        ({0}NAME,
                                                        {0}SALE,
                                                        {0}EXPENSE,
                                                        {0}ISAVAILABLE,
                                                        {0}MANUFACTURE,
                                                        {0}EXPIRATION)";

        public const string _sqlSelectAll = @"SELECT ID
                                                    ,NAME
                                                    ,SALE
                                                    ,EXPENSE
                                                    ,ISAVAILABLE
                                                    ,MANUFACTURE
                                                    ,EXPIRATION
                                                 FROM PRODUCT";

        public const string _sqlSelect = @"SELECT ID
                                                 ,NAME
                                                 ,SALE
                                                 ,EXPENSE
                                                 ,ISAVAILABLE
                                                 ,MANUFACTURE
                                                 ,EXPIRATION
                                                 FROM PRODUCT
                                            WHERE ID = {0}ID";

        public const string _sqlUpdate = @"UPDATE PRODUCT
                                                        SET NAME = {0}NAME
                                                           ,SALE = {0}SALE
                                                           ,EXPENSE = {0}EXPENSE
                                                           ,ISAVAILABLE = {0}ISAVAILABLE
                                                           ,MANUFACTURE = {0}MANUFACTURE
                                                           ,EXPIRATION = {0}EXPIRATION
                                             WHERE ID = {0}ID";

        public static string _sqlDelete = @"DELETE FROM PRODUCT
                                             WHERE ID = {0}ID";

        #endregion Scripts SQL

        /// <summary>
        /// Adiciona um novo product na base de dados
        /// </summary>
        /// <param name="product">É o product que será adicionado da base de dados</param>
        /// <returns>Retorna o novo product com os atributos atualizados (como id)</returns>
        public Product Add(Product product)
        {
            product.Id = Db.Insert(_sqlInsert, Take(product));

            return product;
        }

        /// <summary>
        /// Método que retorna uma lista de products cadastrados na base de dados
        /// </summary>
        public IList<Product> GetAll()
        {
            return Db.GetAll(_sqlSelectAll, Make);
        }

        /// <summary>
        /// Mátodo para obter um product específico pelo id
        /// </summary>
        /// <param name="id">O id do product que está sendo pesquisado</param>
        public Product GetById(int id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "ID", id } };

            return Db.Get(_sqlSelect, Make, parms);
        }

        /// <summary>
        /// Método para atualizar um product na base de dados
        /// </summary>
        /// <param name="productId">O id do product que está sendo editado</param>
        public void Update(Product product)
        {
            Db.Update(_sqlUpdate, Take(product));
        }

        /// <summary>
        /// Altera a propriedade isRemoved para true.
        /// </summary>
        /// <param name="product">É o product que será removido da base de dados</param>
        /// <returns>Retorna o número de linhas afetadas na base de dados</returns>
        public void Delete(int id)
        {
            var parms = new Dictionary<string, object> { { "ID", id } };

            Db.Delete(_sqlDelete, parms);
        }

        /// <summary>
        /// Cria a lista de parametros do objeto product para passar para o comando Sql.
        /// </summary>
        /// <param name="product">Objeto produto passado por parâmetro.</param>
        /// <returns>Lista de parâmetros.</returns>
        private Dictionary<string, object> Take(Product product)
        {
            return new Dictionary<string, object>
            {
                { "ID", product.Id },
                { "NAME", product.Name },
                { "SALE", product.Sale },
                { "EXPENSE", product.Expense },
                { "MANUFACTURE", product.Manufacture },
                { "EXPIRATION", product.Expiration },
                { "ISAVAILABLE", product.IsAvailable }
            };
        }

        private static Func<IDataReader, Product> Make = reader =>
          new Product
          {
              Id = Convert.ToInt32(reader["ID"]),
              Name = Convert.ToString(reader["NAME"]),
              Sale = Convert.ToDouble(reader["SALE"]),
              Expense = Convert.ToDouble(reader["EXPENSE"]),
              IsAvailable = Convert.ToBoolean(reader["ISAVAILABLE"]),
              Manufacture = Convert.ToDateTime(reader["MANUFACTURE"]),
              Expiration = Convert.ToDateTime(reader["EXPIRATION"])
          };
    }
}