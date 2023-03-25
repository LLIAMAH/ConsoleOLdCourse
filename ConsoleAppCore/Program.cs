using ConsoleAppCore.Classes;

ValueData valueData = new ValueData();
ClassData classData = new ClassData();

valueData.SetNewData(4);
classData.SetNewData(5);

ValueData valueData1 = valueData;
ClassData classData1 = classData;

valueData.SetNewData(6);
classData.SetNewData(7);

ValueData valueData2 = valueData1;

ClassData classData2 = new ClassData();
ClassData classData3 = new ClassData(5);
classData2.SetNewData(10);
classData1 = classData2;

var person = new Person("Vasiliy", "H", Gender.Male);

string firstname, lastname;

(_, lastname) = person;


var person2 = new Person("Vasiliy", "H");

//var item = new Item();


try
{
    // line 1




    /// line 1000
}
finally
{
    
}

var agedPerson = new PersonAged();
// agedPerson.a = 6;


int a = default;