﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiApp
{
    /// <summary>
    /// Класс питомца
    /// </summary>
    /// <param name="name">Имя питомца</param>
    public class Pet(string name)
    {
        /// <summary>
        /// Имя питомца
        /// </summary>
        public required string PetName{ get; set; } = name;

        /// <summary>
        /// Здоровье питомца
        /// </summary>
        private int PetHealth{ get; set; } = 10;

        /// <summary>
        /// Голод питомца
        /// </summary>
        private int PetHunger{ get; set; } = 0;

        /// <summary>
        /// Усталось питомца
        /// </summary>
        private int PetFatigue{ get; set;} = 0;

        /// <summary>
        /// Действие кормления
        /// </summary>
        public void Feed()
        {
            PetHunger--;
            if (PetHunger <= 10) return;
            PetHunger = 10;
            PetHealth--;
        }

        /// <summary>
        /// Действие игры
        /// </summary>
        public void Play()
        {
            PetFatigue++;
            if (PetFatigue <= 10) return;
            PetHealth--;
            PetHunger--;
        }

        /// <summary>
        /// Действие Сна
        /// </summary>
        public void Sleep()
        {
            PetFatigue = 0;
            PetHealth++;
            PetHunger--;
        }
    }
}
