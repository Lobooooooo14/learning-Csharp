using System;
					
public class Program
{
	public static void Main()
	{
		string[] months = {"Janeiro", "Fevereiro", "Março", 
						   "Abril", "Maio", "Junho", 
						   "Julho", "Agosto", "Setembro", 
						   "Outubro", "Novembro", "Dezembro"};
		
		Console.WriteLine("digite o número de um mês: ");
		
		int month_number = Convert.ToInt16(Console.ReadLine());
		
		if (month_number > 0 && month_number < 13) {
			Console.WriteLine("o mês " + month_number + " é o mês " + months[month_number-1]);
		}
		else {
			Console.WriteLine("eita! parece que não existe um mês de número " + month_number + ".");
		}
	}
}