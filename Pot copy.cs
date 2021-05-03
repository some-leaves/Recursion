using System;
namespace Recursion
{
    class Pot
    {
       
        
     private int Diameter = 9;
     private int miniumDiameter = 1;
     private string measurmentSystem = "inches";
     private int step = 1;
     private int reduced = 2/3;



      

       

      

         
        public Pot()
        {
            Console.WriteLine("Steps to draw a Dogon-like pot:");
            DrawPot();
            //ShrinkPot();

        }

        public  void ReduceIt()
        {

            Diameter = Diameter / 3;


        }

        private void DrawPot()
        {
            if (Diameter <= miniumDiameter)
            {
               
                Console.WriteLine($"{step}. Draw the lid");
                return;
            }
            else
            {
                Console.WriteLine($"{step}. Draw a circle that is {Diameter} {measurmentSystem} in size");
            }
              

              ReduceIt();
              step++;
              DrawPot();

        }

       





















    }
}
