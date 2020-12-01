using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GamePlayActive : MonoBehaviour
{
    public List<GameObject> DeactiveList;
   
    public Color ActiveColor;
    public Color DeactiveColor;
    public GameObject ImageActive;

    public void OnActive(GameObject obj)
    {
        //print(obj+"is active");
        // print(this.transform.GetChild(0).name);
        obj.transform.GetChild(0).gameObject.SetActive(true);
        obj.transform.GetChild(1).GetComponent<Image>().color = new Color32(255,255,0,255);
        obj.transform.GetChild(2).GetComponent<TMP_Text>().color = ActiveColor;
        
    }

    public void OnDeActive(GameObject obj)
    {
        if (obj.transform.GetChild(0).gameObject.activeSelf)
        {
            foreach (GameObject obj1 in DeactiveList)
            {
                if (obj != obj1)
                {
                    obj1.transform.GetChild(0).gameObject.SetActive(false);
                    obj1.transform.GetChild(2).GetComponent<TMP_Text>().color = DeactiveColor;
                }
            }
        }
    }
}
