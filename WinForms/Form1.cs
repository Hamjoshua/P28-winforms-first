﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public DirectoryInfo OriginalFolder;
        public DirectoryInfo ImitatorFolder;
        ImageList _imageOriginalList;
        ImageList _imageImitatorList;

        public Form1()
        {
            InitializeComponent();
        }

        private DirectoryInfo SelectFolderFromDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                return new DirectoryInfo(folderBrowserDialog.SelectedPath);
            }

            return null;
        }

        private void InitListViews(DirectoryInfo directoryInfo, ref ListView listView, ref ImageList imageList)
        {
            listView.Items.Clear();
            imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            listView.SmallImageList = imageList;
            listView.View = View.SmallIcon;

            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                Icon icon = SystemIcons.WinLogo;
                ListViewItem item = new ListViewItem(fileInfo.Name, 1);

                if (!imageList.Images.ContainsKey(fileInfo.Name))
                {
                    icon = Icon.ExtractAssociatedIcon(fileInfo.FullName);
                    imageList.Images.Add(fileInfo.Name, icon);
                }

                item.ImageKey = fileInfo.Name;
                listView.Items.Add(item);
            }
        }

        private void chooseOriginalFolderButton_Click(object sender, EventArgs e)
        {
            OriginalFolder = SelectFolderFromDialog();
            originalTextBox.Text = OriginalFolder.FullName;

            InitListViews(OriginalFolder, ref originalListView, ref _imageOriginalList);
        }

        void PaintFoldersInImitatorPanel()
        {
            foreach (ListViewItem item in imitatorListView.Items)
            {
                item.ForeColor = Color.Green;
            }

            foreach (ListViewItem originalItem in originalListView.Items)
            {
                ListViewItem imitatorItem = imitatorListView.Items.Cast<ListViewItem>()
                                          .FirstOrDefault(x => x.Text == originalItem.Text);

                if (imitatorItem != null)
                {
                    ColorExistingImitator(imitatorItem, originalItem);
                }
                else
                {
                    _imageImitatorList.Images.Add(originalItem.Text, originalItem.ImageList.Images[0]);
                    ListViewItem copyOfOriginal = (ListViewItem)originalItem.Clone();
                    copyOfOriginal.ForeColor = Color.Red;
                    imitatorListView.Items.Add(copyOfOriginal);
                }
            }
        }

        private void ColorExistingImitator(ListViewItem imitatorItem, ListViewItem originalItem)
        {
            string originalData = File.ReadAllText(Path.Combine(OriginalFolder.FullName, originalItem.Text));
            string imitatorData = File.ReadAllText(Path.Combine(ImitatorFolder.FullName, imitatorItem.Text));
            if (originalData == imitatorData)
            {
                imitatorItem.ForeColor = Color.Black;
            }
            else
            {
                imitatorItem.ForeColor = Color.Orange;
            }
        }

        private void chooseImitatorFolderButton_Click(object sender, EventArgs e)
        {
            ImitatorFolder = SelectFolderFromDialog();
            imitatorTextBox.Text = ImitatorFolder.FullName;

            InitListViews(ImitatorFolder, ref imitatorListView, ref _imageImitatorList);
            // Красим все элементы, поскольку по умолчанию они новые для оригинала
            PaintFoldersInImitatorPanel();
        }

        private void CopyFileToDirectory(FileInfo fileToCopy, DirectoryInfo destinationFolder, FileInfo[] filesOfDestinationFolder)
        {
            int counterOfDuplicate = filesOfDestinationFolder.Count(d => d.Name == fileToCopy.Name);
            if (counterOfDuplicate >= 1)
            {
                var partsOfName = fileToCopy.Name.Split('.');
                string newFileName = $"{partsOfName[0]} ({counterOfDuplicate}).{partsOfName[1]}";
                string newFilePath = Path.Combine(destinationFolder.FullName, newFileName);
                fileToCopy.CopyTo(newFilePath);
            }
            else
            {
                string newFilePath = Path.Combine(destinationFolder.FullName, fileToCopy.Name);
                fileToCopy.CopyTo(newFilePath);
            }
        }

        private void syncTwoFouldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OriginalFolder == null || ImitatorFolder == null)
            {
                MessageBox.Show("Не выбраны папки");
                return;
            }

            var originalFiles = OriginalFolder.GetFiles();
            var imitatorFiles = ImitatorFolder.GetFiles();

            int maxEnd = originalFiles.Length > imitatorFiles.Length ? originalFiles.Length : imitatorFiles.Length;
            int counter = 0;

            while (counter < maxEnd)
            {
                if(counter < originalFiles.Length)
                {
                    FileInfo originalFile = originalFiles[counter];
                    CopyFileToDirectory(originalFile, ImitatorFolder, imitatorFiles);
                }

                if (counter < originalFiles.Length)
                {
                    FileInfo imitatorFile = imitatorFiles[counter];
                    CopyFileToDirectory(imitatorFile, OriginalFolder, originalFiles);
                }             

                ++counter;
            }

            MessageBox.Show("Синхронизация завершена!");

            InitListViews(OriginalFolder, ref originalListView, ref _imageOriginalList);
            InitListViews(ImitatorFolder, ref imitatorListView, ref _imageImitatorList);
        }
    }
}
