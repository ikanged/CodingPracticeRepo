using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace DesignPatterns
{
	class DesignPatternIntro : AbsProblem, IProblem
	{
		public DesignPatternIntro() : base("Intro")
		{

		}

		public override void Begin()
		{
			MallardDuck mallardDuck = new MallardDuck();

			mallardDuck.performFly();
			mallardDuck.performQuack();

			Duck model = new ModelDuck();
			model.performFly();
			//Replace default constuctor behavior of fly with FlyWithRocket
			model.setFlyBehavior(new FlyWithRocket());
			model.performQuack();
		}
	}

	/*
	 * DESCRIPTION: 
	 * There are many cases where common methods and properties are to be shared 
	 * amongst different child objects. To decouple and maintain reuseable code (polymorphism)
	 * Objects which implements common methods but with varying implementation are used.
	 * 
	 * */

	public abstract class Duck
	{
		//Composition of varying methods. 
		public IQuackBehavior quackBehavior;
		public IFlyBehavior flyBehavior;

		public void performQuack()
		{
			quackBehavior.quack();
		}

		public void performFly()
		{
			flyBehavior.Fly();
		}

		//Each child class of duck will have to implement its own display method		
		public abstract void display();

		public void swim()
		{
			Console.WriteLine("Default Swimming that all ducks can do");
		}

		//To make the this class flexible, set methods can be used to set it's behavior for 
		//different objects
		public void setFlyBehavior( IFlyBehavior fb)
		{
			flyBehavior = fb;
		}

		public void setQuackBehavior(IQuackBehavior qb)
		{
			quackBehavior = qb;
		}
	}

	/// <summary>
	/// Class that will implement common methods for ALL ducks that are inherited. 
	/// All ducks can quack but in a different way but also not all ducks will quack. 
	/// This class will be used to define ducks that quacks.
	/// </summary>	
	public interface IQuackBehavior
	{
		void quack();
	}

	public class Quack : IQuackBehavior
	{
		public void quack()
		{
			Console.WriteLine("Default Quack!");
		}
	}

	public class Squeak : IQuackBehavior
	{
		public void quack()
		{
			Console.WriteLine("Default Squeak");
		}
	}

	/// <summary>
	/// Same for FlyBehavior Class. Most ducks are able to fly but some ducks are 
	/// not able to fly. Ducks that implement FlyBehavior will be able to use 
	/// the Fly method
	/// </summary>
	public interface IFlyBehavior
	{
		void Fly();
	}

	public class FlyWithWings : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("Default Flying With Wings!");
		}
	}

	public class NoFlyBehavior : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("Default Cannot Fly");
		}
	}

	public class MallardDuck : Duck
	{
		//Constructor for this child class of Duck will set the 
		// object for implementation for varing methods
		//The caviot for doing this is that it is not flexible. 
		// At runtime, there is no way for this object to change its behavior.
		public MallardDuck()
		{
			quackBehavior = new Quack();
			flyBehavior = new FlyWithWings();
		}

		public override void display()
		{
			Console.WriteLine("Displaying MallardDuck");
		}
	}

	public class ModelDuck : Duck
	{
		public ModelDuck()
		{
			flyBehavior = new NoFlyBehavior();
			quackBehavior = new Quack();
		}

		public override void display()
		{
			Console.WriteLine("Displaying for ModelDuck");
		}
	}

	//Introducing behavior that ModelDuck can inherit 
	public class FlyWithRocket : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("Flying With Rocket");
		}
	}

}
