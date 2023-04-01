
using ConsoleAppCore.Classes;
using System.Collections.Generic;

IPlayerCharacter pc1 = new PlayerCharacter() { Name = "Egor" };
IPlayerCharacter pc2 = new PlayerCharacter() { Name = "Squirrel" };
IPlayerCharacter nonPc = new NonPlayerCharacter() { Name = "Zombie", Health = 200 };

pc1.Atack(pc2);
pc1.Atack(nonPc);
pc2.Atack(nonPc);

Trap.TrapWroked((ICanGetIntoTrap)pc1);
Trap.TrapWroked((ICanGetIntoTrap)nonPc);




var extendedArrayInt = new ExtendedArray<int>();
var extendedArrayDouble = new ExtendedArray<double>();
var extendedArrayRef = new ExtendedArray<PlayerCharacter>();

extendedArrayInt.Add(6);
extendedArrayDouble.Add(4.5);
//extendedArrayRef.Add(pc1);
//extendedArrayRef.Add(pc2);

Console.WriteLine($"{pc1}");
Console.WriteLine($"{pc2}");

extendedArrayInt.Add(6);
extendedArrayInt.Add(5);
extendedArrayInt.Add(9);
extendedArrayInt.Add(7);
extendedArrayInt.Add(11);

for (int i = 0; i < extendedArrayInt.Length; i++)
{
    Console.WriteLine($"Array element [{i}]: {extendedArrayInt[i]}");
    //extendedArrayInt[i] = 5;
}
// 6, 6, 5, 9, 7, 11

extendedArrayInt = extendedArrayInt + 20;
// 6, 6, 5, 9, 7, 11, 20
for (int i = 0; i < extendedArrayInt.Length; i++)
{
    Console.WriteLine($"Array element [{i}]: {extendedArrayInt[i]}");
    //extendedArrayInt[i] = 5;
}

extendedArrayInt = extendedArrayInt + 45;
// 6, 6, 5, 9, 7, 11, 20, 45 
for (int i = 0; i < extendedArrayInt.Length; i++)
{
    Console.WriteLine($"Array element [{i}]: {extendedArrayInt[i]}");
    //extendedArrayInt[i] = 5;
}


extendedArrayInt += 21;
// 6, 6, 5, 9, 7, 11, 20, 45, 21
for (int i = 0; i < extendedArrayInt.Length; i++)
{
    Console.WriteLine($"Array element [{i}]: {extendedArrayInt[i]}");
}

extendedArrayInt[0] = 5;

Console.WriteLine("Loop FOREACH");



foreach (var item in extendedArrayInt)
{
    Console.WriteLine($"Item: {item}");
}

Console.WriteLine("==============================================");

List<int> list = new List<int>() { 34, 52, 54, 534, 453, 45, 3421, 3451, 45332, 456435, 6743, 57, 56 };
list.AddRange(list.ToArray());


Console.WriteLine(string.Join(",", extendedArrayInt));
Console.WriteLine(string.Join(",", list));

