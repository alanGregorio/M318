using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05equazione.Models
{
    internal class Points2D
    {

		private double _X;

		public double X
		{
			get { return _X; }
			set { _X = value; }
		}

		private double _Y;

		public double Y
		{
			get { return _Y; }
			set { _Y = value; }
		}

        public Points2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string? ToString()
        {
            return "["+X+","+Y+"]";
        }
    }
}
