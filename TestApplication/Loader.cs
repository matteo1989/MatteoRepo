using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Elysium.Domain;
namespace TestApplication
{
    public class Loader
    {
        private IKernel kernel;

        public Loader()
        {
            kernel = new StandardKernel();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            //var assembliesButCurrent = assemblies.Where(a => a != Assembly.GetExecutingAssembly());

            //var asms = assembliesButCurrent.Select(s => s.GetType()).Where(w =>  typeof(NinjectModule).IsAssignableFrom(w)).Select(s => s.Assembly);
        }
    }
}
