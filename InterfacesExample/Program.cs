using InterfacesExample;

var cat = new Cat();

cat.Age = 3;
cat.NumberOfLegs = 4;

cat.MakeNoise();


var dog = new Dog();

dog.Age = 3;
dog.NumberOfLegs = 3;


var house = new List<IAnimal>();

house.Add(dog);
house.Add(cat);

foreach (var animal in house)
{
    Console.WriteLine($"This is my pet is is {animal.Age} years old and it has {animal.NumberOfLegs} number of legs.");
}