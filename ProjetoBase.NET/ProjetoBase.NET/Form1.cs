using ProjetoBase.NET.Layers.DataBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBase.NET
{


    public partial class Form1 : Form
    {
        private FacBanco fac;
        private IBanco banco;

        public Form1()
        {
            InitializeComponent();
            fac = new FacBanco();
            banco = fac.CriarBanco("SQLServer");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        public void Pesquisar()
        {
            try
            {
                DataSet dt = banco.ExecutaSelect(txtQuery.Text);
                BindingSource binding = new BindingSource();
                binding.DataSource = dt.Tables[0];
                binding.ResetBindings(true);
                GridBanco.DataSource = binding;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar query \nErro:" + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }else if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.F5)
            {
                Pesquisar();
            }
        }
    }
}
