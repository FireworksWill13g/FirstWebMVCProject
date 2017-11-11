using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC_FirstProject.Controllers
{



    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        // Tutorial only has string types for customer, lets see what happens 
        // when we use an int.
        public int CustomerNoOfPurc { get; set; }


        public override string ToString()
        {
            return this.CustomerName + " | " + CustomerAddress + " | " + CustomerNoOfPurc;
        }

    }

    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Hello World is old now. It's time for wassup bro ;)";
        }

        // Test - Return Object - Shows that default return is ToString() and 
        // will return the fully qualified name of the class
        // To Run this make sure to type in the url the controller Name (without the word controller)
        // and then / + the ActionName
        // Here it should look like http://localhost:62206/Test/GetCustomer 

        public Customer GetCustomer()
        {
            // instantiate new Customer Object
            Customer c = new Customer(); // this sets up the framework of the object in memory

            // now add values to the field in customer
            c.CustomerName = "Joe Schmoe";
            c.CustomerAddress = "123 Main Street";
            c.CustomerNoOfPurc = 2;
            return c;
        }

    }

    // When this code was excecuted the view showed us the fully qualified name of the class 
    // which was WebApplicationMVC_FirstProject.Controllers.Customer
    // To fix this default of ToString conversion of the object we need to Override the ToString() method.
    // in the class itself
}


