using Questao2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Questao2.Controllers
{
    public class SalesOrderController : Controller
    {
        //
        // GET: /SalesOrder/

        public ActionResult Index()
        {
            DatabaseRepository databaseRepository = new DatabaseRepository();

            List<Foo> list = (List<Foo>)databaseRepository.ListFoo();

            return View(list);
        }

        //
        // GET: /SalesOrder/Create

        public ActionResult Create()
        {
            Foo foo = new Foo();
            return View(foo);
        } 

        //
        // POST: /SalesOrder/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            
            try
            {
                Foo foo = new Foo();
                foo.Title = collection["Title"];
                foo.Description = collection["Description"];
                DatabaseRepository databaseRepository = new DatabaseRepository();
                databaseRepository.CreateSalesOrder(foo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /SalesOrder/Edit/5
 
        public ActionResult Edit(int id)
        {
            DatabaseRepository databaseRepository = new DatabaseRepository();
            
            return View(databaseRepository.FindFooById(id));
        }

        //
        // POST: /SalesOrder/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            
            try
            {
                Foo foo = new Foo();
                foo.Id = Convert.ToInt32(collection["Id"]);
                foo.Title = collection["Title"];
                foo.Description = collection["Description"];
                DatabaseRepository databaseRepository = new DatabaseRepository();
                databaseRepository.UpdateSalesOrder(foo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //
        // POST: /SalesOrder/Delete/5

        [HttpPost]
        public ActionResult Delete(int id)
        {
            
            try
            {
                DatabaseRepository databaseRepository = new DatabaseRepository();
                databaseRepository.DeleteSalesOrder(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
