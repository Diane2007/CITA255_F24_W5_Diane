using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directory : MonoBehaviour
{
    private void Start()
    {
        //List<int> ints = new List<int>();

        //MoPerson moPerson = new MoPerson();
        MoPerson alex = new MoPerson("Alex", 123);
        MoStudent lily = new MoStudent("Lily", 234, 4.0f);

        MoFaculty diane = new MoFaculty("Diane", 345, 99999999);
        Debug.Log(diane.IntroduceMe());
    }
}
