using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "CP Masters";
        job1._jobTitle = "Corrosion Technician";
        job1._startYear = 2004;
        job1._endYear = 2010;

        // Console.WriteLine($"{job1._company}");
        //job1.DisplayJob();

        Job job2 = new Job();
        job2._company = "Chesapeake Energy";
        job2._jobTitle = "Corrosion Specialist";
        job2._startYear = 2010;
        job2._endYear = 2015;

        // Console.WriteLine($"{job2._company}");
        //job2.DisplayJob();

        Resume resume1 = new Resume();
        resume1._name = "David Spahr";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1.DisplayResume();
    }
}