using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Click : MonoBehaviour
{
    public AudioSource audio;


	// Use this for initialization
	void Start () {
		
	}
	
    public void onClick()
    {
        if (audio) audio.Play();
        Debug.Log("Event is clicked");
    }

     public void onClickOnpurchase()
    {
        if (audio) audio.Play();
        Debug.Log("Not Enough Currency ");
    }

	// Update is called once per frame
	void Update () {
		
    }
}
