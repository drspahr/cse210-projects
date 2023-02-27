class Relfect : Activity
{
    private List<string> _reflectPrmp = new List<string>();
    private List<string> _questionList = new List<string>();

    // Constructor
    public Relfect(string activity, string description, int duration) : base(activity, description, duration)
    {
        string [] rlines = System.IO.File.ReadAllLines("reflectprompts.txt");
        foreach (string line in rlines)
        {
            _reflectPrmp.Add(line);
        }

        string [] qlines = System.IO.File.ReadAllLines("reflectquestions.txt");
        foreach (string line in qlines)
        {
            _questionList.Add(line);
        }
    }

    // Methods
    public void DisplayRefPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _reflectPrmp.Count);
        string randPrmpt = _reflectPrmp[index];
        
        Console.WriteLine("Ponder the following Prompt.");
        Console.WriteLine($"------ {randPrmpt} ------");
    }

    public void DisplayRefQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        { 
            Random qrnd = new Random();
            int qind = qrnd.Next(0, _questionList.Count);
            string rndquest = _questionList[qind];

            Console.Write($"{rndquest}");
            Animate();
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void Animate()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}