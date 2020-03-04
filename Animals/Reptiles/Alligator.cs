using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles 
{
    // implicitly implied as internal (only accessible within this project) if not explicitly set. If want to set it accessible to all projects anywhere, use 'public' access modifier. Classes have access modifiers.
    class Alligator
    {
        // storing data: property and field. Fields are generally private, never really see public. Fields are data stored just for me. If private not explicitly said within class, it will be implicitly private inside class. The underscore in the beginning is idiomatic
        private bool _isAquatic;
        private int _stepGoal;
        private int _stepCount;
        
        // Property structure: access modifier, type of property, property name, curly braces, with auto properties get (return data) and set (set value) inside it. Properties for exposing information so can be able to modify
        public bool IsAquatic { get; set; }

        // constructors structure: accessbility modifier and name. Name of constructor matches class name. Constructors can have parameters. Constuctors if part of class is implicitly private
        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
        }

        // Method signature structured in the following: Accessiblity modifier, method's return type, name of method, arguments in function (need to declare what type of parameter it is). If want method to return nothing, need void. "Internal" accessiblity modifier can only be called inside this project, cannot be accessed in other projects
        public void Grunt ()
        {
            if (IsAquatic)
            {
                Console.WriteLine("Bubble Bubble");
            }
            else
            {
                Console.WriteLine("GRRRR!!");
            }
        }
        public void Run(int steps)
        {
            _stepCount += steps;

            Console.WriteLine($"You ran {steps} steps.");

            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine("Congrats, you achieved your goal");
            }
        }
    }
}
