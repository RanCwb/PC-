
double precoOriginal;
double porcentagemDesconto;
double valorDesconto;
double precoComDesconto;

Console.WriteLine("Insira o preço original do produto:");
precoOriginal = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a porcentagem de desconto:");
porcentagemDesconto = double.Parse(Console.ReadLine()) / 100;

valorDesconto = precoOriginal * porcentagemDesconto;
precoComDesconto = precoOriginal - valorDesconto;

Console.WriteLine("Preço original: " + precoOriginal);
Console.WriteLine("Desconto: " + porcentagemDesconto * 100 + "%");
Console.WriteLine("Valor do desconto: " + valorDesconto);
Console.WriteLine("Preço com desconto: " + precoComDesconto);
