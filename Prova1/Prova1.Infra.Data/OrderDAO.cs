using Prova1.Domain;
using Prova1.Infra.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Prova1.Infra.Data
{
    /// <summary>
    /// Objeto de acesso a dados de vendas.
    /// Essa classe será responsável pelo Create, Read, Update e Delete (CRUD).
    /// </summary>
    public class OrderDAO
    {
        #region Scripts SQL

        /// <summary>
        /// Scripts para manipulação das tabelas do banco de dados
        /// </summary>
        public const string _sqlInsert = @"INSERT INTO SALE
                                                       (CUSTOMER
                                                       ,QUANTITY
                                                       ,PRODUCTID)
                                                   VALUES
                                                         ({0}CUSTOMER,
                                                          {0}QUANTITY,
                                                          {0}PRODUCTID)";

        public const string _sqlSelectAll = @"SELECT  O.ID
                                                     ,O.CUSTOMER
                                                     ,O.QUANTITY
                                                     ,O.PRODUCTID
	                                                 ,P.NAME
	                                                 ,P.SALE
	                                                 ,P.EXPENSE
	                                                 ,P.ISAVAILABLE
	                                                 ,P.MANUFACTURE
	                                                 ,P.EXPIRATION
                                               FROM SALE AS O
                                               INNER JOIN PRODUCT AS P
                                               ON P.ID = O.PRODUCTID";

        public const string _sqlSelect = @"SELECT  O.ID
                                                     ,O.CUSTOMER
                                                     ,O.QUANTITY
                                                     ,O.PRODUCTID
	                                                 ,P.NAME
	                                                 ,P.SALE
	                                                 ,P.EXPENSE
	                                                 ,P.ISAVAILABLE
	                                                 ,P.MANUFACTURE
	                                                 ,P.EXPIRATION
                                               FROM SALE AS O
                                               INNER JOIN PRODUCT AS P
                                               ON P.ID = O.PRODUCTID
                                           WHERE O.ID = {0}ID";

        public const string _sqlUpdate = @"UPDATE SALE
                                                   SET CUSTOMER = {0}CUSTOMER
                                                      ,QUANTITY = {0}QUANTITY
                                                      ,PRODUCTID = {0}PRODUCTID
                                                    WHERE ID = {0}ID";

        public static string _sqlDelete = @"DELETE FROM SALE
                                                    WHERE ID = {0}ID";

        #endregion Scripts SQL

        /// <summary>
        /// Adiciona uma nova venda na base de dados.
        /// </summary>
        /// <param name="order">É a venda que será adicionada da base de dados.</param>
        /// <returns>Retorna a nova venda com os atributos atualizados (como id).</returns>
        public Order Add(Order order)
        {
            order.Id = Db.Insert(_sqlInsert, Take2(order));

            return order;
        }

        /// <summary>
        /// Método que retorna uma lista de vendas cadastradas na base de dados.
        /// </summary>
        public IList<Order> GetAll()
        {
            return Db.GetAll(_sqlSelectAll, Make);
        }

        /// <summary>
        /// Mátodo para obter uma venda específica pelo id.
        /// </summary>
        /// <param name="id">O id da venda que está sendo pesquisada.</param>
        public Order GetById(int id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "ID", id } };

            return Db.Get(_sqlSelect, Make, parms);
        }

        /// <summary>
        /// Método para atualizar uma venda na base de dados.
        /// </summary>
        /// <param name="order">O id da venda que está sendo editada.</param>
        public void Update(Order order)
        {
            Db.Update(_sqlUpdate, Take2(order));
        }

        /// <summary>
        /// Deleta uma venda pelo seu id
        /// </summary>
        /// <param name="id">É o identificador da venda que será removida da base de dados.</param>
        /// <returns>Retorna o número de linhas afetadas na base de dados.</returns>
        public void Delete(int id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "ID", id } };

            Db.Delete(_sqlDelete, parms);
        }

        /// <summary>
        /// Cria a lista de parametros do objeto order para passar para o comando Sql.
        /// </summary>
        /// <param name="product">Objeto produto passado por parâmetro.</param>
        /// <returns>Lista de parâmetros.</returns>
        private Dictionary<string, object> Take2(Order order)
        {
            return new Dictionary<string, object>
            {
                { "ID", order.Id },
                { "CUSTOMER", order.Customer },
                { "QUANTITY", order.Quantity },
                { "PRODUCTID", order.Product.Id }
            };
        }

        /// <summary>
        /// Método que cria um objeto order baseado no DataReader.
        /// </summary>
        /// <param name="reader">Interface que implementa os métodos de leitura de dados.</param>
        /// <returns>Retorna o objeto.</returns>
        private Order Make(IDataReader reader)
        {
            Order order = new Order();

            order.Id = Convert.ToInt32(reader["ID"]);
            order.Customer = Convert.ToString(reader["CUSTOMER"]);
            order.Quantity = Convert.ToInt32(reader["QUANTITY"]);
            order.Product.Id = Convert.ToInt32(reader["PRODUCTID"]);
            order.Product.Name = Convert.ToString(reader["NAME"]);
            order.Product.Sale = Convert.ToDouble(reader["SALE"]);
            order.Product.Expense = Convert.ToDouble(reader["EXPENSE"]);
            order.Product.IsAvailable = Convert.ToBoolean(reader["ISAVAILABLE"]);
            order.Product.Manufacture = Convert.ToDateTime(reader["MANUFACTURE"]);
            order.Product.Expiration = Convert.ToDateTime(reader["EXPIRATION"]);

            return order;
        }
    }
}