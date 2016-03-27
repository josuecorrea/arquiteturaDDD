using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Ioc
{
    public class Ioc
    {
        private StandardKernel _kernel;

        public Ioc()
        {
            _kernel = new StandardKernel();
        }
    }
}
