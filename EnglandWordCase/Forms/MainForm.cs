using EnglandWordCase.Controllers;
using EnglandWordCase.Forms;
using EnglandWordCase.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EnglandWordCase
{
    public partial class MainForm : Form
    {
        private Point pointForm;
        private VocalobaryController vocalobaryController;
        private TestController testController;
        private StructureData.Queue<WordModel> _queue;
        private WordModel _currentWord;
        private int score;
        private SettingController _settingController;

        public MainForm()
        {
            InitializeComponent();
            vocalobaryController = new VocalobaryController();
            testController = new TestController();
            _queue = new StructureData.Queue<WordModel>();
            _settingController= new SettingController();
        }


        private void moveForm(MouseEventArgs evnt)
        {
            if (evnt.Button == MouseButtons.Left)
            {
                Left += evnt.X - pointForm.X;
                Top += evnt.Y - pointForm.Y;
            }
        }

        private void downOnTrey(MouseEventArgs evnt)
        {
            pointForm = new Point(evnt.X, evnt.Y);
        }

        private void ManagmentVisiblePanel(Panel currentPanel)
        {
            switch (currentPanel.Name)
            {
                case "panelVocabulary":
                    panelTrain.Visible = false;
                    panelVocabulary.Visible = true;
                    break;
                case "panelTrain":
                    panelTrain.Visible = true;
                    panelVocabulary.Visible = false;
                    break;
                default:
                    panelTrain.Visible = false;
                    panelVocabulary.Visible = false;
                    break;
            }


        }

        private void LoadDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in vocalobaryController.Load())
            {
                dataGridView1.Rows.Add(item.Name, item.Value);
            }
        }

        private void PrintText()
        {
            labelCount.Text = "Count word:" + (dataGridView1.Rows.Count - 1);
        }

        private void TotalResultTest()
        {
            InstallPanelVisible(true, false); 
            ClearData();
            MessageBox.Show($"Total: "+score);
        }

        private void InstallPanelVisible(bool buttonVisible, bool testVisible)
        {
            panelButton.Visible = buttonVisible;
            panelTest.Visible = testVisible;
        }

        private void TextWord()
        {
            label3.Text = _currentWord.Name;
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        #region move form elements
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            downOnTrey(e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            moveForm(e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            downOnTrey(e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            moveForm(e);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            downOnTrey(e);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            moveForm(e);
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            ManagmentVisiblePanel(panelVocabulary);
            panelTest.Visible = false;
            score = 0;
            label3.Text = "";
            textBox1.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            PrintText();
        }

        //TODO:create primery key for file
        private void button5_Click(object sender, EventArgs e)
        {
            List<WordModel> words = new List<WordModel>();
            for (var i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                words.Add(new WordModel(dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString()));
            }
            vocalobaryController.Save(words);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            PrintText();
        }

        private void ClearData()
        {
            label3.Text = "";
            textBox1.Clear();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void labelCount_ClientSizeChanged(object sender, EventArgs e)
        {
        }
        private void panelVocabulary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrainTrey_Click(object sender, EventArgs e)
        {
            ManagmentVisiblePanel(panelTrain);
            panelButton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             var setting = _settingController.GetDataSetting() ?? new Models.SettingModel(0);
            var countWord = setting.Count;
            if (countWord == 0)
            {
                MessageBox.Show("Настройки содержат 0 слов");
                return;
            }
            InstallPanelVisible(false, true);
            score = 0;
            var array = testController.GetWords(countWord); //int need from settings
            _queue = new StructureData.Queue<WordModel>(countWord);
            foreach (var item in array)
            { 
                _queue.Enqueue(item);
            }
            _currentWord = _queue.Dequeue();
            TextWord();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            TotalResultTest();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NextWord();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().ToLower().Equals(_currentWord.Value))
            {
                score++;
            }
            NextWord();
        }

        private void NextWord()
        {
            if (_queue.IsEmpty())
            {
                TotalResultTest();
                return;
            }
            _currentWord = _queue.Dequeue();
            TextWord();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.StartPosition = FormStartPosition.CenterParent;
            settings.ShowDialog();
        }
    }
}
