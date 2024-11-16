using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursovaOOP.ArchiveForm;
using System.Xml.Serialization;

namespace KursovaOOP
{
    public class CrimeRecordArchive
    {
        private List<CrimeRecord> archivedRecords;
        internal static object Instance;

        public event EventHandler<CrimeRecord> RecordAdded;

        public CrimeRecordArchive()
        {
            archivedRecords = new List<CrimeRecord>();
        }

        public void AddToArchive(CrimeRecord record)
        {
            archivedRecords.Add(record);
            OnRecordAdded(record);
        }

        public List<CrimeRecord> GetArchivedRecords()
        {
            return archivedRecords;
        }

        public void SaveToFile(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CrimeRecord>));
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, archivedRecords);
            }
        }

        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CrimeRecord>));
                using (StreamReader reader = new StreamReader(fileName))
                {
                    archivedRecords = (List<CrimeRecord>)serializer.Deserialize(reader);
                }
            }
        }

        protected virtual void OnRecordAdded(CrimeRecord record)
        {
            RecordAdded?.Invoke(this, record);
        }
    }
} 
