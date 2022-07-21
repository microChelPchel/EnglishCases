using EnglandWordCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglandWordCase.Services
{
    internal interface ITestService
    {
        List<WordModel> LoadWordData(int count);
    }
}
