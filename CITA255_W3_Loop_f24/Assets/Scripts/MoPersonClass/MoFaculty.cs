using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoFaculty : MoPerson
{
    public int salary;

    public MoFaculty(string name, int mNum, int salary) : base(name, mNum)
    {
        this.salary = salary;
        type = "MoFaculty";
    }

    public override string IntroduceMe()
    {
        return base.IntroduceMe() + "\nSalary: " + salary;
    }
}
