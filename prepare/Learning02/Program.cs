using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Physics Professor";
        job1._company = "Brigham Young University Idaho";
        job1._startYear = 2017;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Editor";
        job2._company = "Dragonsteel Publishers";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();

        myResume._userName = "John Hodson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}