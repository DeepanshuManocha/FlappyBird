﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private static bgSound instance=null;
    public static bgSound Instance{
        get{return instance;}
    }

    void Awake()
    {
        if(instance!=null && instance!=this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance=this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

