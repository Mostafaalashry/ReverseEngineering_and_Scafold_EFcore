// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore.SqlServer;


Console.WriteLine("Hello, World!");

/*
to make scaffold 
in terminal in visual studio


dotnet tool install --global dotnet -ef --version7.0.0

dotnet ef dbcontext scaffold "Server=localhost;Database=TechTalk;User Id=SA;Password=YourStrong\!Passw0rd;TrustServerCertificate=True;" 
Microsoft.EntityCore.SqlServer -o Models --force

 we can also replace configration sfluent api by DataAnnotation

dotnet ef dbcontext scaffold "Server=localhost;Database=TechTalk;User Id=SA;Password=YourStrong\!Passw0rd;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer DataAnnotation -o Models --force  --project ReverseEngineering_and_Scafold_EFcore.csproj

 */



//foreach (var item in new TechTalkContext().Speakers)
//{
//    Console.WriteLine(item.FirstName);
//    Console.WriteLine(item.LastName);

//}