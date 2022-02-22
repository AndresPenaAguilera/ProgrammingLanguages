using EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.EntityFramework
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void xx() 
        {
            var servicios = new ServiceCollection();
            var nombreBd = Guid.NewGuid().ToString();
            //IServiceCollection servicio = servicios.AddDbContext<AppCursosContext>(option => option.UseInMemoryDatabase(databaseName: nombreBd));
            //servicio.AgregarServiciosNominaElectronica();
           // servicio.AddMemoryCache();
            //IServiceProvider serviceProvider = servicio.BuildServiceProvider();


        }
    }
}
