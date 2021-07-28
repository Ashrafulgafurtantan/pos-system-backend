using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pos_system.Model;

namespace pos_system.Repository
{
    public class DatabaseRepository
    {
        protected DatabaseContext DatabaseContext = new DatabaseContext();
    }
}
