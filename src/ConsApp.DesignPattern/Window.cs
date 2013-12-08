using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StructuralPatterns.Flyweight;

namespace ConsApp.DesignPattern
{
    class Client
    {
        // Shared state - the images
        private static FlyweightFactory album = new FlyweightFactory();
        // Unshared state - the groups
        private static Dictionary<string, List<string>> allGroups = new Dictionary<string, List<string>>();

        public Client() { }

        public void LoadGroups()
        {
            var myGroups = new[] 
            {
                new {Name = "Garden", Members = new [] {"pot.jpg", "spring.jpg", "barbeque.jpg", "flowers.jpg"}},
                new {Name = "Italy", Members = new [] {"cappucino.jpg","pasta.jpg","restaurant.jpg", "church.jpg"}},
                new {Name = "Food", Members = new [] {"pasta.jpg", "veggies.jpg", "barbeque.jpg","cappucino.jpg","lemonade.jpg" }},
                new {Name = "Friends", Members = new [] {"restaurant.jpg", "dinner.jpg"}}
            };
            // Load the Flyweights, saving on shared intrinsic state
            foreach (var g in myGroups)
            {
                // implicit typing
                allGroups.Add(g.Name, new List<string>());
                foreach (string filename in g.Members)
                {
                    allGroups[g.Name].Add(filename);
                    album[filename].Load(filename);
                }
            }
        }

        public void DisplayGroups(Object source, PaintEventArgs e)
        {
            // Display the Flyweights, passing the unshared state
            int row = 0;
            foreach (string g in allGroups.Keys)
            {
                int col = 0;
                e.Graphics.DrawString(g,
                        new Font("Arial", 16),
                        new SolidBrush(Color.Black),
                        new PointF(0, row * 130 + 10));

                foreach (string filename in allGroups[g])
                {
                    album[filename].Display(e, row, col);
                    col++;
                }
                row++;
            }
        }

    }

    class Window : Form
    {
        public Window()
        {
            this.Height = 600;
            this.Width = 600;
            this.Text = "Picture Groups";
            Client client = new Client();
            client.LoadGroups();
            this.Paint += new PaintEventHandler(client.DisplayGroups);
        }
    }
}