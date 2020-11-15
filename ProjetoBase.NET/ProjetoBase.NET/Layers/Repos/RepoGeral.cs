using ProjetoBase.NET.Layers.DataBases;
using ProjetoBase.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.NET.Layers.Repos
{
    class RepoGeral
    {

        #region Atributos
        private ConfigModel config;
        private FacBanco FactoryRepo;
        private IBanco Data;
        private string comando;
        #endregion

        #region Construtores
        public RepoGeral()
        {
            config = Config.Config.ReadConfigObject();
            FactoryRepo = new FacBanco();
            Data = FactoryRepo.CriarBanco(config.TipoBanco);
        }
        #endregion

        #region Eventos

        #endregion


        #region Funções e Procedimentos
        public DataSet fnRegioes()
        {
           
            try
            {
                comando = "select distinct Country from Customers";
                return Data.ExecutaSelect(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet fnBestOfCountry(string pais, string valor)
        {
            try
            {
                comando = "EXEC BestOfCountry '"+ pais +"', "+ valor +"";
                return Data.ExecutaSelect(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet fnBestOrders(string top, string valor)
        {
            try
            {
                comando = "EXEC BestOrders " + top + ", " + valor + "";
                return Data.ExecutaSelect(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet fnOrdensCliente(string IdCliente)
        {
            try
            {
                comando = "select * from orders where CustomerID = '"+ IdCliente +"'";
                return Data.ExecutaSelect(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet fnReferenciaCliente(string IdCliente)
        {
            try
            {
                comando = "select * from Customers where CustomerID = '"+ IdCliente +"'";
                return Data.ExecutaSelect(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fnDeleteAllOrders(string IdCliente)
        {
            try
            {
                comando = "DELETE from Customers where CustomerID = '"+ IdCliente + "'";
                Data.ExecutaComando(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fnDeleteOrder(string IdOrdem)
        {
            try
            {
                comando = "DELETE Orders WHERE Orders.OrderID = "+ IdOrdem +"";
                Data.ExecutaComando(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
