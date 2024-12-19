using WebApplicationStoreProcedure.WebApi.DatabaseConfigure;

namespace Quiz.WebApi.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly DatabaseConfiguration databaseConfiguration;
        public UserRepository(DatabaseConfiguration databaseConfiguration) 
        {
            this.databaseConfiguration = databaseConfiguration;
        }


    }
}
