using System;
class Subject
{
    public string name;
    public string vLectures;
    public string vPractice;
    public string vLaboratory;

    public Subject(string name, string vLectures, string vPractice, string vLaboratory)
    {
        this.name = name;
        this.vLectures = vLectures;
        this.vPractice = vPractice;
        this.vLaboratory = vLaboratory;
    }
}