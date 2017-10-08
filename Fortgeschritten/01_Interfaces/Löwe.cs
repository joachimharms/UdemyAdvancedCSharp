#region License
// Copyright (c) 2017, Joachim Harms
// All rights reserved.
// 
// Unauthorized copying of this file, via any medium is strictly prohibited.
// Proprietary and confidential.
// 
// Written by Joachim Harms
// <joachimharms.business@gmail.com>
#endregion

using System;

namespace _01_Interfaces
{
    public class Löwe : ITier
    {
        public Löwe(int alter, string geschlecht)
        {
            this.Alter = alter;
            this.Geschlecht = geschlecht;
        }

        public int Alter { get; set; }

        public string Geschlecht { get; set; }

        public void Essen()
        {
            Console.WriteLine("Der Löwe frisst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Löwe trinkt");
        }
    }
}