using System;
using System.Collections.Generic;
class Academic_plan
{

    public Student student;
    public Subject subject;
    public int appraisal;
    public Academic_plan(Student student, Subject subject, int appraisal)
    {
        this.student = student;
        this.subject = subject;
        this.appraisal = appraisal;
    }

    public void Print()
    {
        Console.WriteLine(this.student.name + " " + this.subject.name + " " + this.appraisal);
    }

}