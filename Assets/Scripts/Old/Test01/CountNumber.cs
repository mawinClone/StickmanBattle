using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountNumber : MonoBehaviour
{
    public int count = 0;
    public TextMeshProUGUI countNumber;

    private void Start() {

    }

    
    public void AddNumber()
    {
        count ++;

        countNumber.text = "Count Number : " + count;
    }
}
