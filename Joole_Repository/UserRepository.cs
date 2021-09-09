using Joole_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository()
        {
            entities = db.Set<User>();
        }
    }
}
