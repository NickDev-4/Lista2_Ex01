Console.Clear();

string nome, sobrenome;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine();

Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Nome Completo: {0} {1}", nome, sobrenome);
Console.WriteLine($"Nome de Catálogo: {sobrenome.ToUpper()}, {nome.ToLower()}");

