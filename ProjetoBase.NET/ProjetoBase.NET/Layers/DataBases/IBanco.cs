using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.NET.Layers.DataBases
{
    interface IBanco
    {
        void ExecutaComando(string comando);
        DataSet ExecutaSelect(string comando);
    }
}
