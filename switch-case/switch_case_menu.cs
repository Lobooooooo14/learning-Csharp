using System;
					
public class Program
{
	public static void Main()
	{
		bool vaiSair = false;
		
		while (!vaiSair) {
			Console.WriteLine("\n************MENU************\n");
			Console.WriteLine("1 - incluir aluno");
			Console.WriteLine("2 - alterar aluno");
			Console.WriteLine("3 - excluir aluno");
			Console.WriteLine("4 - imprimir dados do aluno");
			Console.WriteLine("5 - sair\n");

			int option = Convert.ToInt16(Console.ReadLine());

			switch (option) {
				case 1:
					Console.WriteLine("[aluno incluido]");
					break;
				case 2:
					Console.WriteLine("[aluno alterado]");
					break;
				case 3:
					Console.WriteLine("[aluno excluido]");
					break;
				case 4:
					Console.WriteLine("[dados do aluno]");
					break;
				case 5:
					Console.WriteLine("saindo...");
					vaiSair = true;
					break;
				default:
					Console.WriteLine("[opçao invalida]");
					break;
			}
		}
	}
}
