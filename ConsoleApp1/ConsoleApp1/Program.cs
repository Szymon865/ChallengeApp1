string Name = "Ewa";
bool Female = true;
int Age = 33;

if (Female && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Age == 33 && Name == "Ewa")
{
    Console.WriteLine("Ewa, Lat 33");
}
else if (!Female && Age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}