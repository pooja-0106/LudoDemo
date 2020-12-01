using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Shop : MonoBehaviour
{
    public List<GameObject> DisabledPanels;
    public GameObject Panel;
    // public TMP_Text defaulttext;
    public TMP_Text text;
    public TMP_Text text1;
    
    public void ChnageColor()
    {
        text1.color = new Color32(36, 179, 255, 255);
        text.color = new Color32(7, 33, 121, 255);
    }  
    public void OpenPanel()
    {
        foreach(GameObject obj  in DisabledPanels)
        {
            obj.SetActive(false);
        }
        Panel.SetActive(true);

    }
     public AudioSource audio;
    
    public void onClick()
    {
        if (audio) audio.Play();
        // defaulttext.color=Color.blue;
        Debug.Log("Shop is clicked");
    }

	// Update is called once per frame
	void Update () {
		
    }
}
