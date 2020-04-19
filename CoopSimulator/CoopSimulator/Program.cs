using System;
using System.Collections.Generic;
using CoopSimulator.Data;
using Microsoft.VisualBasic;

namespace CoopSimulator
{
    class Program
    {
        public static List<Data.PoultryDto> PoultryList = new List<PoultryDto>();

        public static Data.ConfigurationDto.Configuration Configuration { get; set; }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Configuration = Util.Configuration();
        }
    }
}
