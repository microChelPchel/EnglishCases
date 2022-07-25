using EnglandWordCase.Models;
using EnglandWordCase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglandWordCase.Controllers
{
    internal class SettingController
    {
        private ISettingService _settingService;
        public SettingController()
        {
            _settingService = new SettingService();
        }

        public SettingModel GetDataSetting()
        {
            return _settingService.Load();
        }

        public void SetDataSetting(SettingModel setting)
        {
            _settingService.Save(setting);
        
        }


    }
}
