using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UniversalScript : MonoBehaviour
{
   /*public List<GameObject> text;
   public List<GameObject> Panel;
   public GameObject Enable;*/


   public void OnSetActive(GameObject obj)
   {
      obj.SetActive(true);
      print(obj.name);
      //parent
      //parent-to-text
      //color
   }
   
   public void OnSetDeactive(GameObject obj)
   {
      obj.SetActive(false);
   }

   public void OnActiveText(GameObject text)
   {
      // text.OnActiveText(true);
   }
}
