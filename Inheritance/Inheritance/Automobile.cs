using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Automobile
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public override string ToString() => $"{Year} {Make} {Model}";

        public Automobile (string make, string model, int year)
        {
            if (make == null) throw new ArgumentNullException(nameof(make), "the make cannot be null");
            else if (string.IsNullOrWhiteSpace(make)) throw new ArgumentException("make cannot empty or whitespace");
            Make = make;

            if (model == null) throw new ArgumentNullException(nameof(model), "the model cannot be null");
            else if (string.IsNullOrWhiteSpace(model)) throw new ArgumentException("Model cannot empty or whitespace");
            Model = model;

            Year = year;
        }
    }
}
