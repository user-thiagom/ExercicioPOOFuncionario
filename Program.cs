// See https://aka.ms/new-console-template for more information

using ExercicioPOOFuncionario;

Funcionario funcionario = new Funcionario();

Console.WriteLine("Nome: ");
funcionario.Nome = Console.ReadLine();

Console.WriteLine("Salario Bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine());

Console.WriteLine("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine($"Funcionario: {funcionario.Nome}, $ {funcionario.SalarioLiquido()}");

Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

Console.WriteLine($"Dados atualizados: {funcionario.Nome}, $ {funcionario.SalarioLiquido()}");
