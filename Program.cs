int n, i, produto;

Console.WriteLine("--- Tabuada ---\n");

Console.Write("Digite o numero a ser multiplicado: ");
n = int.Parse(Console.ReadLine()!);

for (i = 0; i <= 10; i++){
    produto = n * i;
    Console.WriteLine($"{n} x {i} = {produto}");
}