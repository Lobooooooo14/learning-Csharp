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

			

			string retornoFuncao = "";

			

			switch (option) {

				case 1:

					retornoFuncao = incluirAluno();

					break;

				case 2:

					retornoFuncao = alterarAluno();

					break;

				case 3:

					retornoFuncao = excluirAluno();

					break;

				case 4:

					retornoFuncao = dadosDoAluno();

					break;

				case 5:

					retornoFuncao = sairDoSistema();

					vaiSair = true;

					break;

				default:

					Console.WriteLine("[opçao invalida]");

					break;

			}

			Console.WriteLine(retornoFuncao);

		}

	}

	

	private static string incluirAluno()

	{

		return "[aluno incluido]";

	}

	

	private static string alterarAluno()

	{

		return "[aluno alterado]";

	}

	

	private static string excluirAluno()

	{

		return "[aluno excluido]";

	}

	

	private static string dadosDoAluno()

	{

		return "[dados do aluno]";

	}

	

	private static string sairDoSistema()

	{

		return "[saindo]";

	} 

}
