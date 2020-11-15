using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.NET.Models
{
    class ConfigModel
    {
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string RodarLocal { get; set; }
        public string TipoBanco { get; set; }
        public override string ToString()
        {
            if (RodarLocal == "n")
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("Data Source = '" + DataSource + "';");
                stringBuilder.Append("Initial Catalog = '" + InitialCatalog + "';");
                stringBuilder.Append("User = '" + User + "';");
                stringBuilder.Append("Password = '" + Password + "';");
                return stringBuilder.ToString();
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("Data Source = '" + DataSource + "';");
                stringBuilder.Append("Database = '" + InitialCatalog + "';");
                stringBuilder.Append("Trusted_Connection='True';"); 
                return stringBuilder.ToString();
            }
          
        }
    }
}
