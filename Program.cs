using System;
using System.Globalization;

namespace ExercList
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=============================");
      Console.WriteLine("Quantos funcionarios deseja adicionar?");
      int numeroFuncionarios = int.Parse(Console.ReadLine());

      //maneira antiga -> List<Funcionarios> list new List<Funcionarios>()
      List<Funcionarios> list = new();

      //add a qtd de funcionarios exigida na classe funcionarios
      for (int i = 0; i < numeroFuncionarios; i++)
      {
        Console.WriteLine("Funcionario #" + i + ":");
        Console.Write("Id: ");

        int id = int.Parse(Console.ReadLine());
        Console.Write("Nome: ");

        string nome = Console.ReadLine();
        Console.Write("Salario: ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Funcionarios(id, nome, salario));
      }

      //chamar id do funcionario que deseja aumentar o salario, se o id existir, e for diferente de nulo
      Console.Write("Digite o Id do funcionário que deseja aumentar salario: ");
      int searchId = int.Parse(Console.ReadLine());

      //faz uma busca verificando se o id existe dentro da lista de funcionarios criados
      Funcionarios funcionario = list.Find(x => x.Id == searchId);

      if (funcionario != null)
      {
        Console.Write("Digite a Porcentagem que deseja aumentar: ");
        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        funcionario.AumentarSalario(porcentagem);
      }
      else
      {
        Console.WriteLine("Funcionário não existe ou ainda nao foi cadastrado.");
      }
      Console.WriteLine("=============================");
    
      Console.WriteLine("Lista atualizada de funcionarios e salários:");
      foreach (Funcionarios obj in list)
      {
        Console.WriteLine(obj);
      }


    }
  }
}