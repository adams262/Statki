
namespace Statki__EP_AS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int length = 10;
            const int width = 10;
            
            Plansza plans = new Plansza(length,width);

            plans.WyswietlPlansze();
            plans.UmiescStatek(4,0,0,false);
            plans.WyswietlPlansze();
            plans.Atak(0, 0);
            plans.WyswietlPlansze();


        }

       
    }
}
