using System;
class Student
{

    public string secondName;
    public string name;
    public string patronymic;

    public string adress;
    public string number;

    public Student(string secondName, string name, string patronymic, string adress, string number)
    {
        this.secondName = secondName;
        this.name = name;
        this.patronymic = patronymic;
        this.adress = adress;
        this.number = number;
    }
}