using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    public partial class Form1 : Form
    {
        private List<Player> players;

        public Form1()
        {
            InitializeComponent();
            players = new List<Player>();
            players.Add(new Player("Bob", "Alpha"));
            players.Add(new Player("Andy", "Beta"));
            players.Add(new Player("Joe", "Alpha"));
            players.Add(new Player("Peter", "Alpha"));
            players.Add(new Player("Fred", "Beta"));
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            foreach(Player p in players)
            {
                MessageBox.Show(p.Name + ", " + p.Team);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            players.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = tbItem.Text;

            if(name.Length == 0)
            {
                MessageBox.Show("Enter a name");
                return;
            }

            Player toRemove = players.Find(p => p.Name == name);

            if (toRemove == null)
            {
                MessageBox.Show("Player not found in list");
                return;
            }

            players.Remove(toRemove);
            tbItem.Clear();


        }
    }
}
