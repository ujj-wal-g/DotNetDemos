using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
     class Covariance
    {

        class Vehicle 
        {
        }
        class car:Vehicle
        {

        }
        class Aircraft:Vehicle 
        {
        }


        static void Main(string[] args)
        {
            Vehicle v = new car();
            Vehicle v1= new car();
            Vehicle v2 = new Aircraft();
            Func<Vehicle> func = GetVehicle;
            Vehicle v3= func();
        }
        static car GetVehicle()
        {
            return new car();
        }
    }
}
