﻿namespace Stratego
{
    partial class StrategoWin
    {
        private class BuffPanel : System.Windows.Forms.Panel
        {
            public BuffPanel()
            {
                this.DoubleBuffered = true;
                this.ResizeRedraw = true;
            }
        };

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
            this.components = new System.ComponentModel.Container();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.SidePanelOpenButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.backPanel = new Stratego.StrategoWin.BuffPanel();
            this.EndGamePanel = new System.Windows.Forms.Panel();
            this.victoryLabel = new System.Windows.Forms.Label();
            this.EndGameExitButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.xButton = new System.Windows.Forms.Button();
            this.concedeButton = new System.Windows.Forms.Button();
            this.returnToMenuButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.movableFlagCB = new System.Windows.Forms.CheckBox();
            this.movableBombCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AIDifficultyChanger = new System.Windows.Forms.DomainUpDown();
            this.PauseMenuExitButton = new System.Windows.Forms.Button();
            this.ExitMainButton = new System.Windows.Forms.Button();
            this.CampaignButton = new System.Windows.Forms.Button();
            this.NextTurnButton = new System.Windows.Forms.Button();
            this.SinglePlayerButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.loadSetUpButton = new System.Windows.Forms.Button();
            this.saveSetUpButton = new System.Windows.Forms.Button();
            this.donePlacingButton = new System.Windows.Forms.Button();
            this.removeCheckBox = new System.Windows.Forms.CheckBox();
            this.place12Button = new System.Windows.Forms.Button();
            this.place11Button = new System.Windows.Forms.Button();
            this.place10Button = new System.Windows.Forms.Button();
            this.place9Button = new System.Windows.Forms.Button();
            this.place8Button = new System.Windows.Forms.Button();
            this.place7Button = new System.Windows.Forms.Button();
            this.place6Button = new System.Windows.Forms.Button();
            this.place5Button = new System.Windows.Forms.Button();
            this.place4Button = new System.Windows.Forms.Button();
            this.place3Button = new System.Windows.Forms.Button();
            this.place2Button = new System.Windows.Forms.Button();
            this.place1Button = new System.Windows.Forms.Button();
            this.TitlePictureBox = new System.Windows.Forms.PictureBox();
            this.FireBox = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            this.EndGamePanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.optionsGroup.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startTimer
            // 
            this.startTimer.Enabled = true;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // SidePanelOpenButton
            // 
            this.SidePanelOpenButton.Location = new System.Drawing.Point(0, 0);
            this.SidePanelOpenButton.Name = "SidePanelOpenButton";
            this.SidePanelOpenButton.Size = new System.Drawing.Size(96, 23);
            this.SidePanelOpenButton.TabIndex = 1;
            this.SidePanelOpenButton.Text = "Open Side Panel";
            this.SidePanelOpenButton.UseVisualStyleBackColor = true;
            this.SidePanelOpenButton.Visible = false;
            this.SidePanelOpenButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SidePanelOpenButton_MouseClick);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Image = global::Stratego.Properties.Resources.StartButton;
            this.StartButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.StartButton.Location = new System.Drawing.Point(1274, 647);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(216, 91);
            this.StartButton.TabIndex = 2;
            this.StartButton.TabStop = false;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseDown);
            this.StartButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseUp);
            // 
            // backPanel
            // 
            this.backPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backPanel.BackColor = System.Drawing.Color.Transparent;
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.EndGamePanel);
            this.backPanel.Controls.Add(this.OptionsPanel);
            this.backPanel.Controls.Add(this.ExitMainButton);
            this.backPanel.Controls.Add(this.CampaignButton);
            this.backPanel.Controls.Add(this.NextTurnButton);
            this.backPanel.Controls.Add(this.SinglePlayerButton);
            this.backPanel.Controls.Add(this.LoadButton);
            this.backPanel.Controls.Add(this.SidePanel);
            this.backPanel.Controls.Add(this.StartButton);
            this.backPanel.Controls.Add(this.TitlePictureBox);
            this.backPanel.Controls.Add(this.FireBox);
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1612, 858);
            this.backPanel.TabIndex = 0;
            this.backPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backPanel_Paint);
            this.backPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backPanel_MouseClick);
            this.backPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.backPanel_PreviewKeyDown);
            // 
            // EndGamePanel
            // 
            this.EndGamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndGamePanel.BackColor = System.Drawing.Color.DarkGray;
            this.EndGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EndGamePanel.Controls.Add(this.victoryLabel);
            this.EndGamePanel.Controls.Add(this.EndGameExitButton);
            this.EndGamePanel.Controls.Add(this.PlayAgainButton);
            this.EndGamePanel.Enabled = false;
            this.EndGamePanel.Location = new System.Drawing.Point(582, 126);
            this.EndGamePanel.Name = "EndGamePanel";
            this.EndGamePanel.Size = new System.Drawing.Size(457, 351);
            this.EndGamePanel.TabIndex = 8;
            this.EndGamePanel.Visible = false;
            // 
            // victoryLabel
            // 
            this.victoryLabel.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryLabel.Location = new System.Drawing.Point(3, 29);
            this.victoryLabel.Name = "victoryLabel";
            this.victoryLabel.Size = new System.Drawing.Size(447, 250);
            this.victoryLabel.TabIndex = 3;
            this.victoryLabel.Text = "This text should never display.";
            this.victoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EndGameExitButton
            // 
            this.EndGameExitButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.EndGameExitButton.Location = new System.Drawing.Point(261, 283);
            this.EndGameExitButton.Name = "EndGameExitButton";
            this.EndGameExitButton.Size = new System.Drawing.Size(110, 48);
            this.EndGameExitButton.TabIndex = 2;
            this.EndGameExitButton.Text = "Exit";
            this.EndGameExitButton.UseVisualStyleBackColor = true;
            this.EndGameExitButton.Click += new System.EventHandler(this.PauseMenuExitButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.PlayAgainButton.Location = new System.Drawing.Point(38, 283);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(174, 48);
            this.PlayAgainButton.TabIndex = 1;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionsPanel.BackColor = System.Drawing.Color.DarkGray;
            this.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OptionsPanel.Controls.Add(this.xButton);
            this.OptionsPanel.Controls.Add(this.concedeButton);
            this.OptionsPanel.Controls.Add(this.returnToMenuButton);
            this.OptionsPanel.Controls.Add(this.SaveButton);
            this.OptionsPanel.Controls.Add(this.pauseLabel);
            this.OptionsPanel.Controls.Add(this.optionsGroup);
            this.OptionsPanel.Controls.Add(this.PauseMenuExitButton);
            this.OptionsPanel.Location = new System.Drawing.Point(539, 153);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(553, 552);
            this.OptionsPanel.TabIndex = 9;
            this.OptionsPanel.Visible = false;
            // 
            // xButton
            // 
            this.xButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButton.Location = new System.Drawing.Point(518, 3);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(28, 35);
            this.xButton.TabIndex = 19;
            this.xButton.Text = "x";
            this.xButton.UseVisualStyleBackColor = true;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // concedeButton
            // 
            this.concedeButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concedeButton.Location = new System.Drawing.Point(380, 393);
            this.concedeButton.Name = "concedeButton";
            this.concedeButton.Size = new System.Drawing.Size(136, 59);
            this.concedeButton.TabIndex = 18;
            this.concedeButton.Text = "Concede";
            this.concedeButton.UseVisualStyleBackColor = true;
            this.concedeButton.Click += new System.EventHandler(this.concedeButton_Click);
            // 
            // returnToMenuButton
            // 
            this.returnToMenuButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMenuButton.Location = new System.Drawing.Point(203, 407);
            this.returnToMenuButton.Name = "returnToMenuButton";
            this.returnToMenuButton.Size = new System.Drawing.Size(148, 113);
            this.returnToMenuButton.TabIndex = 17;
            this.returnToMenuButton.Text = "Quit to Main Menu";
            this.returnToMenuButton.UseVisualStyleBackColor = true;
            this.returnToMenuButton.Click += new System.EventHandler(this.returnToMenuButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(35, 477);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 59);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save Game";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLabel.Location = new System.Drawing.Point(172, 12);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(274, 80);
            this.pauseLabel.TabIndex = 16;
            this.pauseLabel.Text = "PAUSED";
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.movableFlagCB);
            this.optionsGroup.Controls.Add(this.movableBombCB);
            this.optionsGroup.Controls.Add(this.label1);
            this.optionsGroup.Controls.Add(this.AIDifficultyChanger);
            this.optionsGroup.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsGroup.Location = new System.Drawing.Point(35, 94);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(481, 270);
            this.optionsGroup.TabIndex = 15;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // movableFlagCB
            // 
            this.movableFlagCB.AutoSize = true;
            this.movableFlagCB.Enabled = false;
            this.movableFlagCB.Location = new System.Drawing.Point(33, 102);
            this.movableFlagCB.Name = "movableFlagCB";
            this.movableFlagCB.Size = new System.Drawing.Size(221, 41);
            this.movableFlagCB.TabIndex = 3;
            this.movableFlagCB.Text = "Movable Flags";
            this.movableFlagCB.UseVisualStyleBackColor = true;
            this.movableFlagCB.CheckedChanged += new System.EventHandler(this.movableFlagCB_CheckedChanged);
            // 
            // movableBombCB
            // 
            this.movableBombCB.AutoSize = true;
            this.movableBombCB.Enabled = false;
            this.movableBombCB.Location = new System.Drawing.Point(33, 47);
            this.movableBombCB.Name = "movableBombCB";
            this.movableBombCB.Size = new System.Drawing.Size(242, 41);
            this.movableBombCB.TabIndex = 2;
            this.movableBombCB.Text = "Movable Bombs";
            this.movableBombCB.UseVisualStyleBackColor = true;
            this.movableBombCB.CheckedChanged += new System.EventHandler(this.movableBombCB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "AI Difficulty:";
            // 
            // AIDifficultyChanger
            // 
            this.AIDifficultyChanger.Items.Add("5");
            this.AIDifficultyChanger.Items.Add("4");
            this.AIDifficultyChanger.Items.Add("3");
            this.AIDifficultyChanger.Items.Add("2");
            this.AIDifficultyChanger.Items.Add("1");
            this.AIDifficultyChanger.Items.Add("0");
            this.AIDifficultyChanger.Location = new System.Drawing.Point(410, 201);
            this.AIDifficultyChanger.Name = "AIDifficultyChanger";
            this.AIDifficultyChanger.ReadOnly = true;
            this.AIDifficultyChanger.Size = new System.Drawing.Size(39, 43);
            this.AIDifficultyChanger.TabIndex = 0;
            this.AIDifficultyChanger.Text = "5";
            this.AIDifficultyChanger.SelectedItemChanged += new System.EventHandler(this.AIDifficultyChanger_SelectedItemChanged);
            // 
            // PauseMenuExitButton
            // 
            this.PauseMenuExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PauseMenuExitButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseMenuExitButton.Location = new System.Drawing.Point(35, 395);
            this.PauseMenuExitButton.Name = "PauseMenuExitButton";
            this.PauseMenuExitButton.Size = new System.Drawing.Size(145, 73);
            this.PauseMenuExitButton.TabIndex = 5;
            this.PauseMenuExitButton.Text = "Close Stratego";
            this.PauseMenuExitButton.UseVisualStyleBackColor = true;
            this.PauseMenuExitButton.VisibleChanged += new System.EventHandler(this.PauseMenuExitButton_VisibleChanged);
            this.PauseMenuExitButton.Click += new System.EventHandler(this.PauseMenuExitButton_Click);
            // 
            // ExitMainButton
            // 
            this.ExitMainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitMainButton.Enabled = false;
            this.ExitMainButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitMainButton.Location = new System.Drawing.Point(1324, 548);
            this.ExitMainButton.Name = "ExitMainButton";
            this.ExitMainButton.Size = new System.Drawing.Size(162, 77);
            this.ExitMainButton.TabIndex = 11;
            this.ExitMainButton.Text = "Close Stratego";
            this.ExitMainButton.UseVisualStyleBackColor = true;
            this.ExitMainButton.Visible = false;
            this.ExitMainButton.Click += new System.EventHandler(this.PauseMenuExitButton_Click);
            // 
            // CampaignButton
            // 
            this.CampaignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignButton.Enabled = false;
            this.CampaignButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.CampaignButton.Location = new System.Drawing.Point(1134, 470);
            this.CampaignButton.Name = "CampaignButton";
            this.CampaignButton.Size = new System.Drawing.Size(162, 59);
            this.CampaignButton.TabIndex = 10;
            this.CampaignButton.Text = "Campaign";
            this.CampaignButton.UseVisualStyleBackColor = true;
            this.CampaignButton.Visible = false;
            this.CampaignButton.Click += new System.EventHandler(this.CampaignButton_Click);
            // 
            // NextTurnButton
            // 
            this.NextTurnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextTurnButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextTurnButton.Location = new System.Drawing.Point(745, 423);
            this.NextTurnButton.Name = "NextTurnButton";
            this.NextTurnButton.Size = new System.Drawing.Size(133, 75);
            this.NextTurnButton.TabIndex = 2;
            this.NextTurnButton.Text = "Player 1\'s Turn";
            this.NextTurnButton.UseVisualStyleBackColor = true;
            this.NextTurnButton.Visible = false;
            this.NextTurnButton.Click += new System.EventHandler(this.NextTurnButton_Click);
            // 
            // SinglePlayerButton
            // 
            this.SinglePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SinglePlayerButton.Enabled = false;
            this.SinglePlayerButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePlayerButton.Location = new System.Drawing.Point(1135, 548);
            this.SinglePlayerButton.Name = "SinglePlayerButton";
            this.SinglePlayerButton.Size = new System.Drawing.Size(162, 77);
            this.SinglePlayerButton.TabIndex = 7;
            this.SinglePlayerButton.Text = "New Single-Player";
            this.SinglePlayerButton.UseVisualStyleBackColor = true;
            this.SinglePlayerButton.Visible = false;
            this.SinglePlayerButton.Click += new System.EventHandler(this.SinglePlayerButton_click);
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Enabled = false;
            this.LoadButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(1324, 470);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(162, 59);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load Game";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Visible = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DimGray;
            this.SidePanel.Controls.Add(this.loadSetUpButton);
            this.SidePanel.Controls.Add(this.saveSetUpButton);
            this.SidePanel.Controls.Add(this.donePlacingButton);
            this.SidePanel.Controls.Add(this.removeCheckBox);
            this.SidePanel.Controls.Add(this.place12Button);
            this.SidePanel.Controls.Add(this.place11Button);
            this.SidePanel.Controls.Add(this.place10Button);
            this.SidePanel.Controls.Add(this.place9Button);
            this.SidePanel.Controls.Add(this.place8Button);
            this.SidePanel.Controls.Add(this.place7Button);
            this.SidePanel.Controls.Add(this.place6Button);
            this.SidePanel.Controls.Add(this.place5Button);
            this.SidePanel.Controls.Add(this.place4Button);
            this.SidePanel.Controls.Add(this.place3Button);
            this.SidePanel.Controls.Add(this.place2Button);
            this.SidePanel.Controls.Add(this.place1Button);
            this.SidePanel.Location = new System.Drawing.Point(0, 29);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(107, 664);
            this.SidePanel.TabIndex = 4;
            this.SidePanel.Visible = false;
            // 
            // loadSetUpButton
            // 
            this.loadSetUpButton.Location = new System.Drawing.Point(5, 598);
            this.loadSetUpButton.Name = "loadSetUpButton";
            this.loadSetUpButton.Size = new System.Drawing.Size(96, 36);
            this.loadSetUpButton.TabIndex = 16;
            this.loadSetUpButton.Text = "Load Set Up";
            this.loadSetUpButton.UseVisualStyleBackColor = true;
            this.loadSetUpButton.Click += new System.EventHandler(this.loadSetUpButton_Click);
            // 
            // saveSetUpButton
            // 
            this.saveSetUpButton.Location = new System.Drawing.Point(5, 558);
            this.saveSetUpButton.Name = "saveSetUpButton";
            this.saveSetUpButton.Size = new System.Drawing.Size(96, 36);
            this.saveSetUpButton.TabIndex = 15;
            this.saveSetUpButton.Text = "Save Set Up";
            this.saveSetUpButton.UseVisualStyleBackColor = true;
            this.saveSetUpButton.Click += new System.EventHandler(this.saveSetUpButton_Click);
            // 
            // donePlacingButton
            // 
            this.donePlacingButton.Enabled = false;
            this.donePlacingButton.Location = new System.Drawing.Point(5, 3);
            this.donePlacingButton.Name = "donePlacingButton";
            this.donePlacingButton.Size = new System.Drawing.Size(96, 46);
            this.donePlacingButton.TabIndex = 13;
            this.donePlacingButton.Text = "Done Placing!";
            this.donePlacingButton.UseVisualStyleBackColor = true;
            this.donePlacingButton.Click += new System.EventHandler(this.donePlacingButton_click);
            // 
            // removeCheckBox
            // 
            this.removeCheckBox.AutoSize = true;
            this.removeCheckBox.Location = new System.Drawing.Point(12, 638);
            this.removeCheckBox.Name = "removeCheckBox";
            this.removeCheckBox.Size = new System.Drawing.Size(82, 21);
            this.removeCheckBox.TabIndex = 12;
            this.removeCheckBox.Text = "Remove";
            this.removeCheckBox.UseVisualStyleBackColor = true;
            this.removeCheckBox.CheckedChanged += new System.EventHandler(this.removeCheckBox_CheckedChanged);
            // 
            // place12Button
            // 
            this.place12Button.Location = new System.Drawing.Point(5, 517);
            this.place12Button.Name = "place12Button";
            this.place12Button.Size = new System.Drawing.Size(96, 36);
            this.place12Button.TabIndex = 11;
            this.place12Button.Tag = "Flag";
            this.place12Button.Text = "Flag";
            this.place12Button.UseVisualStyleBackColor = true;
            // 
            // place11Button
            // 
            this.place11Button.Location = new System.Drawing.Point(5, 475);
            this.place11Button.Name = "place11Button";
            this.place11Button.Size = new System.Drawing.Size(96, 36);
            this.place11Button.TabIndex = 10;
            this.place11Button.Tag = "Bomb";
            this.place11Button.Text = "Bomb";
            this.place11Button.UseVisualStyleBackColor = true;
            // 
            // place10Button
            // 
            this.place10Button.Location = new System.Drawing.Point(5, 433);
            this.place10Button.Name = "place10Button";
            this.place10Button.Size = new System.Drawing.Size(96, 36);
            this.place10Button.TabIndex = 9;
            this.place10Button.Tag = "Spy";
            this.place10Button.Text = "Spy";
            this.place10Button.UseVisualStyleBackColor = true;
            // 
            // place9Button
            // 
            this.place9Button.Location = new System.Drawing.Point(5, 391);
            this.place9Button.Name = "place9Button";
            this.place9Button.Size = new System.Drawing.Size(96, 36);
            this.place9Button.TabIndex = 8;
            this.place9Button.Tag = "Scout";
            this.place9Button.Text = "9";
            this.place9Button.UseVisualStyleBackColor = true;
            // 
            // place8Button
            // 
            this.place8Button.Location = new System.Drawing.Point(5, 349);
            this.place8Button.Name = "place8Button";
            this.place8Button.Size = new System.Drawing.Size(96, 36);
            this.place8Button.TabIndex = 7;
            this.place8Button.Tag = "Miner";
            this.place8Button.Text = "8";
            this.place8Button.UseVisualStyleBackColor = true;
            // 
            // place7Button
            // 
            this.place7Button.Location = new System.Drawing.Point(5, 307);
            this.place7Button.Name = "place7Button";
            this.place7Button.Size = new System.Drawing.Size(96, 36);
            this.place7Button.TabIndex = 6;
            this.place7Button.Tag = "Sergeant";
            this.place7Button.Text = "7";
            this.place7Button.UseVisualStyleBackColor = true;
            // 
            // place6Button
            // 
            this.place6Button.Location = new System.Drawing.Point(5, 265);
            this.place6Button.Name = "place6Button";
            this.place6Button.Size = new System.Drawing.Size(96, 36);
            this.place6Button.TabIndex = 5;
            this.place6Button.Tag = "Lieutenant";
            this.place6Button.Text = "6";
            this.place6Button.UseVisualStyleBackColor = true;
            // 
            // place5Button
            // 
            this.place5Button.Location = new System.Drawing.Point(5, 223);
            this.place5Button.Name = "place5Button";
            this.place5Button.Size = new System.Drawing.Size(96, 36);
            this.place5Button.TabIndex = 4;
            this.place5Button.Tag = "Captain";
            this.place5Button.Text = "5";
            this.place5Button.UseVisualStyleBackColor = true;
            // 
            // place4Button
            // 
            this.place4Button.Location = new System.Drawing.Point(5, 181);
            this.place4Button.Name = "place4Button";
            this.place4Button.Size = new System.Drawing.Size(96, 36);
            this.place4Button.TabIndex = 3;
            this.place4Button.Tag = "Major";
            this.place4Button.Text = "4";
            this.place4Button.UseVisualStyleBackColor = true;
            // 
            // place3Button
            // 
            this.place3Button.Location = new System.Drawing.Point(5, 139);
            this.place3Button.Name = "place3Button";
            this.place3Button.Size = new System.Drawing.Size(96, 36);
            this.place3Button.TabIndex = 2;
            this.place3Button.Tag = "Colonel";
            this.place3Button.Text = "3";
            this.place3Button.UseVisualStyleBackColor = true;
            // 
            // place2Button
            // 
            this.place2Button.Location = new System.Drawing.Point(5, 97);
            this.place2Button.Name = "place2Button";
            this.place2Button.Size = new System.Drawing.Size(96, 36);
            this.place2Button.TabIndex = 1;
            this.place2Button.Tag = "General";
            this.place2Button.Text = "2";
            this.place2Button.UseVisualStyleBackColor = true;
            // 
            // place1Button
            // 
            this.place1Button.BackColor = System.Drawing.Color.DimGray;
            this.place1Button.Location = new System.Drawing.Point(5, 55);
            this.place1Button.Name = "place1Button";
            this.place1Button.Size = new System.Drawing.Size(96, 36);
            this.place1Button.TabIndex = 0;
            this.place1Button.Tag = "Marshall";
            this.place1Button.Text = "1";
            this.place1Button.UseVisualStyleBackColor = true;
            // 
            // TitlePictureBox
            // 
            this.TitlePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TitlePictureBox.BackgroundImage = global::Stratego.Properties.Resources.Stratego_logo;
            this.TitlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitlePictureBox.Location = new System.Drawing.Point(1169, 342);
            this.TitlePictureBox.Name = "TitlePictureBox";
            this.TitlePictureBox.Size = new System.Drawing.Size(321, 95);
            this.TitlePictureBox.TabIndex = 1;
            this.TitlePictureBox.TabStop = false;
            this.TitlePictureBox.Visible = false;
            this.TitlePictureBox.WaitOnLoad = true;
            // 
            // FireBox
            // 
            this.FireBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FireBox.BackColor = System.Drawing.Color.Transparent;
            this.FireBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FireBox.Image = global::Stratego.Properties.Resources.AniFire;
            this.FireBox.Location = new System.Drawing.Point(-4, -2);
            this.FireBox.Margin = new System.Windows.Forms.Padding(0);
            this.FireBox.Name = "FireBox";
            this.FireBox.Size = new System.Drawing.Size(1622, 858);
            this.FireBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireBox.TabIndex = 3;
            this.FireBox.TabStop = false;
            this.FireBox.Visible = false;
            // 
            // StrategoWin
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1612, 858);
            this.Controls.Add(this.SidePanelOpenButton);
            this.Controls.Add(this.backPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StrategoWin";
            this.Text = "Stratego";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.backPanel.ResumeLayout(false);
            this.EndGamePanel.ResumeLayout(false);
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.PictureBox FireBox;
        private System.Windows.Forms.Button StartButton;
        private BuffPanel backPanel;
        public System.Windows.Forms.PictureBox TitlePictureBox;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button place1Button;
        private System.Windows.Forms.Button SidePanelOpenButton;
        private System.Windows.Forms.Button place12Button;
        private System.Windows.Forms.Button place11Button;
        private System.Windows.Forms.Button place10Button;
        private System.Windows.Forms.Button place9Button;
        private System.Windows.Forms.Button place8Button;
        private System.Windows.Forms.Button place7Button;
        private System.Windows.Forms.Button place6Button;
        private System.Windows.Forms.Button place5Button;
        private System.Windows.Forms.Button place4Button;
        private System.Windows.Forms.Button place3Button;
        private System.Windows.Forms.Button place2Button;
        private System.Windows.Forms.Button PauseMenuExitButton;
        private System.Windows.Forms.CheckBox removeCheckBox;
        private System.Windows.Forms.Button donePlacingButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SinglePlayerButton;
        private System.Windows.Forms.Panel EndGamePanel;
        private System.Windows.Forms.Button EndGameExitButton;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Button loadSetUpButton;
        private System.Windows.Forms.Button saveSetUpButton;
        private System.Windows.Forms.Button NextTurnButton;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.Button concedeButton;
        private System.Windows.Forms.Button returnToMenuButton;
        private System.Windows.Forms.DomainUpDown AIDifficultyChanger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label victoryLabel;
        private System.Windows.Forms.CheckBox movableFlagCB;
        private System.Windows.Forms.CheckBox movableBombCB;
        private System.Windows.Forms.Button CampaignButton;
        private System.Windows.Forms.Button ExitMainButton;
    }
}

