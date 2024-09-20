Console.WriteLine(/****************Exercicio 1******************************/);
Console.WriteLine("Digite um número");
double numa = double.Parse(Console.ReadLine());
Console.WriteLine("Digite um número");
double numb = double.Parse(Console.ReadLine());

double soma = numa + numb;
double subt = numa - numb;
double mult = numa * numb;
double div = numa / numb;

Console.WriteLine($"Os resultados são: Soma: {soma.ToString("F2")}\nSubtração: {subt.ToString("F2")}\nMultiplicação: {mult.ToString("F2")}\nDivisão: {div.ToString("F2")}");

Console.WriteLine("/****************Exercicio 2******************************/");
List<string> cantores = new List<string>();

Opcao();

void Opcao()
{
    Console.WriteLine("Digite um para adicionar um cantor");
    Console.WriteLine("Digite 2 para listar os cantores");

    int num = int.Parse(Console.ReadLine());
    switch (num)
    {
        case 1:
            RegistrarCantor();
            break;
        case 2:
            ListarCantor();
            break;
        default:
            break;
    }
}

void RegistrarCantor()
{
    Console.Clear();
    Console.WriteLine("Digite o nome do cantor:");
    string nomeCantor = Console.ReadLine();
    Console.WriteLine($"Cantor {nomeCantor} registrado com sucesso");
    cantores.Add(nomeCantor);
    Thread.Sleep(2000);
    Console.Clear();
    Opcao();
}

void ListarCantor()
{
    Console.WriteLine("Lista de cantores: ");
    foreach (string cantor in cantores)
    {
        Console.WriteLine($"Cantor: {cantor}");
    }
    Opcao();
}

/****************Exercicio 4******************************/

List<int> num= new List<int>();
num.Add(1);
num.Add(6);
num.Add(13);
num.Add(80);
int somador = 0;

foreach (int cont in num)
{
     somador += cont;
}

Console.WriteLine($"O resultado é: {somador}");