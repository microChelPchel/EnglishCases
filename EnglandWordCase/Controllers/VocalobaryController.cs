using EnglandWordCase.Models;
using EnglandWordCase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglandWordCase.Controllers
{
    internal class VocalobaryController
    {
        private IVocalabaryService service;
        public VocalobaryController()
        {
            service = new VocalabaryService();
        }


        public bool Save(List<WordModel> words)
        {
            return service.SaveVocalobary(words);
        }
    }
      
}
