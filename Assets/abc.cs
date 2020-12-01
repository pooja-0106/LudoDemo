using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class abc : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text text1;
    public TMP_Text text2;
    
    public void ChnageColor()
    {
        text1.color = new Color32(36, 179, 255, 255);
        text2.color = new Color32(36, 179, 255, 255);
        text.color = new Color32(7, 33, 121, 255);
    }

    
}
