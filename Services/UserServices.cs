using Quiz.WebApi.Repository;

namespace Quiz.WebApi.Services
{
    public class UserServices:IUserServices
    {
        private readonly IUserRepository userRepository;

        public UserServices(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }


    }
}
