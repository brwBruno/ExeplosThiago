using Prova1.Domain;
using Prova1.Infra.Data;
using Prova1.Infra.PDF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prova1.Applications
{
    /// <summary>
    /// Serviço de gerenciamento de produtos.
    /// </summary>
    public class ProductService
    {
        public ProductDAO _productDAO = new ProductDAO();
        public PDFCreator _pdfCreator;


        public ProductService()
        {
        }

        /// <summary>
        /// Adiciona um produto na base de dados.
        /// </summary>
        /// <param name="product">É o objeto para o produto que será adicionado.</param>
        public Product AddProduct(Product product)
        {
            try
            {
                product.Validate(); //Valida o produto

                product = _productDAO.Add(product);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return product;
        }


        /// <summary>
        /// Atualiza as propriedades de um produto. 
        /// </summary>
        /// <param name="product">É o obejto para o produto que será atualizado.</param>
        public Product UpdateProduct(Product product)
        {
            try
            {
                product.Validate(); //Valida o produto.

                _productDAO.Update(product);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return product;
        }
        
        /// <summary>
        /// Obtém um produto pelo identificador "id".
        /// </summary>
        /// <param name="id">É o id que será pesquisado para buscar um produto.</param>
        public Product GetProduct(int id)
        {
            try
            {
                return _productDAO.GetById(id); 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Obtém todos os produtos.
        /// </summary>
        public IList<Product> GetAllProducts()
        {
            try
            {
                return _productDAO.GetAll();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Deleta um produto da base de dados.
        /// </summary>
        /// <param name="product">É o obejto para o produto que será removido.</param>
        public void DeleteProduct(Product product)
        {
            try
            {              
                _productDAO.Delete(product.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// Lista todos os produtos, cria e abre o documento onde será escrito.
        /// Escreve os produtos listados.
        /// Fecha e gera o arquivo PDF.
        /// </summary>
        /// <param name="fileName">Caminho onde o arquivo irá ser salvo.</param>
        public void ReportList(string fileName)
        {
            try
            {

                IList<Product> productList = _productDAO.GetAll();

                _pdfCreator = new PDFCreator(fileName);

                _pdfCreator.OpenDocument();

                _pdfCreator.Write("Lista de produtos:");

                foreach (var item in productList)
                {
                    _pdfCreator.Write(item.ToString());
                }

                _pdfCreator.CloseDocument();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}