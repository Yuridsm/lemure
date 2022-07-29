﻿using Lemure.DesignPatterns.Strategy.Contracts;
using System;

namespace Lemure.DesignPatterns.Strategy.Concretes
{
    public class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute(int coordinateX, int coordinateY)
        {
            Console.WriteLine($"Calculating routing for Walking by using coordinates {coordinateX}  and {coordinateY}");
        }
    }
}
