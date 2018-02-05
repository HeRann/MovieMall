using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using moviemall.Models;
using System.Data.Entity;
using moviemall.ViewModel;


namespace moviemall.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var customerInIndex = _context.Customers.Include(x => x.MembershipType).ToList();
            return View(customerInIndex);
        }

        //private IEnumerable<Customer> getCustomer()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer
        //        {
        //            Id=3,
        //            Name ="John Smith"
        //        },
        //        new Customer
        //        {
        //            Id=2,
        //            Name = "Mary Williams"
        //        },
        //        new Customer
        //        {
        //            Id =1,
        //            Name ="Williams Smith"
        //        }
        //    };
        //}

        public ActionResult Details(int ID)
        {
            var customerInDetails = _context.Customers.Include(x => x.MembershipType).SingleOrDefault(c => c.Id == ID);


            if (customerInDetails != null)
            {
                return View(customerInDetails);
            }
            else
            {
                return HttpNotFound();
            }
            
        }

        public ActionResult New()
        {
            var customerInNew = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel();
            viewModel.MembershipTypes = customerInNew;
            viewModel.Customer = new Customer();
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel();
                viewModel.Customer =customer;
                viewModel.MembershipTypes = _context.MembershipTypes.ToList();

                return View("CustomerForm", viewModel);
            }
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index","Customers");
        }

        public ActionResult Edit(int Id)
        {
             var customerInEdit = _context.Customers.SingleOrDefault(c => c.Id == Id);
            //if (customerInEdit != null)
            //{
            var viewModel = new NewCustomerViewModel();
                viewModel.Customer = customerInEdit;
                viewModel.MembershipTypes = _context.MembershipTypes.ToList();                 

                return View("CustomerForm",viewModel);
            //}
            //else
            //{
            //    return HttpNotFound();
            //}
        }
    }

    //{
    //    public ActionResult Index()
    //{
    //    List<Customer> customerInIndex = new List<Customer>
    //        {
    //            new Customer {Id = 1, Name = "John Smith" },
    //            new Customer {Id = 2, Name = "Mary Williams" }
    //        };

    //        TempData["value"] = customerInIndex;
    //    return View(customerInIndex);
    //}

    //public ActionResult Details(int id)
    //{
    //        //var customerInDetails = new List<Customer>().Single(x => x.Id == id);
    //        //var customerInDetails = new List<Customer>().Where(x => x.Id == id).FirstOrDefault();
    //        var customerInDetails = (List<customer>())TempData["value"].Where(x => x.Id == id).FirstOrDefault();
    //        return View(customerInDetails);
    //}


}