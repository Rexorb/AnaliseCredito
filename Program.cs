Console.WriteLine("Olá, deseja solicitar o empréstimo ? Digite o valor em R$");
double valorEmprestimo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Certo, agora entre com o número de parcelas desejadas");
int parcelas = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Certo, agora entre com a sua renda mensal em R$");
double rendaMensal = Convert.ToDouble(Console.ReadLine());

double calculoRenda = (rendaMensal) * 0.30;
double calculoParcela = valorEmprestimo / parcelas;

if (calculoParcela < calculoRenda)
{
    Console.WriteLine("Empréstimo autorizado");
}
else
{
    Console.WriteLine("Empréstimo não autorizado");
}



