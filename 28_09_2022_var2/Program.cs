using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _28_09_2022_var2
{
    class Files
    {
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        private string _file1 = "Новый.txt", _file2 = "ОченьНовый.txt";
        public long FileSize { get; set; }
        static public bool operator >(Files file1, Files file2)
        {
            bool result = file1.FileSize > file2.FileSize;
            return result;

        }
        static public bool operator <(Files file1, Files file2)
        {
            bool result = file1.FileSize < file2.FileSize;
            return result;
        }
        public void ShowResult()
        {
            FileInfo fileInfo1 = new FileInfo(_path + _file1);
            Files file1 = new Files { FileSize = fileInfo1.Length };
            FileInfo fileInfo2 = new FileInfo(_path + _file2);
            Files file2 = new Files { FileSize = fileInfo2.Length };
            if (file1 > file2)
            {
                Console.WriteLine("Файл - \"{0}\" имеет размер БОЛЬШЕ ({2} байт\\а) чем файл - \"{1}\"" +
                    " ({3} байт\\а).", _file1, _file2, file1.FileSize, file2.FileSize);
            }
            else if (file1 < file2)
            {
                Console.WriteLine("Файл - \"{0}\" имеет размер БОЛЬШЕ ({2} байт\\а) чем файл - \"{1}\"" +
                    " ({3} байт\\а).", _file2, _file1, file2.FileSize, file1.FileSize);
            }
            else
            {
                Console.WriteLine("Размер файла - \"{0}\" ({2} байт\\а) равен размеру файла \"{1}\"" +
                    " ({3} байт\\а).", _file2, _file1, file1.FileSize, file2.FileSize);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Files myFiles = new Files();
            myFiles.ShowResult();            
        }
    }
}
