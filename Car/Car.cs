namespace Lab3
{
    public class Car
    {
        // declare the fields
        public string make;
        public string model;
        public string color;
        public int yearBuilt;

        //define the  methor
        public void Start()
        {
            System.Console.WriteLine(model + "started");
        }

        public void Stop()
        {
            System.Console.WriteLine(model + "stopped");
        }
    }
}