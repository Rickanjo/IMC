// Calcule o índice de massa corporal de uma pessoa, dados altura (em m) e peso (em kg).

double altura;
double peso;
double imc;

Console.WriteLine("--- Cálculo do Índice de Massa Corporal (IMC) ---\n");

Console.Write("Digite a altura (em metros): ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso (em kg): ");
peso = Convert.ToDouble(Console.ReadLine());

imc = peso / (altura * altura);

Console.WriteLine($"\nIMC: {imc:F2}");