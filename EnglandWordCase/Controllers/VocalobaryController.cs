using EnglandWordCase.Models;
using EnglandWordCase.Services;
using System.Collections.Generic;

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

        public List<WordModel> Load() => service.LoadVocalobary();

    }
      
}
