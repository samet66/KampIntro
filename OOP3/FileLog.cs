using System;

namespace OOP3
{
    class FileLog : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
