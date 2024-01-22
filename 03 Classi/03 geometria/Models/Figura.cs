using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_geometria.Models
{
	//classe astratta non puo essere istanziata e fa da modello 
	// per tutte le classi derivate 
    internal abstract class Figura
    {
		public abstract float GetPerimetro(); 


	}
}
