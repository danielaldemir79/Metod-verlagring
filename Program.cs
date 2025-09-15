namespace Metodöverlagring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(helaNamnet("Daniel", "Aldemir"));

            Console.WriteLine(helaNamnet("Daniel", "Dani", "Aldemir"));


            Console.WriteLine(helaNamnet("daniel", "aldemir", true));

        }
    

    static string helaNamnet(string förnamn, string efternamn)
        {
            var fullständigtNamn = $"{förnamn} {efternamn}";
            return fullständigtNamn;

        }

        static string helaNamnet(string förnamn, string mellannamn, string efternamn)
        {
            var fullständigtNamn = $"{förnamn} { mellannamn}  { efternamn}";
            return fullständigtNamn;

        }


        static string helaNamnet(string förnamn, string efternamn, bool check)
        {
            var full = $"{förnamn} {efternamn}";
            return check ? full.ToUpper() : full;
        }


    }
}
