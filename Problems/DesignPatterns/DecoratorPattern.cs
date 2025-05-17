using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace DesignPatterns
{
    class DecoratorPattern : AbsProblem, IProblem
    {
        /*
		 * Decorator Pattern
		 * 
		 * Attaches (wraps) additional features to an object dynamically. 
		 * Decorators provide a flexible alternative to subclassing 
		 * for extending functionality. 
		 * 
		 * This allows for code to be extended without needing to 
		 * modify existing code
		 * 
		 * Composition and delegation will allow code to add 
		 * new functionality at runtime.
		 * 
		 * Downfall of this pattern is that it can lead to much complex 
		 * code because it will add many small objects 
		 */


        public DecoratorPattern() : base("Decorator Pattern")
        {

        }

        public override void Begin()
        {
            Beverage beverage = new Espresso();
            DisplayMessage($"Beverage: {beverage.getDescription()}, Cost: ${beverage.cost()}");

            Beverage beverage1 = new DarkRoast();
            DisplayMessage($"{beverage1.getDescription()}");
            //Pass in beverage1 object to extend the object
            beverage1 = new Mocha(beverage1);
            DisplayMessage($"{beverage1.getDescription()}");

            beverage1 = new Mocha(beverage1);
            DisplayMessage($"{beverage1.getDescription()}");

            beverage1 = new Whip(beverage1);

            DisplayMessage($"Final Beverage: {beverage1.getDescription()}, Cost: ${beverage1.cost()}");
        }
    }

    /// <summary>
    /// Beverage is the abstract class that will
    /// be used to define concrete class
    /// </summary>
    public abstract class Beverage
    {
        public string description = "Unknown beverage";
        public abstract double cost();

        public virtual string getDescription()
        {
            return description;
        }
    }

    /// <summary>
    /// Abstract class that will inherit Beverage class. 
    /// This will become the base class for condiments
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        //Composition of Beverage
        public Beverage beverage;

        public override string getDescription()
        {
            if (beverage != null)
            {
                return beverage.getDescription();
            }

            return "Beverage is null";
        }
    }

    /// <summary>
    /// Concrete Beverages that will be used as a base drink
    /// Any class that inherits from Beverage will be considered
    /// as a base drink that can be extended to make a new drink
    /// </summary>
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double cost()
        {
            return .89;
        }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }

    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    /// <summary>
    /// Concrete Decorator 
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        //By passing in a beverage object, will allow to
        //build upon the object. You are basically encapulating the
        //object and extending it. 
        public Mocha(Beverage beverageold)
        {
            beverage = beverageold;
            description = beverage.description + ", Mocha";
        }

        public override double cost()
        {
            return beverage.cost() + .20;
        }

        public override string getDescription()
        {
            return description;
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverageold)
        {
            beverage = beverageold;
            description = beverage.description + ", Whip";
        }

        public override double cost()
        {
            return beverage.cost() + .99;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
