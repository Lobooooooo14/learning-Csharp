using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("digite sua pofisão: ");
		string profissao = Console.ReadLine();
		
		switch(profissao.ToUpper()) {
			case "ENGENHEIRO":
				Console.WriteLine("Parabéns!!!!!!!! Você se formou em engenharia");
				break;
			case "PROFESSOR":
				Console.WriteLine("Parabéns!!!!!!!! Você é um professor");
				break;
			case "MECÂNICO":
				Console.WriteLine("Parabéns!!!!!!!! Você se formou em mecânica");
				break;
			default:
				Console.WriteLine("Desculpe, não conheço esta profissão.");
				break;
		}	
	}
}