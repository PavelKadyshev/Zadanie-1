string[] calture = {"Полина" , "Мария", "Наталья", "Евгения"};
string[] calture1 = {"Яна" ,"Александра", "Елена", "Алла", "Светлана"};
string[] calture2 = { "Полина", "Мария", "Наталья", "Евгения" } ;
//встречаются в некоторых классах
var rez1 = calture1.Union(calture2).Intersect(calture);
Console.WriteLine("В некоторых классах");
foreach(var cl in rez1)
{
    Console.WriteLine(cl);
}
//не встречаются ни в одном из классов
var rez2 = calture2.Union(calture1).Intersect(calture1);
Console.WriteLine("Не встречаются ни в одном из классов");
foreach (var cl in rez2)
{
    Console.WriteLine(cl);
}