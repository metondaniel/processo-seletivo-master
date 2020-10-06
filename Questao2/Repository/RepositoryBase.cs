using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Questao2.Repository
{
    public class RepositoryBase
    {
        protected DatabaseFooEntities dDatabaseFooEntities { get; set; }

        public RepositoryBase()
        {
            dDatabaseFooEntities = new DatabaseFooEntities();
        }
    }
}