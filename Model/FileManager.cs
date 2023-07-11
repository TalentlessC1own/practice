using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Model
{
    public interface IFileManager
    {
        string[] OpenFile();
        void SaveInitialData(); 
        void ExportData();
    }
    public class FileManager : IFileManager
    {
        public string[] OpenFile()
        {
            throw new NotImplementedException();
        }

        public void SaveInitialData()
        {
            throw new NotImplementedException();
        }

        public void ExportData()
        {
            throw new NotImplementedException();
        }
    }
}
