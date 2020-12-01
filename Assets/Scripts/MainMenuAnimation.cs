using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuAnimation : MonoBehaviour
{
    public RectTransform Header;
    public RectTransform Event;
    public RectTransform Chats;
    public RectTransform Sidebarleft;
    public RectTransform SidebarRight;
    public List<GameObject> Buttons;

    public void OnEnable()
    {
        StartCoroutine(Events());
        StartCoroutine(MyCoroutuine());
        StartCoroutine(ChatCoroutuine());
        StartCoroutine(SidebarLeftCoroutuine());
        StartCoroutine(SidebarRightCoroutuine());
        StartCoroutine(ButtonsCoroutine(Buttons));
    }

    IEnumerator MyCoroutuine()
    {
        Header.anchoredPosition=new Vector2(0,195);
        while (Header.anchoredPosition.y>-74)
        {
            Header.anchoredPosition = new Vector2(0, Header.anchoredPosition.y-10);
            yield return null;

        }
    }
    IEnumerator Events()
    {
        Event.anchoredPosition=new Vector2(-245,Event.anchoredPosition.y);
        while (Event.anchoredPosition.x<1)
        {
            Event.anchoredPosition = new Vector2(Event.anchoredPosition.x+10,Event.anchoredPosition.y);
            yield return null;
        }
    }
    
    IEnumerator ChatCoroutuine()
    {
        Chats.anchoredPosition=new Vector2(105,Chats.anchoredPosition.y);
        while (Chats.anchoredPosition.x>-45)
        {
            Chats.anchoredPosition = new Vector2(Chats.anchoredPosition.x-5,Chats.anchoredPosition.y);
            yield return null;
        }
    }

    IEnumerator SidebarLeftCoroutuine()
    {
        Sidebarleft.anchoredPosition= new Vector2(-225,Sidebarleft.anchoredPosition.y);
        while (Sidebarleft.anchoredPosition.x<-15)
        {
            Sidebarleft.anchoredPosition= new Vector2(Sidebarleft.anchoredPosition.x+10,Sidebarleft.anchoredPosition.y);
            yield return null;
        }
    }
    
    IEnumerator SidebarRightCoroutuine()
    {
        SidebarRight.anchoredPosition= new Vector2(105,SidebarRight.anchoredPosition.y);
        while (SidebarRight.anchoredPosition.x>-155)
        {
            SidebarRight.anchoredPosition= new Vector2(SidebarRight.anchoredPosition.x-5,SidebarRight.anchoredPosition.y);
            yield return null;
        }
    }

    IEnumerator ButtonsCoroutine(List<GameObject> obj)
    {
        int i=0;
        
        while ( i<5)
        {
            StartCoroutine(Scale (obj[i]));
            yield return new WaitForSeconds(0.05f);
            i++;
        }
        
    }

    IEnumerator Scale(GameObject obj)
    {
        //scale .1,1.2,1
        while (obj.transform.localScale.x<1.2 && obj.transform.localScale.y<1.2)
        {
            obj.transform.localScale = new Vector2(obj.transform.localScale.x+0.1f, obj.transform.localScale.y+0.1f);
            yield return new WaitForSeconds(0.05f);
        }

        while (obj.transform.localScale.x > 1 && obj.transform.localScale.y > 1)
        {
            obj.transform.localScale= new Vector2(1,1);
            yield return new WaitForSeconds(0.02f);
        }
        

    }
    
}

