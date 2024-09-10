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
        Sex = true,
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
#endregion
//megszámlálás tétel
#region megszamlalas 
//ugyan azok az elmek száma 

//3 évnél öregebb kutyák száma
int haromEvnelIdosebb = 0;
foreach (var dog in dogs)
{
    if (dog.Age >= 3) haromEvnelIdosebb++;
}
Console.WriteLine($"3 évnél idősebb kutyák száma {haromEvnelIdosebb} db");

int LinqHaromEvesnelIdosebb = dogs.Count(d => d.Age > 3);
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

int LinqSzuka = dogs.Count(d => !d.Sex);
Console.WriteLine($"Linq szuka száma {LinqSzuka} db");

//kutyusok amiknek tartalmaz e betűt a nevében és hím
int linqEbk = dogs.Count(d => d.Sex && d.Name.ToLower().Contains("e"));
Console.WriteLine($"e betű {linqEbk}");

#endregion

#region osszegzes
Console.WriteLine("- - - - - - - - - ");

int kutyakOsszesEletkora = 0;
foreach (var dog in dogs)
{
    kutyakOsszesEletkora += dog.Age;
}
Console.WriteLine($"kutyák össz életkora {kutyakOsszesEletkora}");

int kutyeletkorok = dogs.Sum(d => d.Age);
Console.WriteLine($"linq-val {kutyeletkorok}");
#endregion

#region atlag 
Console.WriteLine("- - - - - - - - - ");
float kutyakEletkorAtlag = kutyakOsszesEletkora / (float)dogs.Count;
Console.WriteLine($"linq-val{kutyakEletkorAtlag}");

double linqKutyKorAtlag = dogs.Average(d => d.Age);
Console.WriteLine($"linq-val{linqKutyKorAtlag}");
#endregion

#region szelsosegek
Console.WriteLine("- - - - - - - - - ");
//legnagyobb sulyu kutya neve, sulya és indexe
int maxSulyIndex = 0;
for (int i = 1; i < dogs.Count; i++)
{
    if (dogs[i].Weight > dogs[maxSulyIndex].Weight)
    {
        maxSulyIndex = i;
    }
}
Console.WriteLine($"legnagyobb súlyú kutya indexe {maxSulyIndex}");
Console.WriteLine($"legnagyobb súlyú kutya neve {dogs[maxSulyIndex].Name}");
Console.WriteLine($"legnagyobb súlyú kutya súlya {dogs[maxSulyIndex].Weight}");

float linqMax = dogs.Max(d => d.Weight);
Console.WriteLine($"linq-s megoldás {linqMax}");

DateTime linqLegfiatalabb = dogs.Min(d => d.Birth);
Console.WriteLine($"legfiatalabb doggo kora {linqLegfiatalabb}");


#endregion


#region
#endregion