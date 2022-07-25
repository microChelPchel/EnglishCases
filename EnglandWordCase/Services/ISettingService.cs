using EnglandWordCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglandWordCase.Services
{
    interface ISettingService
    {
        void Save(SettingModel setting);
        SettingModel Load();

    }
}
