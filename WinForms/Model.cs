using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public class SyncDirectory
    {
        public DirectoryInfo Directory;
        public FileInfo[] OldFiles;
        public List<string> ChangedFiles;
        public FileInfo[] NewFiles
        {
            get
            {
                return Directory.GetFiles();
            }
        }

        public void ApplyChanges()
        {
            OldFiles = NewFiles;
            ChangedFiles = new List<string>();
        }

        public SyncDirectory(string path)
        {
            Directory = new DirectoryInfo(path);
            ApplyChanges();

        }

        public void SyncWith(SyncDirectory sourceDirectory, bool removeMissingItems, bool overwriteDuplicates)
        {
            CopySourceFiles(sourceDirectory, overwriteDuplicates);

            if (removeMissingItems)
            {
                RemoveMissingFromSource(sourceDirectory);
            }
        }

        private void RemoveMissingFromSource(SyncDirectory sourceDirectory)
        {
            foreach (FileInfo originalFile in OldFiles)
            {
                int counterOfSameFiles = sourceDirectory.OldFiles.Count(d => d.Name == originalFile.Name && d.Length == originalFile.Length);

                if (counterOfSameFiles == 0 && !ChangedFiles.Contains(originalFile.Name))
                {
                    File.Delete(originalFile.FullName);
                }
            }
        }

        private void CopySourceFiles(SyncDirectory sourceDirectory, bool overwriteDuplicates)
        {
            foreach (FileInfo sourceFile in sourceDirectory.OldFiles)
            {
                int counterOfDuplicate = OldFiles.Count(d => d.Name == sourceFile.Name && d.Length != sourceFile.Length);
                int counterOfSame = OldFiles.Count(d => d.Name == sourceFile.Name && d.Length == sourceFile.Length);

                if (counterOfSame >= 1)
                {
                    continue;
                }

                if (!overwriteDuplicates && counterOfDuplicate >= 1)
                {
                    var partsOfName = sourceFile.Name.Split('.');
                    string newFileName = $"{partsOfName[0]} ({counterOfDuplicate}).{partsOfName[1]}";
                    string newFilePath = Path.Combine(Directory.FullName, newFileName);
                    sourceFile.CopyTo(newFilePath);
                }
                else
                {
                    string newFilePath = Path.Combine(Directory.FullName, sourceFile.Name);
                    sourceFile.CopyTo(newFilePath, true);
                    if(counterOfDuplicate >= 1)
                    {
                        ChangedFiles.Add(sourceFile.Name);
                    }                    
                }
            }
        }
    }
}
