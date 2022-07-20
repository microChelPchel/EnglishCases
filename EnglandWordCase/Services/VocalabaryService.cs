using EnglandWordCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglandWordCase.Services
{
    internal class VocalabaryService : BasesController, IVocalabaryService
    {
      
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
