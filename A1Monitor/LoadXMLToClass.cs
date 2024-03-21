using A1Monitor.NFeModel;
using System.Xml.Serialization;

namespace A1Monitor
{
    public class LoadXMLToClass
    {
        public static NfeProc Deserializar(string xmlFilePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(NfeProc));
                using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                {
                    NfeProc? nfeProc = (NfeProc)serializer.Deserialize(fs);
                    return nfeProc;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deserializar XML: {ex.Message}");
                return default(NfeProc);
            }
        }
    }
}
