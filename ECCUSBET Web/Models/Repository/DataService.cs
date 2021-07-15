using ECCUSBET_Web.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace ECCUSBET_Web.Models.Repository
{
    class DataService : IDataService
    {
        private readonly ApplicationContext context;

        public DataService(ApplicationContext context)
        {
            this.context = context;
        }

        public void InicializaDB()
        {
            context.Database.Migrate();
        }
    }
}
