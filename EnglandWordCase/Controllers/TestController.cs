using EnglandWordCase.Models;
using EnglandWordCase.Services;
using System.Collections.Generic;

namespace EnglandWordCase.Controllers
{
    internal class TestController 
    {
        private ITestService testService;

        public TestController() 
        {
             testService = new TestService();
        }

        public List<WordModel> GetWords(int countWord)
        {
            return testService.LoadWordData(countWord);
        }


    }
}
