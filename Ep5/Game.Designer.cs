namespace DungeonCrawler
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encounterLabel = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.encounterPrompt = new System.Windows.Forms.RichTextBox();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.actionLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.playerInfo = new System.Windows.Forms.TextBox();
            this.inventoryPanel = new System.Windows.Forms.Panel();
            this.inventoryList = new System.Windows.Forms.ListBox();
            this.actionTabButton = new System.Windows.Forms.Button();
            this.invTabButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.sellQuantity = new System.Windows.Forms.NumericUpDown();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // encounterLabel
            // 
            this.encounterLabel.AutoSize = true;
            this.encounterLabel.Font = new System.Drawing.Font("Lucida Console", 32F);
            this.encounterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encounterLabel.Location = new System.Drawing.Point(12, 9);
            this.encounterLabel.Name = "encounterLabel";
            this.encounterLabel.Size = new System.Drawing.Size(409, 43);
            this.encounterLabel.TabIndex = 0;
            this.encounterLabel.Text = "Encounter Label";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPanel.BackColor = System.Drawing.Color.Gray;
            this.backgroundPanel.Controls.Add(this.encounterPrompt);
            this.backgroundPanel.Location = new System.Drawing.Point(12, 55);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1091, 481);
            this.backgroundPanel.TabIndex = 1;
            // 
            // encounterPrompt
            // 
            this.encounterPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encounterPrompt.BackColor = System.Drawing.Color.Gray;
            this.encounterPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encounterPrompt.Cursor = System.Windows.Forms.Cursors.Default;
            this.encounterPrompt.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encounterPrompt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encounterPrompt.Location = new System.Drawing.Point(8, 3);
            this.encounterPrompt.Name = "encounterPrompt";
            this.encounterPrompt.ReadOnly = true;
            this.encounterPrompt.Size = new System.Drawing.Size(638, 475);
            this.encounterPrompt.TabIndex = 0;
            this.encounterPrompt.Text = "This is the encounter prompt. We can programatically edit this box";
            // 
            // actionsPanel
            // 
            this.actionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsPanel.BackColor = System.Drawing.Color.DarkGray;
            this.actionsPanel.Controls.Add(this.actionLayout);
            this.actionsPanel.Location = new System.Drawing.Point(665, 55);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(438, 481);
            this.actionsPanel.TabIndex = 0;
            // 
            // actionLayout
            // 
            this.actionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLayout.Location = new System.Drawing.Point(0, 0);
            this.actionLayout.Name = "actionLayout";
            this.actionLayout.Size = new System.Drawing.Size(438, 481);
            this.actionLayout.TabIndex = 0;
            // 
            // playerInfo
            // 
            this.playerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerInfo.Font = new System.Drawing.Font("Lucida Console", 16F);
            this.playerInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerInfo.Location = new System.Drawing.Point(820, 9);
            this.playerInfo.Multiline = true;
            this.playerInfo.Name = "playerInfo";
            this.playerInfo.Size = new System.Drawing.Size(283, 43);
            this.playerInfo.TabIndex = 2;
            this.playerInfo.Text = "Health: 10";
            this.playerInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryPanel.BackColor = System.Drawing.Color.Silver;
            this.inventoryPanel.Controls.Add(this.moneyLabel);
            this.inventoryPanel.Controls.Add(this.sellQuantity);
            this.inventoryPanel.Controls.Add(this.sellButton);
            this.inventoryPanel.Controls.Add(this.inventoryList);
            this.inventoryPanel.Enabled = false;
            this.inventoryPanel.Location = new System.Drawing.Point(665, 55);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(438, 481);
            this.inventoryPanel.TabIndex = 1;
            this.inventoryPanel.Visible = false;
            // 
            // inventoryList
            // 
            this.inventoryList.BackColor = System.Drawing.Color.DarkGray;
            this.inventoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inventoryList.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.inventoryList.FormattingEnabled = true;
            this.inventoryList.ItemHeight = 19;
            this.inventoryList.Location = new System.Drawing.Point(0, 63);
            this.inventoryList.Name = "inventoryList";
            this.inventoryList.Size = new System.Drawing.Size(438, 418);
            this.inventoryList.TabIndex = 0;
            this.inventoryList.SelectedIndexChanged += new System.EventHandler(this.inventoryList_SelectedIndexChanged);
            // 
            // actionTabButton
            // 
            this.actionTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionTabButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actionTabButton.Location = new System.Drawing.Point(665, 32);
            this.actionTabButton.Name = "actionTabButton";
            this.actionTabButton.Size = new System.Drawing.Size(64, 20);
            this.actionTabButton.TabIndex = 3;
            this.actionTabButton.Text = "Actions";
            this.actionTabButton.UseVisualStyleBackColor = true;
            this.actionTabButton.Click += new System.EventHandler(this.actionTabButton_Click);
            // 
            // invTabButton
            // 
            this.invTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invTabButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invTabButton.Location = new System.Drawing.Point(735, 32);
            this.invTabButton.Name = "invTabButton";
            this.invTabButton.Size = new System.Drawing.Size(79, 20);
            this.invTabButton.TabIndex = 4;
            this.invTabButton.Text = "Inventory";
            this.invTabButton.UseVisualStyleBackColor = true;
            this.invTabButton.Click += new System.EventHandler(this.invTabButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sellButton.Location = new System.Drawing.Point(3, 3);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(79, 28);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // sellQuantity
            // 
            this.sellQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sellQuantity.Location = new System.Drawing.Point(3, 37);
            this.sellQuantity.Name = "sellQuantity";
            this.sellQuantity.Size = new System.Drawing.Size(79, 18);
            this.sellQuantity.TabIndex = 6;
            this.sellQuantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.moneyLabel.Location = new System.Drawing.Point(88, 41);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(0, 14);
            this.moneyLabel.TabIndex = 7;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1115, 548);
            this.Controls.Add(this.invTabButton);
            this.Controls.Add(this.actionTabButton);
            this.Controls.Add(this.playerInfo);
            this.Controls.Add(this.encounterLabel);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.inventoryPanel);
            this.Controls.Add(this.backgroundPanel);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimumSize = new System.Drawing.Size(999, 587);
            this.Name = "Game";
            this.Text = "Ender\'s Dungeon 2";
            this.Load += new System.EventHandler(this.Game_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.inventoryPanel.ResumeLayout(false);
            this.inventoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encounterLabel;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.RichTextBox encounterPrompt;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.FlowLayoutPanel actionLayout;
        private System.Windows.Forms.TextBox playerInfo;
        private System.Windows.Forms.Panel inventoryPanel;
        private System.Windows.Forms.ListBox inventoryList;
        private System.Windows.Forms.Button actionTabButton;
        private System.Windows.Forms.Button invTabButton;
        private System.Windows.Forms.NumericUpDown sellQuantity;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label moneyLabel;
    }
}