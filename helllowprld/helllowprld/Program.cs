using System.Data;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Helllo World!");

          // app.MapGet("/num/{a}/{b}",(int a, int b) => $" sum = {a + b}\n product = {a*b}\n difference = {a-b}\n division(quotient) ={a/b}")  ;



            app.Run();
        }
    }
}
