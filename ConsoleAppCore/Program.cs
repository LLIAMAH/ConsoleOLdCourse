using System.Drawing;
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

string a = "sdfassfdsdsfd";
var length = a.Length;

var agedPerson = new PersonAged();
// agedPerson.a = 6;


var personOld = new PersonOld();


//var person1 = new Person();
//person1.OutString(out person1.surname);
//person1.OutString(out person1.Surname);
//person1.OutString1(person1.Surname);

//var string1 = "sadfasdfasdf";
//string1.Length;


var arrayFigures = new Figure[10];
arrayFigures[0] = new Circle(new Point(), new Size());
arrayFigures[1] = new Triangle(new Point(), new Size());
arrayFigures[2] = new Square(new Point(), new Size());  
arrayFigures[3] = new Circle(new Point(), new Size());
arrayFigures[4] = new Square(new Point(), new Size());
arrayFigures[5] = new Triangle(new Point(), new Size());
arrayFigures[6] = new Circle(new Point(), new Size());
arrayFigures[7] = new Circle(new Point(), new Size());
arrayFigures[8] = new Triangle(new Point(), new Size());
arrayFigures[9] = new Square(new Point(), new Size());

Figure figureSingle = new Circle(new Point(), new Size());


for (int i = 0; i < arrayFigures.Length; i++)
{
    arrayFigures[i].Draw();
}


((Triangle) arrayFigures[1]).DrawUltraMegaTriangle(7);
((Triangle)arrayFigures[1]).DrawUltraMegaTriangle(-4);

var staticFig1 = new Circle(new Point(), new Size());
staticFig1.Test(5);
Circle.data = 10;
staticFig1.Test(5);
var staticFig2 = new Circle(new Point(), new Size());
staticFig1.Test(5);
staticFig2.Test(5);
var staticFig3 = new Circle(new Point(), new Size());
staticFig1.Test(5);
staticFig2.Test(5);
staticFig3.Test(5);
Circle.data = 7;
staticFig1.Test(5);
staticFig2.Test(5);
staticFig3.Test(5);


var strin1g = String.Format("Param1: {0}; Param2: {1}, Param3: {2}", 4, 5, 6);

