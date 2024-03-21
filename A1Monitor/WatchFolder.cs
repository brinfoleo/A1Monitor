using A1Monitor.NFeModel;

namespace A1Monitor
{
    public class WatchFolder
    {
        //Criamos o objeto dizendo qual pasta deve ser monitorada

        private FileSystemWatcher fsw;

        public WatchFolder(bool turnOnOff, string folderPath, string filter, bool subDirectories)
        {

            fsw = new FileSystemWatcher(folderPath);
            //System.IO.
            //Dizemos agora se é para monitorar os subdiretórios ou não
            fsw.IncludeSubdirectories = subDirectories;
            //Através de um Enum dizemos quais eventos devem ser monitorados, modificação da data do arquivo, tamanho, etc...
            fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

            //Dizemos quais tipos de arquivos devem ser monitorados, *.*, *.xml, *.txt, etc...
            //fsw.Filter = "*.xml";
            fsw.Filter = filter;

            //Definimos agora os eventos a serem gerados
            fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            fsw.Created += new FileSystemEventHandler(fsw_Created);
            fsw.Renamed += new RenamedEventHandler(fsw_Renamed);
            fsw.Deleted += new FileSystemEventHandler(fsw_Deleted); //RenamedEventHandler(fsw_Deleted);
            fsw.Error += new ErrorEventHandler(fsw_Error);

            //A propriedade abaixo define que a monitoração deve iniciar, se false, a pasta não será monitorada
            fsw.EnableRaisingEvents = turnOnOff;
        }

        public bool MonitorStatus()
        {
            return fsw.EnableRaisingEvents;
        }
        // Abaixo os métodos para tratar os eventos gerados pela FileSystemWatcher

        //Quando o arquivo ou pasta for alterado
        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            //Vamos demonstar o nome do arquivo ou pasta alterada
            Console.WriteLine("Changed: " + e.FullPath);
        }

        //Quando um arquivo ou pasta for criada
        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            //Vamos demonstar o nome do arquivo ou pasta criada
            Console.WriteLine("Created: " + e.FullPath);
            //Dados dados = Deserializar<Dados>(xmlString);
            string xmlFilePath = e.FullPath;
            NfeProc nfeProc = LoadXMLToClass.Deserializar(xmlFilePath);

        }

        //Quando um arquivo ou pasta for renomeada
        private void fsw_Renamed(object sender, FileSystemEventArgs e)
        {
            //Vamos demonstar o nome do arquivo ou pasta renomeada
            Console.WriteLine("Renamed: " + e.FullPath);
        }

        //Quando um arquivo ou pasta for deletada
        private void fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            //Vamos demonstar o nome do arquivo ou pasta deletada
            Console.WriteLine("Deleted: " + e.FullPath);
        }

        //Quando ocorrer algum erro o evento abaixo será gerado
        private void fsw_Error(object sender, ErrorEventArgs e)
        {
            //Através deste evento podemos monitorar e tratar os erros
        }
    }
}