string ReturnPersonName(Person p) => p.Name;
string ReturnPersonTwoName(PersonTwo p) => p.Name;

var prsn = new Person();
var prsn2 = new PersonTwo();

// Doesn't warn, but crashes at runtime
// type is string tho, not string?
prsn.Name = null;
// Warn
prsn2.Name = null;

Console.WriteLine($"*|{ReturnPersonName(prsn)}|*");
Console.WriteLine($"*|{ReturnPersonTwoName(prsn2)}|*");

class PersonTwo
{
    public string Name { get; set; } = "";
}
