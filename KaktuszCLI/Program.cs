using KaktuszCLI;

Random rnd = new();

List<Kaktusz> kaktuszok = new();
using StreamReader sr = new(@"..\..\..\src\kaktuszok.txt");
while (sr.EndOfStream) kaktuszok.Add(new(sr.ReadLine()));

Console.WriteLine($"f1: kaktuszok száma: {kaktuszok.Count}");

string f2 = kaktuszok.MaxBy(k => k.LatinNev.Length).LatinNev;
Console.WriteLine($"f2: leghosszabb tudományos név: {f2}");

var f3a = kaktuszok.Where(k => k.Vizigeny > 100).ToArray();
Console.WriteLine($"f3: 100ml-nél nagyobb vízigényű kaktuszok száma: {f3a.Length}");
var f3b = f3a[rnd.Next(f3a.Length)];
Console.WriteLine($"\tpéldául: {f3b.KoznapiNev} ({f3b.Vizigeny} ml/hét)");

var f4 = kaktuszok.GroupBy(k => k.Nehezseg);
Console.WriteLine("f4: kaktuszok száma termesztési nehézség szerint:");
foreach (var grp in f4) Console.WriteLine($"\t{grp.Key}: {grp.Count()} db");