
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
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.chooseOriginalFolderButton = new System.Windows.Forms.Button();
            this.imitatorTextBox = new System.Windows.Forms.TextBox();
            this.chooseImitatorFolderButton = new System.Windows.Forms.Button();
            this.originalListView = new System.Windows.Forms.ListView();
            this.imitatorListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(149, 14);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.Size = new System.Drawing.Size(233, 22);
            this.originalTextBox.TabIndex = 1;
            // 
            // chooseOriginalFolderButton
            // 
            this.chooseOriginalFolderButton.Location = new System.Drawing.Point(13, 13);
            this.chooseOriginalFolderButton.Name = "chooseOriginalFolderButton";
            this.chooseOriginalFolderButton.Size = new System.Drawing.Size(130, 45);
            this.chooseOriginalFolderButton.TabIndex = 0;
            this.chooseOriginalFolderButton.Text = "Выбрать оригинал";
            this.chooseOriginalFolderButton.UseVisualStyleBackColor = true;
            this.chooseOriginalFolderButton.Click += new System.EventHandler(this.chooseOriginalFolderButton_Click);
            // 
            // imitatorTextBox
            // 
            this.imitatorTextBox.Location = new System.Drawing.Point(146, 14);
            this.imitatorTextBox.Name = "imitatorTextBox";
            this.imitatorTextBox.ReadOnly = true;
            this.imitatorTextBox.Size = new System.Drawing.Size(233, 22);
            this.imitatorTextBox.TabIndex = 2;
            // 
            // chooseImitatorFolderButton
            // 
            this.chooseImitatorFolderButton.Location = new System.Drawing.Point(10, 12);
            this.chooseImitatorFolderButton.Name = "chooseImitatorFolderButton";
            this.chooseImitatorFolderButton.Size = new System.Drawing.Size(130, 46);
            this.chooseImitatorFolderButton.TabIndex = 1;
            this.chooseImitatorFolderButton.Text = "Выбрать подражателя";
            this.chooseImitatorFolderButton.UseVisualStyleBackColor = true;
            this.chooseImitatorFolderButton.Click += new System.EventHandler(this.chooseImitatorFolderButton_Click);
            // 
            // originalListView
            // 
            this.originalListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.originalListView.AutoArrange = false;
            this.originalListView.HideSelection = false;
            this.originalListView.Location = new System.Drawing.Point(13, 65);
            this.originalListView.Name = "originalListView";
            this.originalListView.Size = new System.Drawing.Size(369, 373);
            this.originalListView.TabIndex = 2;
            this.originalListView.UseCompatibleStateImageBehavior = false;
            // 
            // imitatorListView
            // 
            this.imitatorListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.imitatorListView.AutoArrange = false;
            this.imitatorListView.HideSelection = false;
            this.imitatorListView.Location = new System.Drawing.Point(10, 64);
            this.imitatorListView.Name = "imitatorListView";
            this.imitatorListView.Size = new System.Drawing.Size(369, 373);
            this.imitatorListView.TabIndex = 3;
            this.imitatorListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.Button chooseOriginalFolderButton;
        private System.Windows.Forms.TextBox imitatorTextBox;
        private System.Windows.Forms.Button chooseImitatorFolderButton;
        private System.Windows.Forms.ListView originalListView;
        private System.Windows.Forms.ListView imitatorListView;
    }
}

