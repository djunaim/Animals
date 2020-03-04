// using system saying access to System code. Works similarly to import
using Animals.Reptiles;
using System;


// namespace are bigger grouping of related classes. Bundles of classes. Coincide with folder structure
namespace Animals
{
    // class is bundle of data and functionality. Can have methods on it and have pieces of information (data) attached to it. Every function in a class is a method. How programmers create projects
    class Program
    {
        // below is a function, more specifically a method
        static void Main(string[] args)
        {
            // creating instance to have access to Alligator class. This process is called instantiation - calls constructor of alligator and gets copy of class
            var americanAlligator = new Alligator(100);
            // statically defining property
            americanAlligator.IsAquatic = true;

            // different data of the same copy. Same class, different data
            var africanAlligator = new Alligator(2);
            africanAlligator.IsAquatic = false;

            // get access to method
            //alligator.Grunt();
            //africanAlligator.Grunt();
            //americanAlligator.Grunt();
            americanAlligator.Run(75);
            africanAlligator.Run(4);

            americanAlligator.Run(40);

            Console.ReadKey();
        }
    }
}
