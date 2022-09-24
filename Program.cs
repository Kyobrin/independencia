Console.WriteLine("--- Vivendo de dividendos ---\n");

Console.Write("Gastos mensais (em R$)....:");

string gastosMensais = Decimal Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimentos mensais (%)...: ");
string dividendYield = Decimal Convert.ToDouble(Console.ReadLine());

string valorAInvestir = gastosMensais / Convert.ToDecimal(dividendYield 100);

Console.WriteLine($"\nPara receber {gastosMensais:C} por mês com rendimentos de {dividendYield:N1}% você precisa ter investido {valorAInvestir:C}.");