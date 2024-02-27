using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StudentList : MonoBehaviour
{
    public List<string> studentName;
    public TextMeshProUGUI nameText;

    int i = 0;

    private void Start() {
        nameText.text = studentName[0];
    }

    public void NextOnClick()
    {
        i++;
        if(i<studentName.Count)
            nameText.text = studentName[i];
        else{
            i=0;
            nameText.text = studentName[i];
        }
    }








}
