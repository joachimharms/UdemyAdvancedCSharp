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

namespace _01_Interfaces
{
    public interface ITier
    {
        // Eigenschaften
        int Alter { get; set; }

        string Geschlecht { get; set; } 

        // Methoden
        void Essen();

        void Trinken();
    }
}