using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    
    public Test02 test02;
    public int x ;

    private void Start() {
        
        test02.PrintHelloWorld();
        x = test02.y;

        test02.SetZ(10000);
    }


}
