using Prova1.Domain;
using Prova1.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prova1.Applications
{
    /// <summary>
    /// Serviço de gerenciamento de vendas.
    /// </summary>
    public class OrderService
    {
        public OrderDAO _orderDAO = new OrderDAO();

        public OrderService()
        {
        }

        /// <summary>
        /// Adiciona uma venda na base de dados.
        /// </summary>
        /// <param name="order">É o objeto para a venda que será adicionada.</param>
        public Order AddOrder(Order order)
        {
            try
            {
                order.Validate(); //Valida o venda

                order = _orderDAO.Add(order);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return order;
        }

        /// <summary>
        /// Atualiza as propriedades de uma venda. 
        /// </summary>
        /// <param name="order">É o objeto para a venda que será atualizada.</param>
        public Order UpdateOrder(Order order)
        {
            try
            {
                order.Validate(); //Valida o venda

                _orderDAO.Update(order);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return order;
        }

        /// <summary>
        /// Obtém uma venda pelo identificador "id".
        /// </summary>
        /// <param name="id">É o id que será pesquisado para buscar uma venda.</param>
        public Order GetOrder(int id)
        {
            try
            {
                return _orderDAO.GetById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Obtém todas as vendas.
        /// </summary>
        public IList<Order> GetAllOrders()
        {
            try
            {
                return _orderDAO.GetAll();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Deleta uma venda da base de dados.
        /// </summary>
        /// <param name="order">É o obejto para a venda que será removida.</param>
        public void DeleteOrder(Order order)
        {
            try
            {
                _orderDAO.Delete(order.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}