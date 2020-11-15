using ProjetoBase.NET.Layers.Repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.NET.Layers.Controllers
{
    class GeneralController
    {
        #region Atributos

        private RepoGeral Repo;

        #endregion

        #region Construtores
        public GeneralController()
        {
            Repo = new RepoGeral();
        }
        #endregion
        #region Eventos

        #endregion


        #region Funções e Procedimentos
        public DataSet fnRegioes()
        {
            try
            {
                return Repo.fnRegioes();
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
                return Repo.fnBestOfCountry(pais, valor);
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
                return Repo.fnBestOrders(top, valor);
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
                return Repo.fnOrdensCliente(IdCliente);
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
                return Repo.fnReferenciaCliente(IdCliente);
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
                 Repo.fnDeleteAllOrders(IdCliente);
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
                Repo.fnDeleteOrder(IdOrdem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        #endregion
    }
}
