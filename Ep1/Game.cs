﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public void SetEncounter(Encounter encounter)
        {
            encounterLabel.Text = encounter.title;
            encounterPrompt.Text = encounter.prompt;
            foreach (ActionButton action in encounter.actions)
            {
                CustomButton button = new CustomButton();
                ActionEvent e = new ActionEvent(encounter, action);
                button.SetAction(e);
                actionLayout.Controls.Add(button);

                //Button button = new Button();
                //button.Text = action.title;
                //ActionEvent e = new ActionEvent(encounter, action);
                //button.Click += e.DoAction;
                //actionLayout.Controls.Add(button);
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }


        public class ActionEvent
        {
            public Encounter encounter;
            public ActionButton action;

            public ActionEvent(Encounter encounter, ActionButton action)
            {
                this.encounter = encounter;
                this.action = action;
            }

            public void DoAction(object sender, EventArgs e)
            {
                action.DoClick(encounter);
            }
        }
    }
}
