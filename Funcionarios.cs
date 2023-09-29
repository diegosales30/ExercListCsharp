using System.Globalization;

class Funcionarios
{
  public int Id {get; set;}
  public string Nome {get; set;}
  public double Salario {get; set;}

  //constructor
  public Funcionarios(int id, string nome, double salario)
  {
    Id = id;
    Nome = nome;
    Salario = salario;

  }


  /*metodo para calcular salario com ´porcentagem*/
  public void AumentarSalario(double porcentagem) 
  {
    Salario += Salario * porcentagem / 100.0;
  }

  /*reescrevendo metodo existente tostring para exibir resultado em tela*/
  public override string ToString() 
  {
    return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
  }


}