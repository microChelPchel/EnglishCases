using EnglandWordCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglandWordCase.Services
{
    internal class TestService : BasesService, ITestService
    {
        public List<WordModel> LoadWordData(int countWord)
        {
            List<WordModel> list = Desirilize<List<WordModel>>("words.dat");
            Random random = new Random();
            List<WordModel> result = new List<WordModel>();
            if (list.Count == 0)
            {
                return null;
            }
            for (var i=0; i<countWord;i++)
            {
                result.Add(list[random.Next(0, list.Count - 1)]);
            }
            return result;
        }

    }
}
