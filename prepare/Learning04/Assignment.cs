using Microsoft.VisualBasic;
using System;

public class Assignment
{
    private string _studentName = "Dale";
    private string _topic = "Derivatives";

    public (string, string) GetSummary()
    {
        return (_studentName, _topic);
    }

}