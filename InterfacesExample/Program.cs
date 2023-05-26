using InterfacesExample;

var cat = new Cat();

cat.Age = 5;
cat.NumberOfLegs = 4;
cat.Name = "Spark";

cat.MakeNoise();


var dog = new Dog();

dog.Age = 3;
dog.NumberOfLegs = 3;
dog.Name = "Scout";


var house = new List<IAnimal>();

house.Add(dog);
house.Add(cat);

foreach (var animal in house)
{
    Console.WriteLine($"This is my pet, {animal.Name}. It is {animal.Age} years old and it has {animal.NumberOfLegs} number of legs.");
}