using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour
{
    public Image img;
    
    private void Start() {
        img.sprite = Resources.Load<Sprite>("Fall");
    }
}
