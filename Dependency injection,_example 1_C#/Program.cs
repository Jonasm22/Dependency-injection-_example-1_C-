
using Dependency_injection__example_1_C_;

public class Program
{

    // REVISAR_ ERROR 
    static void Main(string[] args)
    {

        service1 service1 = new service1();

        client cl1 = new client(service1);
        cl1.ServeMethod();

        service2 service2 = new service2();
        client cl2 = new client(service2);
        cl2.ServeMethod();
        Console.ReadKey();

    }




}
