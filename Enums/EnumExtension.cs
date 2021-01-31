﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Enums
{
    
    public static class EnumExtension
    {
        public static MyOptions minPassing = MyOptions.D; // 1
        public static bool Passing(this MyOptions grade)
        {
            return grade >= minPassing;
        }
    }
}
