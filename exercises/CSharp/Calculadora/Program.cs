using Calculadora.model;

Calculator CalculatorInstance = new Calculator();

Console.WriteLine("Digite a operação: +, -, x, / ou ^");

var operation = Convert.ToString(Console.ReadLine());
if (operation == null) { Environment.Exit(0); }

Console.WriteLine("digite o primeiro valor");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite o segundo valor");
int secondValue = Convert.ToInt32(Console.ReadLine());

int result = 0;
switch (operation)
{
  case "+":
    result = CalculatorInstance.Sum(firstValue, secondValue);
    break;
  case "-":
    result = CalculatorInstance.Subtract(firstValue, secondValue);
    break;
  case "x":
    result = CalculatorInstance.Multiply(firstValue, secondValue);
    break;
  case "/":
    result = CalculatorInstance.Multiply(firstValue, secondValue);
    break;
  case "^":
    result = CalculatorInstance.Power(firstValue, secondValue);
    break;
  default:
    Console.WriteLine("operação invalida, digite um operador válido ( +,-,x,/ ou ^ )");
    Environment.Exit(0);
    break;
}

Console.WriteLine($"result = {result}");