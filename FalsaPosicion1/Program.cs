using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using org.mariuszgromada.math.mxparser;

namespace FalsaPosicion1
{

	class Program
	{

		static void Main(string[] args)
		{
			Function f = new Function("f", "x^2", "x");
			Expression e = new Expression("f(2)", f);
			mXparser.consolePrintln("Res 1: " + e.getExpressionString() + " = " + e.calculate());
			mXparser.consolePrintln("Res 2: f(5) = " + f.calculate(5));

		}
	}
}


