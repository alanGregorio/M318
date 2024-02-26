using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace _05equazione.Models
{
    public class Equation
    {
		private double _a;

		public double A
		{
			get { return _a; }

			set {
				if(value == 0)
				{
					value = 1; 
				}
                
                _a = value;
                Roots();

            }
		}

		private double _b;

		public double B
		{
			get { return _b; }
			set {

                if (value == 0)
                {
                    value = 1;
                }
                
                _b = value;
				Roots();
            }

		}

		private double _c;

		public double C
		{
			get { return _c; }
			set {

				if (value == 0)
				{
					value = 1;
				}
				_c = value;
				Roots();

            }

		}


		private double _Delta;

		public double Delta
		{
			get { return _Delta; }
			set { _Delta = value; }
		}

		private double _root1;

		public double Root1
		{
			get { return _root1; }
			set { _root1 = value; }
		}

		private double _root2;

		public double Root2
		{
			get { return _root2; }
			set { _root2 = value; }
		}

        public Equation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

		
        private void Roots()
		{
			Delta = Math.Sqrt(B * B - 4 * A * C);
			Root1 = (-B - Delta) / 2 * A; 
			Root2 = (-B + Delta) / 2 * A;

        }

		public void Vertex()
		{
			Points2D vertice = new Points2D((-B/2*A), (-Delta/4*A));
			
		}

		public double Y(double x)
		{
			return 
		} 



	}
}
