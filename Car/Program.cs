using System;

namespace Lab3
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Car mycar;
      System.Console.WriteLine("Creating Car object and assigning" + "Its memory location to myCar");
      mycar = new Car();
            
      //assign values
      mycar.make = "Toyota";
      mycar.model = "MR2";
      mycar.color = "Black";
      mycar.yearBuilt = 1995;
            
      //display values
      System.Console.WriteLine("myCar details:");
      System.Console.WriteLine("myCar.make = " + mycar.make);
      System.Console.WriteLine("myCar.model = " + mycar.model);
      System.Console.WriteLine("myCar.color = " + mycar.color);
      System.Console.WriteLine("myCar.yearBuilt = " + mycar.yearBuilt);
            
            
      //call the method
      mycar.Start();
      mycar.Stop();
            
      //create another car
      System.Console.WriteLine("Creating another Car object and" + " assigning its memory location to redPorsChe");
      Car redPorsChe = new Car();
      redPorsChe.make = "Porsche";
      redPorsChe.model = "Boxster";
      redPorsChe.color = "Red";
      redPorsChe.yearBuilt = 2000;
            
      System.Console.WriteLine("redPorsChe is a " + redPorsChe.model);
            
      System.Console.WriteLine("Assigning redPorsChe to myCar");
      mycar = redPorsChe;
      System.Console.WriteLine("myCar details :");
      System.Console.WriteLine("myCar.make = " + mycar.make);
      System.Console.WriteLine("myCar.model = " + mycar.model);
      System.Console.WriteLine("myCar.color = " + mycar.color);
      System.Console.WriteLine("myCar.yearBuilt = " + mycar.yearBuilt);
      mycar = null;
      Console.ReadLine();
    }
  }
}