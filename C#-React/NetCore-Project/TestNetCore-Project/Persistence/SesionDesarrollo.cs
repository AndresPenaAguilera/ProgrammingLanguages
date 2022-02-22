using Resolver;

namespace TestNetCore_Project
{
    public  class SesionDesarrollo :ISesion
    {
        public string ConnectionString => @"Server=GTH-93\\SQLEXPRESS; DataBase=CursosOnline;User ID=sa;Password=Sinco123;App=EntityFramework";
    }
}