using System;
using _1.Containers;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _2.CombatForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Character = new Character()
            {
                SavingThrows = new Dictionary<string, Stat>()
                {
                    {"STRENGTH", new Stat() {Name = "Strength", Value = 10 } },
                    {"DEXTERITY", new Stat() {Name = "Dexterity", Value = 10 } },
                    {"CONSTITUTION", new Stat() {Name = "Constitution", Value = 10 } },
                    {"INTELLIGENCE", new Stat() {Name = "Intelligence", Value = 10 } },
                    {"WISDOM", new Stat() {Name = "Wisdom", Value = 10 } },
                    {"CHARISMA", new Stat() {Name = "Charisma", Value = 10 } }
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var stat in Character.SavingThrows)
                textBox1.Text += stat.Value.ToString() + Environment.NewLine;
        }        
    }
}
