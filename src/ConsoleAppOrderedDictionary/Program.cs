using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 9 | OrderedDictionary<TKey,TValue> *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

OrderedDictionary<string, int> d = new()
{
    ["GER"] = 1974,
    ["Espanha"] = 1982,
    ["Mexico"] = 1986,
    ["Italia"] = 1990,
    ["EUA"] = 1994
};
d.Add("Franca", 1998);
d.Insert(1, "Argentina", 1978);
d.RemoveAt(0);
d.Insert(0, "Alemanha", 1974);

Console.WriteLine("Copas do Mundo de Futebol - 1974 a 1998:");
foreach (KeyValuePair<string, int> entry in d)
    Console.WriteLine(entry);