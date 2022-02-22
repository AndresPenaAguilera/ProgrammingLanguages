using Microsoft.EntityFrameworkCore;
using Resolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNetCore_Project
{
    public class ConstructorConexionTest : IConstructorConexion
    {
        public void Configurar(IServiceProvider serviceProvider, DbContextOptionsBuilder opciones)
        {
            opciones.UseInMemoryDatabase(databaseName: "InMemory");
        }
    }
}
