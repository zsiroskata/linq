#region DOGS
using linq;

List<dog> dogs = 
[
    new()
    {
        Name = "Kira",
        Birth = DateTime.Parse("2019-05-10"),
        Sex = false,
        Breed = "tacskó",
        Weight = 5.5F
    },
    new()
    {
        Name = "Rex",
        Birth = DateTime.Parse("2014-04-20"),
        Sex = true,
        Breed = "németjuhász",
        Weight = 35.2F
    },
    new()
    {
        Name = "Igor",
        Birth = DateTime.Parse("2017-11-20"),
        Sex = false,
        Breed = "kaukázusi farkasölő",
        Weight = 5.5F
    },
    new()
    {
        Name = "Thomas Edison",
        Birth = DateTime.Parse("2001-02-07"),
        Sex = true,
        Breed = "németjuhász",
        Weight = 40F
    },
    new()
    {
        Name = "Princess",
        Birth = DateTime.Parse("2022-12-24"),
        Sex = false,
        Breed = "palotapincsi",
        Weight = 4.2F
    }
];
//megszámlálás tétel

//ugyan azok az elmek száma 

//3 évnél öregebb kutyák száma
int haromEvnelIdosebb = 0;
foreach (var dog in dogs)
{
    if (dog.Age >= 3) haromEvnelIdosebb++;
}
Console.WriteLine($"3 évnél idősebb kutyák száma {haromEvnelIdosebb} db");

int LinqHaromEvesnelIdosebb = dogs.Count(d=> d.Age >3 );
Console.WriteLine($"linq-val :{LinqHaromEvesnelIdosebb} db");


//szukák száma
int szukaKutya = 0;
for (int i = 0; i < dogs.Count; i++)
{
    if (!dogs[i].Sex) 
    {
        szukaKutya++;
    }
}
Console.WriteLine($"Szuka kutyák száma {szukaKutya} db");

int LingqSzuka = dogs.Count(d => !d.Sex);
Console.WriteLine($"Linq szuka száma {LingqSzuka} db");




#endregion