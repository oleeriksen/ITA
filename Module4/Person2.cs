using System;
namespace Module4
{
	public class Person2
	{
        // State
        public string Name { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public DateOnly Birthday { get; set; }
        int Height { get; set; }
        double Weight { get; set; }

        //Methods
        public bool IsTeenager() { return true; }
    }
}

