using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lec = new Lectures("AC Mititgation", "Effects of DC Current Density on AC Corrosion", "03/21/2023", "1:00pm", "Charles Ratts", "100");
        lec.SetAddress();
        Outdoors outdoor = new Outdoors("EQ Activity", "Trap Shooting", "05/17/2023", "8:00am", "Sunny and Fair");
        outdoor.SetAddress();
        Receptions recep = new Receptions("Spahr's Wedding", "Wedding Reception", "06/02/2002", "3:00pm", true);
        recep.SetAddress();

        

    }
}