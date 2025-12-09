namespace SkladProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditPost = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditOd = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miStats = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStats = new System.Windows.Forms.ToolStripButton();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.treeWarehouses = new System.Windows.Forms.TreeView();
            this.lblTreeTitle = new System.Windows.Forms.Label();
            this.splitWork = new System.Windows.Forms.SplitContainer();
            this.pInput = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbKilkist = new System.Windows.Forms.TextBox();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.tbCina = new System.Windows.Forms.TextBox();
            this.cbOdVymiru = new System.Windows.Forms.ComboBox();
            this.cbPostachalnyk = new System.Windows.Forms.ComboBox();
            this.tbVyrobnyk = new System.Windows.Forms.TextBox();
            this.tbNazva = new System.Windows.Forms.TextBox();
            this.cbGrupa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSklad = new System.Windows.Forms.DataGridView();
            this.pBottom = new System.Windows.Forms.Panel();
            this.dgSums = new System.Windows.Forms.DataGridView();
            this.lblSumTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitWork)).BeginInit();
            this.splitWork.Panel1.SuspendLayout();
            this.splitWork.Panel2.SuspendLayout();
            this.splitWork.SuspendLayout();
            this.pInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSklad)).BeginInit();
            this.pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSums)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.miLoad,
            this.miPrint,
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(145, 22);
            this.miSave.Text = "Зберегти...";
            // 
            // miLoad
            // 
            this.miLoad.Name = "miLoad";
            this.miLoad.Size = new System.Drawing.Size(145, 22);
            this.miLoad.Text = "Відкрити...";
            // 
            // miPrint
            // 
            this.miPrint.Name = "miPrint";
            this.miPrint.Size = new System.Drawing.Size(145, 22);
            this.miPrint.Text = "Друк";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(145, 22);
            this.miExit.Text = "Вихід";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditGroups,
            this.miEditPost,
            this.miEditOd});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.editToolStripMenuItem.Text = "Редагувати довідники";
            // 
            // miEditGroups
            // 
            this.miEditGroups.Name = "miEditGroups";
            this.miEditGroups.Size = new System.Drawing.Size(159, 22);
            this.miEditGroups.Tag = "Grupa";
            this.miEditGroups.Text = "Групи";
            // 
            // miEditPost
            // 
            this.miEditPost.Name = "miEditPost";
            this.miEditPost.Size = new System.Drawing.Size(159, 22);
            this.miEditPost.Tag = "Post";
            this.miEditPost.Text = "Постачальники";
            // 
            // miEditOd
            // 
            this.miEditOd.Name = "miEditOd";
            this.miEditOd.Size = new System.Drawing.Size(159, 22);
            this.miEditOd.Tag = "Od";
            this.miEditOd.Text = "Од. виміру";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStats});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.serviceToolStripMenuItem.Text = "Сервіс";
            // 
            // miStats
            // 
            this.miStats.Name = "miStats";
            this.miStats.Size = new System.Drawing.Size(131, 22);
            this.miStats.Text = "Статистика";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbStats});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1100, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(77, 22);
            this.tsbSave.Text = "Зберегти";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbStats
            // 
            this.tsbStats.Image = ((System.Drawing.Image)(resources.GetObject("tsbStats.Image")));
            this.tsbStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStats.Name = "tsbStats";
            this.tsbStats.Size = new System.Drawing.Size(84, 22);
            this.tsbStats.Text = "Статистика";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 49);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.treeWarehouses);
            this.splitMain.Panel1.Controls.Add(this.lblTreeTitle);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitWork);
            this.splitMain.Size = new System.Drawing.Size(1100, 701);
            this.splitMain.SplitterDistance = 220;
            this.splitMain.TabIndex = 2;
            // 
            // treeWarehouses
            // 
            this.treeWarehouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeWarehouses.Location = new System.Drawing.Point(0, 30);
            this.treeWarehouses.Name = "treeWarehouses";
            this.treeWarehouses.Size = new System.Drawing.Size(220, 671);
            this.treeWarehouses.TabIndex = 1;
            // 
            // lblTreeTitle
            // 
            this.lblTreeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTreeTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTreeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTreeTitle.Name = "lblTreeTitle";
            this.lblTreeTitle.Size = new System.Drawing.Size(220, 30);
            this.lblTreeTitle.TabIndex = 0;
            this.lblTreeTitle.Text = "Склади (Фільтр)";
            this.lblTreeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitWork
            // 
            this.splitWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitWork.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitWork.Location = new System.Drawing.Point(0, 0);
            this.splitWork.Name = "splitWork";
            this.splitWork.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitWork.Panel1
            // 
            this.splitWork.Panel1.Controls.Add(this.pInput);
            // 
            // splitWork.Panel2
            // 
            this.splitWork.Panel2.Controls.Add(this.dgSklad);
            this.splitWork.Panel2.Controls.Add(this.pBottom);
            this.splitWork.Size = new System.Drawing.Size(876, 701);
            this.splitWork.SplitterDistance = 160;
            this.splitWork.TabIndex = 0;
            // 
            // pInput
            // 
            this.pInput.BackColor = System.Drawing.Color.LightYellow;
            this.pInput.Controls.Add(this.btnAdd);
            this.pInput.Controls.Add(this.tbKilkist);
            this.pInput.Controls.Add(this.cbValuta);
            this.pInput.Controls.Add(this.tbCina);
            this.pInput.Controls.Add(this.cbOdVymiru);
            this.pInput.Controls.Add(this.cbPostachalnyk);
            this.pInput.Controls.Add(this.tbVyrobnyk);
            this.pInput.Controls.Add(this.tbNazva);
            this.pInput.Controls.Add(this.cbGrupa);
            this.pInput.Controls.Add(this.label9);
            this.pInput.Controls.Add(this.label8);
            this.pInput.Controls.Add(this.label7);
            this.pInput.Controls.Add(this.label6);
            this.pInput.Controls.Add(this.label5);
            this.pInput.Controls.Add(this.label4);
            this.pInput.Controls.Add(this.label3);
            this.pInput.Controls.Add(this.label2);
            this.pInput.Controls.Add(this.label1);
            this.pInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInput.Location = new System.Drawing.Point(0, 0);
            this.pInput.Name = "pInput";
            this.pInput.Size = new System.Drawing.Size(876, 160);
            this.pInput.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(480, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 35);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Додати рядок до таблиці";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbKilkist
            // 
            this.tbKilkist.Location = new System.Drawing.Point(320, 110);
            this.tbKilkist.Name = "tbKilkist";
            this.tbKilkist.Size = new System.Drawing.Size(100, 20);
            this.tbKilkist.TabIndex = 16;
            // 
            // cbValuta
            // 
            this.cbValuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(160, 110);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(80, 21);
            this.cbValuta.TabIndex = 15;
            // 
            // tbCina
            // 
            this.tbCina.Location = new System.Drawing.Point(10, 110);
            this.tbCina.Name = "tbCina";
            this.tbCina.Size = new System.Drawing.Size(100, 20);
            this.tbCina.TabIndex = 14;
            // 
            // cbOdVymiru
            // 
            this.cbOdVymiru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdVymiru.FormattingEnabled = true;
            this.cbOdVymiru.Location = new System.Drawing.Point(640, 55);
            this.cbOdVymiru.Name = "cbOdVymiru";
            this.cbOdVymiru.Size = new System.Drawing.Size(80, 21);
            this.cbOdVymiru.TabIndex = 13;
            // 
            // cbPostachalnyk
            // 
            this.cbPostachalnyk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostachalnyk.FormattingEnabled = true;
            this.cbPostachalnyk.Location = new System.Drawing.Point(480, 55);
            this.cbPostachalnyk.Name = "cbPostachalnyk";
            this.cbPostachalnyk.Size = new System.Drawing.Size(150, 21);
            this.cbPostachalnyk.TabIndex = 12;
            // 
            // tbVyrobnyk
            // 
            this.tbVyrobnyk.Location = new System.Drawing.Point(320, 55);
            this.tbVyrobnyk.Name = "tbVyrobnyk";
            this.tbVyrobnyk.Size = new System.Drawing.Size(150, 20);
            this.tbVyrobnyk.TabIndex = 11;
            // 
            // tbNazva
            // 
            this.tbNazva.Location = new System.Drawing.Point(160, 55);
            this.tbNazva.Name = "tbNazva";
            this.tbNazva.Size = new System.Drawing.Size(150, 20);
            this.tbNazva.TabIndex = 10;
            // 
            // cbGrupa
            // 
            this.cbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupa.FormattingEnabled = true;
            this.cbGrupa.Location = new System.Drawing.Point(10, 55);
            this.cbGrupa.Name = "cbGrupa";
            this.cbGrupa.Size = new System.Drawing.Size(140, 21);
            this.cbGrupa.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Кількість";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Валюта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ціна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Од. вим.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Постачальник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Виробник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Назва товару";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Група";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть нові дані у таблицю \'Склад\'";
            // 
            // dgSklad
            // 
            this.dgSklad.AllowUserToAddRows = false;
            this.dgSklad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSklad.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSklad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSklad.Location = new System.Drawing.Point(0, 0);
            this.dgSklad.Name = "dgSklad";
            this.dgSklad.Size = new System.Drawing.Size(876, 417);
            this.dgSklad.TabIndex = 1;
            // 
            // pBottom
            // 
            this.pBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBottom.Controls.Add(this.dgSums);
            this.pBottom.Controls.Add(this.lblSumTitle);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 417);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(876, 120);
            this.pBottom.TabIndex = 0;
            // 
            // dgSums
            // 
            this.dgSums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSums.Location = new System.Drawing.Point(0, 15);
            this.dgSums.Name = "dgSums";
            this.dgSums.Size = new System.Drawing.Size(874, 103);
            this.dgSums.TabIndex = 1;
            // 
            // lblSumTitle
            // 
            this.lblSumTitle.BackColor = System.Drawing.Color.LightGray;
            this.lblSumTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSumTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblSumTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSumTitle.Name = "lblSumTitle";
            this.lblSumTitle.Size = new System.Drawing.Size(874, 15);
            this.lblSumTitle.TabIndex = 0;
            this.lblSumTitle.Text = "Підсумки (Автоматичний розрахунок по групах)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Проект Sklad - Лаб 13 (Розширена)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitWork.Panel1.ResumeLayout(false);
            this.splitWork.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitWork)).EndInit();
            this.splitWork.ResumeLayout(false);
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSklad)).EndInit();
            this.pBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miLoad;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miEditGroups;
        private System.Windows.Forms.ToolStripMenuItem miEditPost;
        private System.Windows.Forms.ToolStripMenuItem miEditOd;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miStats;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbStats;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TreeView treeWarehouses;
        private System.Windows.Forms.Label lblTreeTitle;
        private System.Windows.Forms.SplitContainer splitWork;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGrupa;
        private System.Windows.Forms.TextBox tbKilkist;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.TextBox tbCina;
        private System.Windows.Forms.ComboBox cbOdVymiru;
        private System.Windows.Forms.ComboBox cbPostachalnyk;
        private System.Windows.Forms.TextBox tbVyrobnyk;
        private System.Windows.Forms.TextBox tbNazva;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgSklad;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Label lblSumTitle;
        private System.Windows.Forms.DataGridView dgSums;
    }
}