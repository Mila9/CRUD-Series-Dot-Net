using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Series
{
    class Excecao: Validacao
    {
        //private static final long serialVersionUID = 1L;
        public Excecao(String msg) => super(msg);

        private void super(string msg)
        {
            throw new NotImplementedException();
        }

        internal string getMessage()
        {
            throw new NotImplementedException();
        }
    }


}

