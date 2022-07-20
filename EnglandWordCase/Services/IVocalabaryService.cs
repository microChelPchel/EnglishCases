
using EnglandWordCase.Models;
using System.Collections.Generic;

namespace EnglandWordCase.Services
{
    internal interface IVocalabaryService
    {
        bool SaveVocalobary(List<WordModel> words);

    }
}
