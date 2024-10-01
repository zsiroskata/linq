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
    },
    new()
    {
        Name = "Charlie",
        Birth = DateTime.Parse("2017-08-18"),
        Sex = true,
        Breed = "labrador retriever",
        Weight = 32.0F
    },
    new()
    {
        Name = "Sophie",
        Birth = DateTime.Parse("2021-04-12"),
        Sex = false,
        Breed = "shih tzu",
        Weight = 5.5F
    },
    new()
    {
        Name = "Rocky",
        Birth = DateTime.Parse("2013-02-28"),
        Sex = true,
        Breed = "boxer",
        Weight = 28.0F
    },
    new()
    {
        Name = "Molly",
        Birth = DateTime.Parse("2022-01-30"),
        Sex = false,
        Breed = "bichon frise",
        Weight = 6.0F
    },
    new()
    {
        Name = "Finn",
        Birth = DateTime.Parse("2019-07-04"),
        Sex = true,
        Breed = "border collie",
        Weight = 15.0F
    },
    new()
    {
        Name = "Zoe",
        Birth = DateTime.Parse("2020-10-20"),
        Sex = false,
        Breed = "chihuahua",
        Weight = 3.0F
    },
    new()
    {
        Name = "Bella",
        Birth = DateTime.Parse("2018-03-15"),
        Sex = false,
        Breed = "bulldog",
        Weight = 25.0F
    },
    new()
    {
        Name = "Max",
        Birth = DateTime.Parse("2016-06-10"),
        Sex = true,
        Breed = "golden retriever",
        Weight = 30.5F
    },
    new()
    {
        Name = "Luna",
        Birth = DateTime.Parse("2020-09-05"),
        Sex = false,
        Breed = "poodle",
        Weight = 6.8F
    },
    new()
    {
        Name = "Buddy",
        Birth = DateTime.Parse("2015-01-25"),
        Sex = true,
        Breed = "beagle",
        Weight = 10.0F
    },
    new()
    {
        Name = "Daisy",
        Birth = DateTime.Parse("2019-11-11"),
        Sex = false,
        Breed = "cocker spaniel",
        Weight = 12.3F
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

Console.WriteLine("- - - - - - - - - ");
#region osszegzes

int kutyakOsszesEletkora = 0;
foreach (var dog in dogs)
{
    kutyakOsszesEletkora += dog.Age;
}
Console.WriteLine($"kutyák össz életkora {kutyakOsszesEletkora}");

int kutyeletkorok = dogs.Sum(d => d.Age);
Console.WriteLine($"linq-val {kutyeletkorok}");
#endregion

Console.WriteLine("- - - - - - - - - ");
#region atlag 
Console.WriteLine("kutya átlag életkora");
float kutyakEletkorAtlag = kutyakOsszesEletkora / (float)dogs.Count;
Console.WriteLine($"float és linq-val{kutyakEletkorAtlag}");

double linqKutyKorAtlag = dogs.Average(d => d.Age);
Console.WriteLine($"double és linq-val{linqKutyKorAtlag}");
#endregion

#region szelsosegek
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
Console.WriteLine("- - - - - - - - - ");


#region rendezes
//.Sort() meg változik az elemek sorrendje az eredeti file-ban
// .orderby(); .order()...stb nem változik a file
var linqOBNames = dogs.OrderBy(d => d.Name);

foreach (var x in linqOBNames)
{
    Console.WriteLine($"{dogs.IndexOf(x)} - {x.Name}");
}
//nézd meg neki a gitet, köszi

#endregion
Console.WriteLine("- - - - - - - - - ");

#region kiválogatás
var linqWhere = dogs.Where(d => d.Birth.Year >= 2020);
foreach (var x in linqWhere)
{
    Console.WriteLine(x.Name);
}
#endregion

#region
#endregion

#region
#endregion

#region
#endregion



