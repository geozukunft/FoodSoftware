namespace LEDcontrollMenu
{
    partial class Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboMenu = new System.Windows.Forms.ListBox();
            this.gboStatistic = new System.Windows.Forms.GroupBox();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.cmdShowStats = new System.Windows.Forms.Button();
            this.gboNewMeal = new System.Windows.Forms.GroupBox();
            this.cmdAddMeal = new System.Windows.Forms.Button();
            this.rdoBot = new System.Windows.Forms.RadioButton();
            this.rdoTop = new System.Windows.Forms.RadioButton();
            this.txtNewMeal = new System.Windows.Forms.TextBox();
            this.gboDeleteMeal = new System.Windows.Forms.GroupBox();
            this.cmdDeleteSelected = new System.Windows.Forms.Button();
            this.gboRepleace = new System.Windows.Forms.GroupBox();
            this.txtReplaceName = new System.Windows.Forms.TextBox();
            this.cmdReplace = new System.Windows.Forms.Button();
            this.cmdClearAll = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.gboStatistic.SuspendLayout();
            this.gboNewMeal.SuspendLayout();
            this.gboDeleteMeal.SuspendLayout();
            this.gboRepleace.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboMenu
            // 
            this.lboMenu.FormattingEnabled = true;
            this.lboMenu.ItemHeight = 25;
            this.lboMenu.Location = new System.Drawing.Point(81, 34);
            this.lboMenu.Name = "lboMenu";
            this.lboMenu.Size = new System.Drawing.Size(207, 179);
            this.lboMenu.TabIndex = 0;
            // 
            // gboStatistic
            // 
            this.gboStatistic.Controls.Add(this.lblStatistic);
            this.gboStatistic.Controls.Add(this.cmdShowStats);
            this.gboStatistic.Location = new System.Drawing.Point(81, 256);
            this.gboStatistic.Name = "gboStatistic";
            this.gboStatistic.Size = new System.Drawing.Size(307, 437);
            this.gboStatistic.TabIndex = 1;
            this.gboStatistic.TabStop = false;
            this.gboStatistic.Text = "Statistik";
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Location = new System.Drawing.Point(20, 119);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(153, 25);
            this.lblStatistic.TabIndex = 1;
            this.lblStatistic.Text = "Show Statistic:";
            // 
            // cmdShowStats
            // 
            this.cmdShowStats.Location = new System.Drawing.Point(20, 39);
            this.cmdShowStats.Name = "cmdShowStats";
            this.cmdShowStats.Size = new System.Drawing.Size(268, 59);
            this.cmdShowStats.TabIndex = 0;
            this.cmdShowStats.Text = "Statistik Anzeigen";
            this.cmdShowStats.UseVisualStyleBackColor = true;
            this.cmdShowStats.Click += new System.EventHandler(this.cmdShowStats_Click);
            // 
            // gboNewMeal
            // 
            this.gboNewMeal.Controls.Add(this.cmdAddMeal);
            this.gboNewMeal.Controls.Add(this.rdoBot);
            this.gboNewMeal.Controls.Add(this.rdoTop);
            this.gboNewMeal.Controls.Add(this.txtNewMeal);
            this.gboNewMeal.Location = new System.Drawing.Point(758, 34);
            this.gboNewMeal.Name = "gboNewMeal";
            this.gboNewMeal.Size = new System.Drawing.Size(407, 269);
            this.gboNewMeal.TabIndex = 2;
            this.gboNewMeal.TabStop = false;
            this.gboNewMeal.Text = "New meal";
            // 
            // cmdAddMeal
            // 
            this.cmdAddMeal.Location = new System.Drawing.Point(23, 201);
            this.cmdAddMeal.Name = "cmdAddMeal";
            this.cmdAddMeal.Size = new System.Drawing.Size(139, 48);
            this.cmdAddMeal.TabIndex = 4;
            this.cmdAddMeal.Text = "Add meal";
            this.cmdAddMeal.UseVisualStyleBackColor = true;
            this.cmdAddMeal.Click += new System.EventHandler(this.cmdAddMeal_Click);
            // 
            // rdoBot
            // 
            this.rdoBot.AutoSize = true;
            this.rdoBot.Location = new System.Drawing.Point(23, 150);
            this.rdoBot.Name = "rdoBot";
            this.rdoBot.Size = new System.Drawing.Size(169, 29);
            this.rdoBot.TabIndex = 3;
            this.rdoBot.TabStop = true;
            this.rdoBot.Text = "Insert Bottom";
            this.rdoBot.UseVisualStyleBackColor = true;
            // 
            // rdoTop
            // 
            this.rdoTop.AutoSize = true;
            this.rdoTop.Location = new System.Drawing.Point(23, 100);
            this.rdoTop.Name = "rdoTop";
            this.rdoTop.Size = new System.Drawing.Size(139, 29);
            this.rdoTop.TabIndex = 1;
            this.rdoTop.TabStop = true;
            this.rdoTop.Text = "Insert Top";
            this.rdoTop.UseVisualStyleBackColor = true;
            // 
            // txtNewMeal
            // 
            this.txtNewMeal.Location = new System.Drawing.Point(23, 51);
            this.txtNewMeal.Name = "txtNewMeal";
            this.txtNewMeal.Size = new System.Drawing.Size(100, 31);
            this.txtNewMeal.TabIndex = 0;
            // 
            // gboDeleteMeal
            // 
            this.gboDeleteMeal.Controls.Add(this.cmdDeleteSelected);
            this.gboDeleteMeal.Location = new System.Drawing.Point(758, 331);
            this.gboDeleteMeal.Name = "gboDeleteMeal";
            this.gboDeleteMeal.Size = new System.Drawing.Size(407, 156);
            this.gboDeleteMeal.TabIndex = 3;
            this.gboDeleteMeal.TabStop = false;
            this.gboDeleteMeal.Text = "Delete Meal";
            // 
            // cmdDeleteSelected
            // 
            this.cmdDeleteSelected.Location = new System.Drawing.Point(23, 68);
            this.cmdDeleteSelected.Name = "cmdDeleteSelected";
            this.cmdDeleteSelected.Size = new System.Drawing.Size(354, 60);
            this.cmdDeleteSelected.TabIndex = 0;
            this.cmdDeleteSelected.Text = "Delete selected meal";
            this.cmdDeleteSelected.UseVisualStyleBackColor = true;
            this.cmdDeleteSelected.Click += new System.EventHandler(this.cmdDeleteSelected_Click);
            // 
            // gboRepleace
            // 
            this.gboRepleace.Controls.Add(this.cmdReplace);
            this.gboRepleace.Controls.Add(this.txtReplaceName);
            this.gboRepleace.Location = new System.Drawing.Point(767, 521);
            this.gboRepleace.Name = "gboRepleace";
            this.gboRepleace.Size = new System.Drawing.Size(398, 172);
            this.gboRepleace.TabIndex = 4;
            this.gboRepleace.TabStop = false;
            this.gboRepleace.Text = "replace Meal";
            // 
            // txtReplaceName
            // 
            this.txtReplaceName.Location = new System.Drawing.Point(14, 53);
            this.txtReplaceName.Name = "txtReplaceName";
            this.txtReplaceName.Size = new System.Drawing.Size(100, 31);
            this.txtReplaceName.TabIndex = 0;
            // 
            // cmdReplace
            // 
            this.cmdReplace.Location = new System.Drawing.Point(14, 116);
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.Size = new System.Drawing.Size(354, 50);
            this.cmdReplace.TabIndex = 1;
            this.cmdReplace.Text = "Replace selected meal";
            this.cmdReplace.UseVisualStyleBackColor = true;
            this.cmdReplace.Click += new System.EventHandler(this.cmdReplace_Click);
            // 
            // cmdClearAll
            // 
            this.cmdClearAll.Location = new System.Drawing.Point(781, 712);
            this.cmdClearAll.Name = "cmdClearAll";
            this.cmdClearAll.Size = new System.Drawing.Size(354, 52);
            this.cmdClearAll.TabIndex = 5;
            this.cmdClearAll.Text = "Delete Everything";
            this.cmdClearAll.UseVisualStyleBackColor = true;
            this.cmdClearAll.Click += new System.EventHandler(this.cmdClearAll_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(781, 803);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(354, 67);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "Close Applicaton";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 920);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdClearAll);
            this.Controls.Add(this.gboRepleace);
            this.Controls.Add(this.gboDeleteMeal);
            this.Controls.Add(this.gboNewMeal);
            this.Controls.Add(this.gboStatistic);
            this.Controls.Add(this.lboMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.gboStatistic.ResumeLayout(false);
            this.gboStatistic.PerformLayout();
            this.gboNewMeal.ResumeLayout(false);
            this.gboNewMeal.PerformLayout();
            this.gboDeleteMeal.ResumeLayout(false);
            this.gboRepleace.ResumeLayout(false);
            this.gboRepleace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboMenu;
        private System.Windows.Forms.GroupBox gboStatistic;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Button cmdShowStats;
        private System.Windows.Forms.GroupBox gboNewMeal;
        private System.Windows.Forms.Button cmdAddMeal;
        private System.Windows.Forms.RadioButton rdoBot;
        private System.Windows.Forms.RadioButton rdoTop;
        private System.Windows.Forms.TextBox txtNewMeal;
        private System.Windows.Forms.GroupBox gboDeleteMeal;
        private System.Windows.Forms.Button cmdDeleteSelected;
        private System.Windows.Forms.GroupBox gboRepleace;
        private System.Windows.Forms.Button cmdReplace;
        private System.Windows.Forms.TextBox txtReplaceName;
        private System.Windows.Forms.Button cmdClearAll;
        private System.Windows.Forms.Button cmdClose;
    }
}

