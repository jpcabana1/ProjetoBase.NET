using ProjetoBase.NET.Layers.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBase.NET.Layers.Views
{
    public partial class frmOrdensCliente : Form
    {

        #region Atributos
        private BindingSource bidingSource;
        private GeneralController General;
        private DataSet Ordens;
        private DataSet Cliente;
        private string IdCliente;
        #endregion

        #region Construtores
        public frmOrdensCliente(string idCliente)
        {
            InitializeComponent();
            General = new GeneralController();
            IdCliente = idCliente;
        }
        #endregion


        #region Eventos
        private void frmOrdensCliente_Load(object sender, EventArgs e)
        {
            try
            {
                grdOrders.AutoGenerateColumns = false;
                Cliente = General.fnReferenciaCliente(IdCliente);
                lblCliente.Text = "Nome: " + Cliente.Tables[0].Rows[0]["ContactName"].ToString();
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex > 2)
                {
                    Excluir(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region Funções e Procedimentos
        private void Pesquisar()
        {
            try
            {
                bidingSource = new BindingSource();
                Ordens = General.fnOrdensCliente(IdCliente);
                bidingSource.DataSource = Ordens.Tables[0];
                bidingSource.ResetBindings(true);

                grdOrders.DataSource = bidingSource;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void Excluir(int index)
        {
            string Id;
            try
            {
                Id = Ordens.Tables[0].Rows[index]["OrderID"].ToString();
                General.fnDeleteOrder(Id);
                Pesquisar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        #endregion

       
    }
}
