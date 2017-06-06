using System;
using System.IO;
using Newtonsoft.Json;

namespace jsonfile
{
    class Program
    {
        static void Main(string[] args)
        {
            //The file in csproj is marked as copy to output
            //Therefore it will sit next to the app's dll in the Debug or Release folder
            //For example, run dotnet run and it will work in Debug mode or run dotnet publish -c Release && cd bin/Release/netcoreapp1.1/publish && dotnet jsonfile.dll
            var person = JsonConvert.DeserializeObject<Person>(File.ReadAllText("myfile.json"));
            Console.WriteLine(person.Name + person.Age);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
