
using ConsoleAppCore.Classes;

//IList listWO = new List();

//listWO.Add(5); // <= Вот эту фигню

int a = 5;
object a1 = (object)a; // boxing/unboxing

IList<IPlayerCharacter> listInterfaced = new List<IPlayerCharacter>();
List<IPlayerCharacter> list = new List<IPlayerCharacter>();
listInterfaced.Add(new PlayerCharacter() { Name = "Egor" });
list.AddRange(new[]
{
    new PlayerCharacter() { Name = "Zeleniy"},
    new PlayerCharacter() { Name = "Zolotoy" },
    new PlayerCharacter() { Name = "Bodya"},
    new PlayerCharacter() { Name = "Olga"},
});

Stack<IPlayerCharacter> stackPC = new Stack<IPlayerCharacter>();
Queue<IPlayerCharacter> queuePC = new Queue<IPlayerCharacter>();

Dictionary<string, IPlayerCharacter> dictionary = new Dictionary<string, IPlayerCharacter>();

var item = new PlayerCharacter() { Name = "Zolotoy" };

KeyValuePair<string, IPlayerCharacter> kvPair;
dictionary.TryAdd("Zolotoy", item );

dictionary["Zolotoy"] =  item;
var item1 = dictionary["Zolotoy"];

//Lookup<string, IPlayerCharacter> lookup = new Lookup<string, IPlayerCharacter>(); // <= Неправильный вариант создания Lookup

var lookup = list.ToLookup(n => n.Name[0]);


var data = from person in list
    where person.Name.StartsWith('Z')
    select new
    {
        FirstName = person.Name,
        LastName = person.Name + "Bla-bla-bla",
    };


StaticThread.ThreadTests();