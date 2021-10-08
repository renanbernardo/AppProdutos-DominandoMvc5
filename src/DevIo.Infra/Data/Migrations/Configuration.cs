using System.Data.Entity.Migrations;

namespace DevIo.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.AppProdutosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
