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
            this.backgroundPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
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
            this.playerInfo.Location = new System.Drawing.Point(665, 9);
            this.playerInfo.Multiline = true;
            this.playerInfo.Name = "playerInfo";
            this.playerInfo.Size = new System.Drawing.Size(438, 43);
            this.playerInfo.TabIndex = 2;
            this.playerInfo.Text = "Health: 10";
            this.playerInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1115, 548);
            this.Controls.Add(this.playerInfo);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.encounterLabel);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimumSize = new System.Drawing.Size(999, 587);
            this.Name = "Game";
            this.Text = "Ender\'s Dungeon 2";
            this.Load += new System.EventHandler(this.Game_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
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
    }
}