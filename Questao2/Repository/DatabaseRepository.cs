using Questao2.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Questao2.Repository
{
    public class DatabaseRepository : RepositoryBase, IDatabaseRepository
    {
        public bool CreateSalesOrder(global::Foo foo)
        {
            FooEntity fooEntity = new FooEntity();
            fooEntity.Title = foo.Title;
            fooEntity.Description = foo.Description;
            dDatabaseFooEntities.FooEntity.Add(fooEntity);
            dDatabaseFooEntities.SaveChanges();
            return true;
        }

        public bool UpdateSalesOrder(global::Foo foo)
        {
            FooEntity fooEntity = dDatabaseFooEntities.FooEntity.FirstOrDefault(x => x.Id == foo.Id);
            fooEntity.Description = foo.Description;
            dDatabaseFooEntities.SaveChanges();

            return true;
        }

        public bool DeleteSalesOrder(int id)
        {
            FooEntity fooEntity = dDatabaseFooEntities.FooEntity.FirstOrDefault(x => x.Id == id);
            dDatabaseFooEntities.FooEntity.Remove(fooEntity);

            return true;
        }

        public IEnumerable<Foo> ListFoo()
        {
            List<Foo> listFoo = new List<Foo>();
            foreach (FooEntity fooEntity in dDatabaseFooEntities.FooEntity.ToList())
            {
                Foo foo = new Foo();
                foo.Id = fooEntity.Id;
                foo.Title = fooEntity.Title;
                foo.Description = fooEntity.Description;
                listFoo.Add(foo);
            }
            return listFoo;
        }

        public Foo FindFooById(int id)
        {
            FooEntity fooEntity = dDatabaseFooEntities.FooEntity.FirstOrDefault(x => x.Id == id);
            Foo foo = new Foo();
            foo.Id = fooEntity.Id;
            foo.Title = fooEntity.Title;
            foo.Description = fooEntity.Description;
            return foo;
        }
    }
}