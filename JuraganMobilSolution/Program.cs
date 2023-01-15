       
using JuraganMobilSolution.Base;
using JuraganMobilSolution.Model;
using JuraganMobilSolution.Summary;

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




            //-------------------------SUV-------------------------------------------//

            //----------------- FindAll ----------------    
            var findAllSuv = repoManager.Suv.FindAll();
            var findalljet = repoManager.privateJet.FindAll();
            var findalltaxi = repoManager.taxi.FindAll();
            foreach (var s in findAllSuv) ;
            foreach (var s in findalltaxi) ;
            foreach (var s in findalljet) ;
            //Console.WriteLine(s);
            //GetTotalVehicle()


            var result = repoManager.summary.GetTotalIncomeVehicle();

            Console.WriteLine("JUMLAH KENDARAAN = {0:n0}", result);



            //Taxi.Count();
            //Console.WriteLine($"Jumlah Taxi {Taxi.Count()}");

            //----------------- Create ----------------
            //var createSuv = repoManager.Suv.Create(new Suv("P 1999 DK", "2010", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M));
            //foreach (var suv in createSuv)
            //    Console.WriteLine(suv);

            //----------------- FindById --------------
            //Vehicle findSuv = repoManager.Suv.FindById("D 1001 UM");
            //Console.WriteLine(findSuv);

            //----------------- Update ----------------
            //var updateSuv = repoManager.Suv.Update("D 1001 UM", new SUV("D 1001234 UM", 2010, 35000_0000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M));
            //Console.WriteLine(updateSuv);

            //----------------- Delete ----------------
            //var deleteSuv = repoManager.Suv.Delete("D 1001 UM");
            //Console.WriteLine($"Deleted Row : {deleteSuv}");

            //-------------------------TAXI-------------------------------------------//

            //-------------------------JET -------------------------------------------//
        }
    }
}