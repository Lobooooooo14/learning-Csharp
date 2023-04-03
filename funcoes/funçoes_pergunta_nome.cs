using System;
					
public class Program
{
	public void Main()
	{	
		string nome = PerguntarNome();
		string sobrenome = PerguntarSobrenome();
		
		Console.WriteLine("Olá " + nome + " " + sobrenome);
	}
	
	private string PerguntarNome()
	{
		Console.WriteLine("Qual o seu nome?");
		return Console.ReadLine();
	}
	
	private string PerguntarSobrenome()
	{
		Console.WriteLine("Qual o seu sobrenome?");
		return Console.ReadLine();
	}
}
