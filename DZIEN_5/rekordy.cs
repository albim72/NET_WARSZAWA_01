Person pr = new Person("Jan", "Kot");
Console.WriteLine(pr);

PersonX prX = new PersonX();
prX.FirstName= "Olga";
prX.LastName = "Nowak";
Console.WriteLine(prX);

var pnumbers = new string[2];

PersonY py1 = new("Nina", "Kowal", pnumbers);
PersonY py3 = new("Nina", "Kowal", pnumbers);
PersonY py2 = new("Marek", "Kot", pnumbers);

Console.WriteLine(py1==py2);
Console.WriteLine(py1==py3);

py1.PhoneNumbers[0] = "545-343-532";
Console.WriteLine(ReferenceEquals(py1, py3));
Console.WriteLine(ReferenceEquals(py1, py2));

Boss bs = new Boss("Taduesz", "Kowal", 134);
Console.WriteLine(bs);



public record Person(string FirstName, string LastName);
public record PersonX
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
};

public record PersonY(string FirstName, string LastName, string[] PhoneNumbers);
public record Boss(string FirstName, string LastName,int nb):Person(FirstName,LastName);
