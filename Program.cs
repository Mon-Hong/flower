using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Flower flower = new Flower();

            Rose rose = new Rose();
            Sunflower sunflower = new Sunflower();


        }
    }



    class Flower
    {
        public int numrose;
        public int numsunflower;
        public Flower ()
        {
            Console.Write("Input total rose : ");
            numrose = int.Parse(Console.ReadLine());
            int rose = numrose;
            Console.Write("Input total sunflower : ");
           numsunflower = int.Parse(Console.ReadLine());
        }

    }




    class Rose
    {
        public int id;
        public string name;
        public string note;
        public int number;
        public string high;
        public string girth;
        public Rose()
        {

            id = 1;
            name = "ดอกกุหลาบสีขาว";
            note = "สวยงามมาก";
            number = 2;
            high = "10.5";
            girth = "6";
            Console.WriteLine("\n\nInput Rose\n------------------------------");
            Console.WriteLine("ID : {0} \nPlant name {1} \nPlant description : {2} \nAmount : {3} \nHight {4} \nCircumference {5}" , id,name ,note,number,high,girth);
        }


    }


    class Sunflower
    {
        public int id;
        public string name;
        public string note;
        public int number;
        public string high;
        public string girth;
        public Sunflower()
        {

            id = 1;
            name = "ดอกทานตะวันเล็ก";
            note = "สวยงาม";
            number = 2;
            high = "2.0";
            girth = "2.0";

            Console.WriteLine("\n\nInput Sun flower\n------------------------------");
            Console.WriteLine("ID : {0} \nPlant name {1} \nPlant description : {2} \nAmount : {3} \nHight {4} \nCircumference {5}", id, name, note, number, high, girth);
        }


    }

}
