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
    public class Hund : ITier
    {
        public Hund(int alter, string geschlecht)
        {
            this.Alter = alter;
            this.Geschlecht = geschlecht;
        }

        // Eigenschaften
        public int Alter { get; set; }

        public string Geschlecht { get; set; }

        // Methoden
        public void Essen()
        {
            Console.WriteLine("Der Hund frisst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt...");
        }
    }
}