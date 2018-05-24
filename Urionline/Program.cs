using System;
using System.Globalization;


namespace Urionline
{
	class Program
	{
		static void Main(string[] args)
		{
			int N;
			int[,] mat;
			int M = 8;
			string resp = "S";
			N = int.Parse(Console.ReadLine());

			mat = new int[M, M];

			for (int s = 0; s < N; s++)
			{


				for (int i = 0; i < M; i++)
				{
					string[] c = Console.ReadLine().Split(' ');
					for (int j = 0; j < M; j++)
					{
						mat[i, j] = int.Parse(c[j]);
					}
				}

				int a, b;

				a = int.Parse(Console.ReadLine());
				b = int.Parse(Console.ReadLine());
				a--;
				b--;
				for (int j = 0; j < M; j++)
				{
					if (mat[a, j] == 1)
					{
						resp = "S";
						M = 0;
					}
					else if (mat[j, b] == 1)
					{
						resp = "S";
						M = 0;
					}
					else
					{
						resp = "N";
					}
				}

				Console.WriteLine(resp);
				M = 8;
			}

			Console.ReadLine();
		}

	}
}



