
namespace SportClubProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sports sports1 = new Sports("tennis", 10, 25.90);
            Sports sports2 = new Sports("football", 15, 55.90);
            Sports sports3 = new Sports("basketball", 20, 45.90);

            Member member1 = new Member("Hilal Nur", 100);
            member1.getInfo();

            Member member2 = new Member("Ayşe", 200);
            member2.getInfo();

            member1.registerCourse(sports1);
            member1.registerCourse(sports2);
            member1.registerCourse(sports3);
            member1.listCourse();


            Console.WriteLine(ClubCard.Counter);

        }
    }
}

