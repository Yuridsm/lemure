using System;
using System.Collections;
using System.Collections.Generic;

namespace lemure.DropCode
{
    public class Panda
    {
        public string Name { get; set; }
        private static int AmountInstance { get; set; }
        public Panda()
        {
            AmountInstance = AmountInstance+1;
        }
        public IEnumerable<Panda> GenerateInstance(int amount)
        {
            List<Panda> pandas = new List<Panda>();
            for(int i = 0; i < amount; i++)
            {
                pandas.Add(new Panda());
            }
            return pandas;
        }

        public static void GetInstanceAmount()
        {
            Console.WriteLine($"Amount: {AmountInstance}");
        }
    }
}