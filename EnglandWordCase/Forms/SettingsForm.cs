using EnglandWordCase.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglandWordCase.Forms
{
    public partial class SettingsForm : Form
    {
        private SettingController _settingController; 
        public SettingsForm()
        {
            InitializeComponent();
            _settingController = new SettingController();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _settingController.SetDataSetting(new Models.SettingModel((int)numericUpDown1.Value));

            MessageBox.Show("Настройки сохранены!");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var setting = _settingController.GetDataSetting()?? new Models.SettingModel(0);
            numericUpDown1.Value = setting.Count;
        }

    }
}
