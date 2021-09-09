using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole_DataAccess;
using Joole_Repository;

namespace Joole_Service
{
    public class UserService : IUserService
    {
        private UserRepository userRepository = new UserRepository();

        public void GetUser(User user)
        {
            userRepository.Insert(user);
        }
    }
}
