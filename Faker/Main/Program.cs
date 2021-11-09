using System;
using Faker;
using Faker.BaseTypes;

namespace Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenerator i = new ByteGenerator();
            Console.WriteLine(i.GeneratorType);
        }
    }
}