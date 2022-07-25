using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglandWordCase.Models
{
    [Serializable]
    public class SettingModel
    {
        public SettingModel(int count)
        {
            Count = count;
        }

        public int Count { get; set; }

    }
}
