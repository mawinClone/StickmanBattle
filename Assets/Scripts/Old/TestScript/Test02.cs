using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public int y;
    public int z;
    
    public void PrintHelloWorld()
    {
        Debug.Log("HelloWorld");
    }

    public int GetY()
    {
        return y;
    }

    public void SetZ(int set)
    {
        z = set;
    }


}
