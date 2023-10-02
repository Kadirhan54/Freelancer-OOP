using Freelancer.Abstract;
using Freelancer.Constants;
using Freelancer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    internal class NotepadService
    {
        public void SaveToNotepad(ICsvConvertable data)
        {
            string path = $"{FileLocation.ProjectFolder}\\Database";
            string type = TypeUtils.GetTypeOfObject(data);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string filePath = $"{path}\\{type}s.txt";

            File.AppendAllText(filePath, $"{data.GetValuesCSV()}\n");
        }

        public string GetOnNotepad(string path)
        {
            if (File.Exists(path))
                return File.ReadAllText(path);

            throw new Exception("File Doesn't Exist");
        }

    }
}
