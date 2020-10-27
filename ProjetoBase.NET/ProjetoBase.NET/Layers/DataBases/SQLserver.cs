using ProjetoBase.NET.Layers.Config;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoBase.NET.Layers.DataBases
{
    class SQLserver : IBanco
    {
        private SqlConnection Connection;
        private SqlCommand comando;
        private SqlDataAdapter Adapter;
        public SQLserver()
        {
            Connection = new SqlConnection(Config.Config.ReadConfig());
            Connection.Open();
        }
        public void ExecutaComando(string p_comando)
        {
            try
            {
                comando = new SqlCommand(p_comando, Connection);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ExecutaSelect(string p_comando)
        {
            DataSet Retorno;
            try
            {
                Adapter = new SqlDataAdapter(p_comando, Connection);
                Retorno = new DataSet();
                Adapter.Fill(Retorno);
                return Retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
