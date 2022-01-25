namespace C_OO2
{
    public class FileReader: IDisposable
    {
        public string File{get;}
        public FileReader(string fileName)
        {
            File = fileName;
            throw new FileNotFoundException();
        }
        public void Close()
        {

        }
        public void ReadNextLine()
        {
            throw new IOException();
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}