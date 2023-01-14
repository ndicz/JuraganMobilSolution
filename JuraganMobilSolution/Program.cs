
using JuraganMobilSolution.Base;
using JuraganMobilSolution.Model;

//Taxi data = new("N 4881 GF", 2012, 3_000_000, 5,new DateOnly(2023, 10, 23), 500_000, 50_000);



//Console.WriteLine(Taxi.Count());

//Console.WriteLine(data.ToString());

namespace JuraganMobil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repoManager = new RepoManager();


            //----------------- FindAll ----------------
            var findAllSuv = repoManager.Suv.FindAll();
            foreach (var s in findAllSuv)
                Console.WriteLine(s);

            //----------------- Create ----------------
            //var createSuv = repoManager.Suv.Create(new Suv("P 1999 DK", "2010", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M));
            //foreach (var suv in createSuv)
            //    Console.WriteLine(suv);

            //----------------- FindById --------------
            //BaseVehicle findSuv = repoManager.Suv.FindById("D 1001 UM");
            //Console.WriteLine(findSuv);

            //----------------- Update ----------------
            //var updateSuv = repoManager.Suv.Update("D 1001 UM", new Suv("P 1111 DK", "2010", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M));
            //Console.WriteLine(updateSuv);

            //----------------- Delete ----------------
            //var deleteSuv = repoManager.Suv.Delete("D 1003 UM");
            //Console.WriteLine($"Deleted Row : {deleteSuv}")
        }
    }
}