using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    public GameObject Panel, Info;
    
    public void OnMouseDown() 
    {
        Panel.SetActive(true);
        Info.SetActive(false);
    }
   
}
