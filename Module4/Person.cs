using System;
namespace Module4
{
	public class Person
	{
		// State
		public string name = String.Empty;
		public string address = String.Empty;
		public DateOnly birthday;
		int height;
		double weight;

		public Person() { }

		public Person(string name, string address, int height, double weight) {
			this.name = name;
			this.address = address;
			this.height = height;
			this.weight = weight;
		}

		//Methods
		public bool IsTeenager() { return true;  }

		public double BMI() { return 0; }

		public int DistanceFrom(double lat, double lgd) { return 0; }
	}
}

