using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListDetailTest : MonoBehaviour
{


    [System.Serializable]
    public class Student
    {
        public string name;
        public string id;
        public int gpt;
    }

    public List<Student> studentData;


}
