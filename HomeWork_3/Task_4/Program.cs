namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Type the 'exp' if your version is Expert, 'pro'- if the version is Pro, " +
                $"or click enter to continue with an regular version ");
            string version = Console.ReadLine().ToLower();
            DocumentWorker worker;
            switch (version)
            {
                case "pro":
                    worker = new ProDocumentWorker();
                    break;
                case "exp":
                    worker = new ExpertDocumentWorker();
                    break;
                default:
                    worker = new DocumentWorker();
                    break;
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.ReadKey();



        }
    }
}