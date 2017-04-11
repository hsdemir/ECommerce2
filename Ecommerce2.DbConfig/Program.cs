using Ecommerce2.Data.DataContext;

namespace Ecommerce2.DbConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("İşlemi başlatmak için bir tuşa basın.");
            System.Console.ReadLine();

            Ecommerce2Context context = new Ecommerce2Context();
            if (context.Database.Exists())
            {
                context.Database.Delete();
            }

            context.Database.Create();

            System.Console.Write("Database oluşturulma işlemi gerçekleştirildi.");
        }
    }
}
