﻿
namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.originalListView = new System.Windows.Forms.ListView();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.chooseOriginalFolderButton = new System.Windows.Forms.Button();
            this.imitatorListView = new System.Windows.Forms.ListView();
            this.imitatorTextBox = new System.Windows.Forms.TextBox();
            this.chooseImitatorFolderButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncTwoFouldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 21);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.originalListView);
            this.splitContainer1.Panel1.Controls.Add(this.originalTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.chooseOriginalFolderButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imitatorListView);
            this.splitContainer1.Panel2.Controls.Add(this.imitatorTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.chooseImitatorFolderButton);
            this.splitContainer1.Size = new System.Drawing.Size(588, 342);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // originalListView
            // 
            this.originalListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.originalListView.AutoArrange = false;
            this.originalListView.HideSelection = false;
            this.originalListView.Location = new System.Drawing.Point(10, 53);
            this.originalListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.originalListView.Name = "originalListView";
            this.originalListView.Size = new System.Drawing.Size(278, 287);
            this.originalListView.TabIndex = 2;
            this.originalListView.UseCompatibleStateImageBehavior = false;
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(112, 11);
            this.originalTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.Size = new System.Drawing.Size(176, 20);
            this.originalTextBox.TabIndex = 1;
            // 
            // chooseOriginalFolderButton
            // 
            this.chooseOriginalFolderButton.Location = new System.Drawing.Point(10, 11);
            this.chooseOriginalFolderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooseOriginalFolderButton.Name = "chooseOriginalFolderButton";
            this.chooseOriginalFolderButton.Size = new System.Drawing.Size(98, 37);
            this.chooseOriginalFolderButton.TabIndex = 0;
            this.chooseOriginalFolderButton.Text = "Выбрать оригинал";
            this.chooseOriginalFolderButton.UseVisualStyleBackColor = true;
            this.chooseOriginalFolderButton.Click += new System.EventHandler(this.chooseOriginalFolderButton_Click);
            // 
            // imitatorListView
            // 
            this.imitatorListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.imitatorListView.AutoArrange = false;
            this.imitatorListView.HideSelection = false;
            this.imitatorListView.Location = new System.Drawing.Point(8, 52);
            this.imitatorListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imitatorListView.Name = "imitatorListView";
            this.imitatorListView.Size = new System.Drawing.Size(278, 288);
            this.imitatorListView.TabIndex = 3;
            this.imitatorListView.UseCompatibleStateImageBehavior = false;
            // 
            // imitatorTextBox
            // 
            this.imitatorTextBox.Location = new System.Drawing.Point(110, 11);
            this.imitatorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imitatorTextBox.Name = "imitatorTextBox";
            this.imitatorTextBox.ReadOnly = true;
            this.imitatorTextBox.Size = new System.Drawing.Size(176, 20);
            this.imitatorTextBox.TabIndex = 2;
            // 
            // chooseImitatorFolderButton
            // 
            this.chooseImitatorFolderButton.Location = new System.Drawing.Point(8, 10);
            this.chooseImitatorFolderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooseImitatorFolderButton.Name = "chooseImitatorFolderButton";
            this.chooseImitatorFolderButton.Size = new System.Drawing.Size(98, 37);
            this.chooseImitatorFolderButton.TabIndex = 1;
            this.chooseImitatorFolderButton.Text = "Выбрать подражателя";
            this.chooseImitatorFolderButton.UseVisualStyleBackColor = true;
            this.chooseImitatorFolderButton.Click += new System.EventHandler(this.chooseImitatorFolderButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFileToolStripMenuItem
            // 
            this.menuFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncTwoFouldersToolStripMenuItem});
            this.menuFileToolStripMenuItem.Name = "menuFileToolStripMenuItem";
            this.menuFileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.menuFileToolStripMenuItem.Text = "Файл";
            // 
            // syncTwoFouldersToolStripMenuItem
            // 
            this.syncTwoFouldersToolStripMenuItem.Name = "syncTwoFouldersToolStripMenuItem";
            this.syncTwoFouldersToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.syncTwoFouldersToolStripMenuItem.Text = "Синхронизировать две папки";
            this.syncTwoFouldersToolStripMenuItem.Click += new System.EventHandler(this.syncTwoFouldersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 363);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Синхронизация файлов";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.Button chooseOriginalFolderButton;
        private System.Windows.Forms.TextBox imitatorTextBox;
        private System.Windows.Forms.Button chooseImitatorFolderButton;
        private System.Windows.Forms.ListView originalListView;
        private System.Windows.Forms.ListView imitatorListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncTwoFouldersToolStripMenuItem;
    }
}

