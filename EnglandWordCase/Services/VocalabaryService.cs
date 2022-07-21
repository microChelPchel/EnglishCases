using EnglandWordCase.Models;
using System;
using System.Collections.Generic;

namespace EnglandWordCase.Services
{
    internal class VocalabaryService : BasesService, IVocalabaryService
    {
        public List<WordModel> LoadVocalobary() => Desirilize<List<WordModel>>("words.dat");

        public bool SaveVocalobary(List<WordModel> words)
        {
            try
            {
                Serilaze("words.dat", words);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

    }
}
