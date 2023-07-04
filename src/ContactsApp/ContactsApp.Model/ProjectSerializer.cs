using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Environment;
using Newtonsoft.Json.Converters;

namespace ContactsApp.Model
{
    public class ProjectSerializer
    {
        private string Filename = Environment.GetFolderPath(SpecialFolder.ApplicationData) + "\\Buldakov\\ContactsApp";
        public string GetFilename()
        { 
            return Filename; 
        }
        public void SetFilename(string filename)
        { 
            this.Filename = filename; 
        }
        public void SaveToFile(Project project)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            if (!Directory.Exists(Filename))
                Directory.CreateDirectory(Filename);
            using (StreamWriter sw = new StreamWriter(Path.Combine(Filename, "ContactsApp.json"))) 
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
                writer.Close();
                sw.Close();
            }
        }
        public Project LoadFromFile()
        {
            if(File.Exists(Path.Combine(Filename, "ContactsApp.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;
                using (StreamReader sr = new StreamReader(Path.Combine(Filename, "ContactsApp.json")))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    Project tmp = serializer.Deserialize<Project>(reader);
                    return tmp;
                }
            }
            else return new Project();
        }
    }
}
