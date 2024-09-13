List<int> numeros = [];
List<string> nomes = ["Miguel", "Allana"];
for (int i = 1; i <= 10; i++)
{
    numeros.Add(i);
    numeros.Remove(3);
}
//nomes.Clear();
foreach (int i in numeros)
{
    //Console.WriteLine(i);
}
foreach (string nome in nomes)
{
    //Console.WriteLine(nome);
}

//Console.WriteLine(nomes[0]);

//-----------------------------

var estados = new Dictionary<int, string>
{
    { 1, "RJ" },
    { 2, "SP" }
};
foreach (string estado in estados.Values)
{
    //Console.WriteLine($"{estado}{estado}");
}


var cidades = new Queue<string>();
cidades.Enqueue("Salto");
cidades.Enqueue("Itu");
cidades.Enqueue("Indaiá");
foreach (string cidade in cidades)
{
    Console.WriteLine(cidade);
}

cidades.Dequeue();
Console.WriteLine("-----------------");
foreach (string cidade in cidades)
{
    Console.WriteLine(cidade);
}

Console.WriteLine("-----------------");

int total = cidades.Count;
Console.WriteLine(total);

Console.WriteLine("-----------------");
Console.WriteLine(cidades.Peek());  
