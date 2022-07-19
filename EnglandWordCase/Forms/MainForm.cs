using EnglandWordCase.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EnglandWordCase
{
    public partial class MainForm : Form
    {
        private Point pointForm;

        public MainForm()
        {
            InitializeComponent();
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

        private void managmentVisiblePanel(Panel currentPanel)
        {
            List<Panel> panels = new List<Panel>();
            panels.Add(panelVocabulary);
            setVisiblePanel(panels, currentPanel);

        }

        private void setVisiblePanel(List<Panel> panels, Panel currentPanel)
        {
            foreach (var panel in panels)
            {
                currentPanel.Visible = panel.Name.Equals(currentPanel.Name) ? true : false;
            }
        
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
            managmentVisiblePanel(panelVocabulary);
        }

        private void panelVocabulary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
