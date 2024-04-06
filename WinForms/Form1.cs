using System;
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
            listView.SmallImageList = imageList;
            listView.View = View.SmallIcon;

            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                Icon icon = SystemIcons.WinLogo;
                ListViewItem item = new ListViewItem(fileInfo.Name, 1);

                if (!imageList.Images.ContainsKey(fileInfo.Extension))
                {
                    icon = Icon.ExtractAssociatedIcon(fileInfo.FullName);
                    imageList.Images.Add(fileInfo.Extension, icon);
                }

                item.ImageKey = fileInfo.Extension;
                listView.Items.Add(item);
            }
        }

        private void chooseOriginalFolderButton_Click(object sender, EventArgs e)
        {
            OriginalFolder = SelectFolderFromDialog();
            originalTextBox.Text = OriginalFolder.FullName;

            InitListViews(OriginalFolder, ref originalListView, ref _imageOriginalList);
        }

        private void chooseImitatorFolderButton_Click(object sender, EventArgs e)
        {
            ImitatorFolder = SelectFolderFromDialog();
            imitatorTextBox.Text = ImitatorFolder.FullName;

            InitListViews(ImitatorFolder, ref imitatorListView, ref _imageImitatorList);
            
            foreach(ListViewItem originalItem in originalListView.Items)
            {
                if (imitatorListView.Items.ContainsKey(originalItem.Text))
                {
                    ListViewItem imitatorItem = imitatorListView.Items.Find(originalItem.Text, true)[0];
                    imitatorItem.ForeColor = Color.Green;
                }
                else
                {
                    _imageImitatorList.Images.Add(originalItem.ImageList.Images[0]);
                    ListViewItem copyOfOriginal = (ListViewItem) originalItem.Clone();
                    copyOfOriginal.ForeColor = Color.Red;
                    imitatorListView.Items.Add(copyOfOriginal);
                }
            }
        }
    }
}
