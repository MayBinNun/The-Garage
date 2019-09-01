using System;
using System.Collections.Generic;
using Ex03.GarageLogic;
using static Ex03.GarageLogic.FuelEngine;
using static Ex03.GarageLogic.Motorcycle;

namespace Ex03.ConsoleUI
{

    // $G$ CSS-999 (-4) The Class must have an access modifier.
   
    class Program
    {
        // $G$ CSS-999 (-4) The method must have an access modifier.
        static void Main(string[] args)
        {
            GarageUI garage = new GarageUI();
            garage.GargeOpen();
        }
    }
}
