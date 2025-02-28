﻿using PetPassBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.MockData
{
    internal class PetMockData
    {
        public static List<Pet> GetMockPets()
        {
            return new List<Pet>
            {
                new Pet
                {
                    Id = 1,
                    NomePet = "Luna",
                    Raca = "Dogue alemão",
                },
                new Pet
                {
                    Id = 2,
                    NomePet="Maya",
                    Raca="Husky siberiano"
                },
                new Pet
                {
                    Id = 3,
                    NomePet="Buana",
                    Raca="Poodle"
                },
                new Pet
                {
                    Id = 19,
                    NomePet="Golias",
                    Raca="Fila"
                }
            };
        }
    }
}
