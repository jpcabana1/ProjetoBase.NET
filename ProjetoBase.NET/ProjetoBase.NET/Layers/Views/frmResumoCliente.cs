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
    public partial class frmResumoCliente : Form
    {


        #region Atributos
        private GeneralController GeralController;
        private BindingSource BindingClientes;
        private DataSet resumo;
        #endregion

        #region Construtores
        public frmResumoCliente()
        {
            try
            {
                InitializeComponent();
                GeralController = new GeneralController();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                     
        }
        #endregion


        #region Eventos
        private void frmResumoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                grdResumoCliente.AutoGenerateColumns = false;
                CarregarRegioes();
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtValorMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdResumoCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrdensCliente frmOrdensCliente;
            string Id;
            try
            {
                
                Visible = false;
                Id = resumo.Tables[0].Rows[e.RowIndex]["ID"].ToString();
                frmOrdensCliente = new frmOrdensCliente(Id);
                frmOrdensCliente.ShowDialog();
                frmOrdensCliente = null;
                Pesquisar();
                Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Visible = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string Id;
            try
            {
                Id = resumo.Tables[0].Rows[grdResumoCliente.SelectedRows[0].Index]["ID"].ToString();
                GeralController.fnDeleteAllOrders(Id);
                if (fnNaoFoiExcluido(Id))
                {
                    MessageBox.Show("Cliente é VIP e não pode ser excluído.");
                }
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Funções e Procedimentos

        private void CarregarRegioes()
        {
            try
            {
                cmbRegiao.Items.Clear();
                cmbRegiao.DataSource = GeralController.fnRegioes().Tables[0];
                cmbRegiao.DisplayMember = "Country";
                cmbRegiao.ValueMember = "Country";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool fnNaoFoiExcluido(string Id)
        {
            int count;
            try
            {
                count = GeralController.fnOrdensCliente(Id).Tables[0].Rows.Count;
                return count > 0;
            }
            catch (Exception ex)
            {
              throw ex;
            }
        }
        private void PesquisarMelhores()
        {
            string top;
            string Valor;
            try
            {
                BindingClientes = new BindingSource();
                top = "10";
                Valor = IsNumeric(txtValorMinimo.Text) ? txtValorMinimo.Text : "0";

                resumo = GeralController.fnBestOrders(top, Valor);
                BindingClientes.DataSource = resumo.Tables[0];
                BindingClientes.ResetBindings(true);

                grdResumoCliente.DataSource = BindingClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Pesquisar()
        {
            try
            {
                if (chkMelhores.Checked)
                {
                    PesquisarMelhores();
                }
                else
                {
                    PesquisarNormal();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void PesquisarNormal()
        {
            string Pais;
            string Valor;
            try
            {
                BindingClientes = new BindingSource();
                Pais = cmbRegiao.SelectedValue.ToString();
                Valor = IsNumeric(txtValorMinimo.Text) ? txtValorMinimo.Text : "0";

                resumo =  GeralController.fnBestOfCountry(Pais, Valor);
                BindingClientes.DataSource = resumo.Tables[0];
                BindingClientes.ResetBindings(true);

                grdResumoCliente.DataSource = BindingClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }



        #endregion

       
    }
}
