using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJS_Learning
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCarTypes()
        {
            List<CarType> list = new List<CarType>();
            CarType objorder1 = new CarType(1, "hatchback");
            CarType objorder2 = new CarType(2, "sedan");

            list.Add(objorder1);
            list.Add(objorder2);
            //return list;

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ContentResult PostDataResponse(string fName,string lName)
        {
            return Content("First name: " + Request.Form["fName"] +
                " | Last name: " + Request.Form["lName"]);
         }

        public JsonResult PopulateVehiclesData()
        {
            List<Vehicle> list = new List<Vehicle>();
            Vehicle v1 = new Vehicle("Car", "Toyota", "2017", "1.8", "4", "4", "N/A", "Sedan");

            Vehicle v2 = new Vehicle("Car", "Honda", "2018", "2.0", "4", "4", "N/A", "hatchback");

            Vehicle v3 = new Vehicle("Bike", "Honda", "2017", "125", "2", "1", "road", "N/A");

            Vehicle v4 = new Vehicle("Bike", "Harley Davidson", "2017", "3.0", "3", "4", "off-road", "N/A");

            

            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            //return list;

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }

    public class CarType
    {
        public int Id;
        public string Name;
        //public string ShipAddress;
        //public double Freight;
        public CarType(int id, string name)
        {
            Id = id;
            Name = name;
          //  ShipAddress = shipAddress;
            //Freight = freight;
        }
    }

  

    public class Vehicle
    {
        int Id { get; set; }
        string VehicleType { get; set; }
        string Make { get; set; }

        string Model { get; set; }

        string Engine { get; set; }

        string Wheels { get; set; }

        string Doors { get; set; }

        string BikeType { get; set; }

        string CarType { get; set; }

        public Vehicle(string vehicleType,string make, string model, string engine, string wheels,string doors, string bikeType,string carType)
        {
            VehicleType = vehicleType;
            Make = make;
            Model = model;
            Engine = engine;
            Wheels = wheels;
            Doors = doors;
            bikeType = BikeType;
            CarType = carType;
            //  ShipAddress = shipAddress;
            //Freight = freight;
        }
    }
}