﻿namespace RTCV.UI
{
    partial class UI_CoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_CoreForm));
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.pnCrashProtection = new System.Windows.Forms.Panel();
            this.btnGpJumpNow = new System.Windows.Forms.Button();
            this.btnGpJumpBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUseGameProtection = new System.Windows.Forms.CheckBox();
            this.btnTestSubform = new System.Windows.Forms.Button();
            this.pnAutoKillSwitch = new System.Windows.Forms.Panel();
            this.cbUseAutoKillSwitch = new System.Windows.Forms.CheckBox();
            this.pbAutoKillSwitchTimeout = new System.Windows.Forms.ProgressBar();
            this.lbAks = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnEngineConfig = new System.Windows.Forms.Button();
            this.btnEasyMode = new System.Windows.Forms.Button();
            this.btnStockpilePlayer = new System.Windows.Forms.Button();
            this.btnGlitchHarvester = new System.Windows.Forms.Button();
            this.btnManualBlast = new System.Windows.Forms.Button();
            this.btnAutoCorrupt = new System.Windows.Forms.Button();
            this.pnTopBar.SuspendLayout();
            this.pnCrashProtection.SuspendLayout();
            this.pnAutoKillSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopBar
            // 
            this.pnTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnTopBar.Controls.Add(this.pnCrashProtection);
            this.pnTopBar.Controls.Add(this.btnTestSubform);
            this.pnTopBar.Controls.Add(this.pnAutoKillSwitch);
            this.pnTopBar.Controls.Add(this.btnSettings);
            this.pnTopBar.Controls.Add(this.btnLogo);
            this.pnTopBar.Controls.Add(this.btnEngineConfig);
            this.pnTopBar.Controls.Add(this.btnEasyMode);
            this.pnTopBar.Controls.Add(this.btnStockpilePlayer);
            this.pnTopBar.Controls.Add(this.btnGlitchHarvester);
            this.pnTopBar.Controls.Add(this.btnManualBlast);
            this.pnTopBar.Controls.Add(this.btnAutoCorrupt);
            this.pnTopBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnTopBar.Name = "pnTopBar";
            this.pnTopBar.Size = new System.Drawing.Size(150, 511);
            this.pnTopBar.TabIndex = 7;
            this.pnTopBar.Tag = "color:darker";
            // 
            // pnCrashProtection
            // 
            this.pnCrashProtection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnCrashProtection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnCrashProtection.Controls.Add(this.btnGpJumpNow);
            this.pnCrashProtection.Controls.Add(this.btnGpJumpBack);
            this.pnCrashProtection.Controls.Add(this.label2);
            this.pnCrashProtection.Controls.Add(this.cbUseGameProtection);
            this.pnCrashProtection.Location = new System.Drawing.Point(0, 364);
            this.pnCrashProtection.Name = "pnCrashProtection";
            this.pnCrashProtection.Size = new System.Drawing.Size(150, 60);
            this.pnCrashProtection.TabIndex = 128;
            this.pnCrashProtection.Tag = "color:darker";
            // 
            // btnGpJumpNow
            // 
            this.btnGpJumpNow.BackColor = System.Drawing.Color.Transparent;
            this.btnGpJumpNow.FlatAppearance.BorderSize = 0;
            this.btnGpJumpNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGpJumpNow.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnGpJumpNow.ForeColor = System.Drawing.Color.White;
            this.btnGpJumpNow.Location = new System.Drawing.Point(77, 30);
            this.btnGpJumpNow.Name = "btnGpJumpNow";
            this.btnGpJumpNow.Size = new System.Drawing.Size(59, 23);
            this.btnGpJumpNow.TabIndex = 117;
            this.btnGpJumpNow.TabStop = false;
            this.btnGpJumpNow.Tag = "color:darker";
            this.btnGpJumpNow.Text = "Now ⏩";
            this.btnGpJumpNow.UseVisualStyleBackColor = false;
            // 
            // btnGpJumpBack
            // 
            this.btnGpJumpBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGpJumpBack.FlatAppearance.BorderSize = 0;
            this.btnGpJumpBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGpJumpBack.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnGpJumpBack.ForeColor = System.Drawing.Color.White;
            this.btnGpJumpBack.Location = new System.Drawing.Point(12, 30);
            this.btnGpJumpBack.Name = "btnGpJumpBack";
            this.btnGpJumpBack.Size = new System.Drawing.Size(59, 23);
            this.btnGpJumpBack.TabIndex = 116;
            this.btnGpJumpBack.TabStop = false;
            this.btnGpJumpBack.Tag = "color:darker";
            this.btnGpJumpBack.Text = "⏪ Back";
            this.btnGpJumpBack.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 111;
            this.label2.Text = "Game Protection";
            // 
            // cbUseGameProtection
            // 
            this.cbUseGameProtection.AutoSize = true;
            this.cbUseGameProtection.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbUseGameProtection.ForeColor = System.Drawing.Color.White;
            this.cbUseGameProtection.Location = new System.Drawing.Point(10, 11);
            this.cbUseGameProtection.Name = "cbUseGameProtection";
            this.cbUseGameProtection.Size = new System.Drawing.Size(15, 14);
            this.cbUseGameProtection.TabIndex = 76;
            this.cbUseGameProtection.UseVisualStyleBackColor = true;
            // 
            // btnTestSubform
            // 
            this.btnTestSubform.BackColor = System.Drawing.Color.Transparent;
            this.btnTestSubform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnTestSubform.FlatAppearance.BorderSize = 0;
            this.btnTestSubform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestSubform.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnTestSubform.ForeColor = System.Drawing.Color.White;
            this.btnTestSubform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestSubform.Location = new System.Drawing.Point(0, 311);
            this.btnTestSubform.Name = "btnTestSubform";
            this.btnTestSubform.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnTestSubform.Size = new System.Drawing.Size(150, 33);
            this.btnTestSubform.TabIndex = 9;
            this.btnTestSubform.TabStop = false;
            this.btnTestSubform.Tag = "color:darker";
            this.btnTestSubform.Text = "Test Subform";
            this.btnTestSubform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestSubform.UseVisualStyleBackColor = false;
            this.btnTestSubform.Visible = false;
            this.btnTestSubform.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnAutoKillSwitch
            // 
            this.pnAutoKillSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnAutoKillSwitch.BackColor = System.Drawing.Color.Transparent;
            this.pnAutoKillSwitch.Controls.Add(this.cbUseAutoKillSwitch);
            this.pnAutoKillSwitch.Controls.Add(this.pbAutoKillSwitchTimeout);
            this.pnAutoKillSwitch.Controls.Add(this.lbAks);
            this.pnAutoKillSwitch.Location = new System.Drawing.Point(0, 429);
            this.pnAutoKillSwitch.Name = "pnAutoKillSwitch";
            this.pnAutoKillSwitch.Size = new System.Drawing.Size(150, 34);
            this.pnAutoKillSwitch.TabIndex = 127;
            this.pnAutoKillSwitch.Tag = "color:darker";
            this.pnAutoKillSwitch.MouseEnter += new System.EventHandler(this.pnAutoKillSwitch_MouseHover);
            this.pnAutoKillSwitch.MouseLeave += new System.EventHandler(this.pnAutoKillSwitch_MouseLeave);
            this.pnAutoKillSwitch.MouseHover += new System.EventHandler(this.pnAutoKillSwitch_MouseHover);
            // 
            // cbUseAutoKillSwitch
            // 
            this.cbUseAutoKillSwitch.AutoSize = true;
            this.cbUseAutoKillSwitch.Checked = true;
            this.cbUseAutoKillSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseAutoKillSwitch.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbUseAutoKillSwitch.ForeColor = System.Drawing.Color.White;
            this.cbUseAutoKillSwitch.Location = new System.Drawing.Point(10, 8);
            this.cbUseAutoKillSwitch.Name = "cbUseAutoKillSwitch";
            this.cbUseAutoKillSwitch.Size = new System.Drawing.Size(15, 14);
            this.cbUseAutoKillSwitch.TabIndex = 120;
            this.cbUseAutoKillSwitch.UseVisualStyleBackColor = true;
            this.cbUseAutoKillSwitch.MouseEnter += new System.EventHandler(this.pnAutoKillSwitch_MouseHover);
            this.cbUseAutoKillSwitch.MouseLeave += new System.EventHandler(this.pnAutoKillSwitch_MouseLeave);
            this.cbUseAutoKillSwitch.MouseHover += new System.EventHandler(this.pnAutoKillSwitch_MouseHover);
            // 
            // pbAutoKillSwitchTimeout
            // 
            this.pbAutoKillSwitchTimeout.Location = new System.Drawing.Point(10, 24);
            this.pbAutoKillSwitchTimeout.MarqueeAnimationSpeed = 1;
            this.pbAutoKillSwitchTimeout.Maximum = 13;
            this.pbAutoKillSwitchTimeout.Name = "pbAutoKillSwitchTimeout";
            this.pbAutoKillSwitchTimeout.Size = new System.Drawing.Size(123, 4);
            this.pbAutoKillSwitchTimeout.Step = 1;
            this.pbAutoKillSwitchTimeout.TabIndex = 119;
            this.pbAutoKillSwitchTimeout.Tag = "17";
            this.pbAutoKillSwitchTimeout.Value = 13;
            this.pbAutoKillSwitchTimeout.MouseEnter += new System.EventHandler(this.pnAutoKillSwitch_MouseHover);
            this.pbAutoKillSwitchTimeout.MouseLeave += new System.EventHandler(this.pnAutoKillSwitch_MouseLeave);
            this.pbAutoKillSwitchTimeout.MouseHover += new System.EventHandler(this.pnAutoKillSwitch_MouseHover);
            // 
            // lbAks
            // 
            this.lbAks.AutoSize = true;
            this.lbAks.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbAks.ForeColor = System.Drawing.Color.White;
            this.lbAks.Location = new System.Drawing.Point(28, 5);
            this.lbAks.Name = "lbAks";
            this.lbAks.Size = new System.Drawing.Size(93, 17);
            this.lbAks.TabIndex = 111;
            this.lbAks.Text = "Auto-KillSwitch";
            this.lbAks.MouseEnter += new System.EventHandler(this.pnAutoKillSwitch_MouseHover);
            this.lbAks.MouseLeave += new System.EventHandler(this.pnAutoKillSwitch_MouseLeave);
            this.lbAks.MouseHover += new System.EventHandler(this.pnAutoKillSwitch_MouseHover);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 477);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(150, 34);
            this.btnSettings.TabIndex = 126;
            this.btnSettings.TabStop = false;
            this.btnSettings.Tag = "color:darker";
            this.btnSettings.Text = " Settings and tools";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogo.Size = new System.Drawing.Size(150, 53);
            this.btnLogo.TabIndex = 125;
            this.btnLogo.TabStop = false;
            this.btnLogo.Tag = "color:darker";
            this.btnLogo.Text = "RTCV 0.00";
            this.btnLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // btnEngineConfig
            // 
            this.btnEngineConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnEngineConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEngineConfig.FlatAppearance.BorderSize = 0;
            this.btnEngineConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngineConfig.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEngineConfig.ForeColor = System.Drawing.Color.White;
            this.btnEngineConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnEngineConfig.Image")));
            this.btnEngineConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEngineConfig.Location = new System.Drawing.Point(0, 94);
            this.btnEngineConfig.Name = "btnEngineConfig";
            this.btnEngineConfig.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEngineConfig.Size = new System.Drawing.Size(150, 34);
            this.btnEngineConfig.TabIndex = 124;
            this.btnEngineConfig.TabStop = false;
            this.btnEngineConfig.Tag = "color:darker";
            this.btnEngineConfig.Text = " Engine Config";
            this.btnEngineConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEngineConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEngineConfig.UseVisualStyleBackColor = false;
            this.btnEngineConfig.Click += new System.EventHandler(this.btnEngineConfig_Click);
            // 
            // btnEasyMode
            // 
            this.btnEasyMode.BackColor = System.Drawing.Color.Transparent;
            this.btnEasyMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEasyMode.FlatAppearance.BorderSize = 0;
            this.btnEasyMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasyMode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEasyMode.ForeColor = System.Drawing.Color.White;
            this.btnEasyMode.Image = ((System.Drawing.Image)(resources.GetObject("btnEasyMode.Image")));
            this.btnEasyMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEasyMode.Location = new System.Drawing.Point(0, 56);
            this.btnEasyMode.Name = "btnEasyMode";
            this.btnEasyMode.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEasyMode.Size = new System.Drawing.Size(150, 34);
            this.btnEasyMode.TabIndex = 121;
            this.btnEasyMode.TabStop = false;
            this.btnEasyMode.Tag = "color:darker";
            this.btnEasyMode.Text = " Easy Start";
            this.btnEasyMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEasyMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEasyMode.UseVisualStyleBackColor = false;
            // 
            // btnStockpilePlayer
            // 
            this.btnStockpilePlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnStockpilePlayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnStockpilePlayer.FlatAppearance.BorderSize = 0;
            this.btnStockpilePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockpilePlayer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnStockpilePlayer.ForeColor = System.Drawing.Color.White;
            this.btnStockpilePlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnStockpilePlayer.Image")));
            this.btnStockpilePlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockpilePlayer.Location = new System.Drawing.Point(0, 170);
            this.btnStockpilePlayer.Name = "btnStockpilePlayer";
            this.btnStockpilePlayer.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnStockpilePlayer.Size = new System.Drawing.Size(150, 34);
            this.btnStockpilePlayer.TabIndex = 123;
            this.btnStockpilePlayer.TabStop = false;
            this.btnStockpilePlayer.Tag = "color:darker";
            this.btnStockpilePlayer.Text = " Stockpile Player";
            this.btnStockpilePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockpilePlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockpilePlayer.UseVisualStyleBackColor = false;
            // 
            // btnGlitchHarvester
            // 
            this.btnGlitchHarvester.BackColor = System.Drawing.Color.Transparent;
            this.btnGlitchHarvester.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGlitchHarvester.FlatAppearance.BorderSize = 0;
            this.btnGlitchHarvester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlitchHarvester.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnGlitchHarvester.ForeColor = System.Drawing.Color.White;
            this.btnGlitchHarvester.Image = ((System.Drawing.Image)(resources.GetObject("btnGlitchHarvester.Image")));
            this.btnGlitchHarvester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlitchHarvester.Location = new System.Drawing.Point(0, 132);
            this.btnGlitchHarvester.Name = "btnGlitchHarvester";
            this.btnGlitchHarvester.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGlitchHarvester.Size = new System.Drawing.Size(150, 34);
            this.btnGlitchHarvester.TabIndex = 122;
            this.btnGlitchHarvester.TabStop = false;
            this.btnGlitchHarvester.Tag = "color:darker";
            this.btnGlitchHarvester.Text = " Glitch Harvester";
            this.btnGlitchHarvester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlitchHarvester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGlitchHarvester.UseVisualStyleBackColor = false;
            this.btnGlitchHarvester.Click += new System.EventHandler(this.btnGlitchHarvester_Click);
            // 
            // btnManualBlast
            // 
            this.btnManualBlast.BackColor = System.Drawing.Color.Transparent;
            this.btnManualBlast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnManualBlast.FlatAppearance.BorderSize = 0;
            this.btnManualBlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualBlast.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnManualBlast.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnManualBlast.Image = ((System.Drawing.Image)(resources.GetObject("btnManualBlast.Image")));
            this.btnManualBlast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManualBlast.Location = new System.Drawing.Point(0, 206);
            this.btnManualBlast.Name = "btnManualBlast";
            this.btnManualBlast.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnManualBlast.Size = new System.Drawing.Size(150, 34);
            this.btnManualBlast.TabIndex = 119;
            this.btnManualBlast.TabStop = false;
            this.btnManualBlast.Tag = "color:darker";
            this.btnManualBlast.Text = " Manual Blast";
            this.btnManualBlast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManualBlast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManualBlast.UseVisualStyleBackColor = false;
            // 
            // btnAutoCorrupt
            // 
            this.btnAutoCorrupt.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoCorrupt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAutoCorrupt.FlatAppearance.BorderSize = 0;
            this.btnAutoCorrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoCorrupt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAutoCorrupt.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAutoCorrupt.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoCorrupt.Image")));
            this.btnAutoCorrupt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoCorrupt.Location = new System.Drawing.Point(0, 244);
            this.btnAutoCorrupt.Name = "btnAutoCorrupt";
            this.btnAutoCorrupt.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAutoCorrupt.Size = new System.Drawing.Size(150, 34);
            this.btnAutoCorrupt.TabIndex = 120;
            this.btnAutoCorrupt.TabStop = false;
            this.btnAutoCorrupt.Tag = "color:darker";
            this.btnAutoCorrupt.Text = " Start Auto-Corrupt";
            this.btnAutoCorrupt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoCorrupt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoCorrupt.UseVisualStyleBackColor = false;
            // 
            // UI_CoreForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(731, 511);
            this.Controls.Add(this.pnTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 550);
            this.Name = "UI_CoreForm";
            this.Tag = "color:darker";
            this.Text = "RTC";
            this.Load += new System.EventHandler(this.UI_CoreForm_Load);
            this.ResizeBegin += new System.EventHandler(this.UI_CoreForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.UI_CoreForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.UI_CoreForm_Resize);
            this.pnTopBar.ResumeLayout(false);
            this.pnCrashProtection.ResumeLayout(false);
            this.pnCrashProtection.PerformLayout();
            this.pnAutoKillSwitch.ResumeLayout(false);
            this.pnAutoKillSwitch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopBar;
        private System.Windows.Forms.Button btnEngineConfig;
        public System.Windows.Forms.Button btnEasyMode;
        private System.Windows.Forms.Button btnStockpilePlayer;
        public System.Windows.Forms.Button btnGlitchHarvester;
        private System.Windows.Forms.Button btnManualBlast;
        public System.Windows.Forms.Button btnAutoCorrupt;
        public System.Windows.Forms.Button btnLogo;
        public System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnAutoKillSwitch;
        public System.Windows.Forms.CheckBox cbUseAutoKillSwitch;
        public System.Windows.Forms.ProgressBar pbAutoKillSwitchTimeout;
        private System.Windows.Forms.Label lbAks;
        private System.Windows.Forms.Panel pnCrashProtection;
        public System.Windows.Forms.Button btnGpJumpNow;
        public System.Windows.Forms.Button btnGpJumpBack;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox cbUseGameProtection;
        private System.Windows.Forms.Button btnTestSubform;
    }
}

