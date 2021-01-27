using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonCrawler.Items;

namespace DungeonCrawler
{
    public partial class Game : Form
    {
        public ItemBase selectedItem;

        public Game()
        {
            InitializeComponent();
        }

        public void SetEncounter(Encounter encounter)
        {
            ClearActions();
            encounter.StartEncounter(GameEngine.currentPlayer);
            encounterLabel.Text = encounter.title;
            encounterPrompt.Text = encounter.prompt;
            UpdatePlayerStats();
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

        public void RefreshActions(Encounter encounter)
        {
            ClearActions();
            foreach (ActionButton action in encounter.actions)
            {
                CustomButton button = new CustomButton();
                ActionEvent e = new ActionEvent(encounter, action);
                button.SetAction(e);
                actionLayout.Controls.Add(button);
            }
        }

        public void UpdateInventory()
        {
            Player player = GameEngine.currentPlayer;
            inventoryList.BeginUpdate();
            inventoryList.Items.Clear();

            foreach (ItemBase item in player.inventory)
            {
                string text = $"{item.quantity}x  -  {item.name}";
                inventoryList.Items.Add(text);
            }

            inventoryList.EndUpdate();
        }

        public void ClearActions()
        {
            actionLayout.Controls.Clear();
        }

        public void WriteText(string text)
        {
            encounterPrompt.Text = text;
        }

        public void AppendText(string text)
        {
            encounterPrompt.Text += text;
        }

        public void UpdatePlayerStats()
        {
            playerInfo.Text = $"Health: {GameEngine.currentPlayer.currentHealth}";
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

        private void invTabButton_Click(object sender, EventArgs e)
        {
            inventoryPanel.Enabled = true;
            inventoryPanel.Visible = true;
            actionsPanel.Enabled = false;
            actionsPanel.Visible = false;
        }

        private void actionTabButton_Click(object sender, EventArgs e)
        {
            inventoryPanel.Enabled = false;
            inventoryPanel.Visible = false;
            actionsPanel.Enabled = true;
            actionsPanel.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                moneyLabel.Text = "";
                return;
            }
            SetMoneyLabel();
        }

        private void SetMoneyLabel()
        {
            int v = GetSellQuantity();
            int goldCalc = v * selectedItem.value;
            moneyLabel.Text = $"{goldCalc} Coins";
        }

        private int GetSellQuantity()
        {
            return (int)Math.Round(sellQuantity.Value);
        }

        private void inventoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = inventoryList.SelectedIndex;
            if (selection < 0 || selection >= GameEngine.currentPlayer.inventory.Count)
            {
                selectedItem = null;
                return;
            }

            selectedItem = GameEngine.currentPlayer.inventory[selection];
            sellQuantity.Maximum = selectedItem.quantity;
            SetMoneyLabel();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (selectedItem == null) return;
            Player player = GameEngine.currentPlayer;

            int quantity = GetSellQuantity();
            bool canRemove = player.CanRemoveItem(selectedItem, quantity);
            if (!canRemove || quantity <= 0) return;

            //Sell Code:
            player.InvRemove(selectedItem, quantity);
            int goldCalc = quantity * selectedItem.value;
            player.InvAdd(new ItemBase("Gold Coin", goldCalc));
        }
    }
}
