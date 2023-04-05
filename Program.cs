using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_5_8
{
    class Program
    {
		public static int PowerUp(int N, byte pow)
		{
			if (pow == 0)
			{
				return 1;
			}
			else
			{
				if (pow == 1)
				{
					return N;
				}
				else
				{
					int result = N * PowerUp(N, --pow);					
					return result;
				}
			}
		}
		static void Main(string[] args)
		{
			int result = PowerUp(2, 3);
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
