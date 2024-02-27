using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public static GameController Instance;

    public int x;





    private void Awake() {
        Instance = this;
    }




    public void SetX(int set)
    {
        x = set;
    }










}
