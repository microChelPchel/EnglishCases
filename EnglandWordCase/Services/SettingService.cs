using EnglandWordCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglandWordCase.Services
{
    internal class SettingService : BasesService, ISettingService
    {
        public void Save(SettingModel setting)
        {
            Serilaze("setting.dat", setting);
        }

        public SettingModel Load()
        {
          return Desirilize<SettingModel>("setting.dat");
        }

    }
}
