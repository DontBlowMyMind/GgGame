﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playernetwork : NetworkBehaviour
{
    public CamerScript cam;
    public GameObject player;
    public NetworkTransform nt;
    // Start is called before the first frame update
    void Start()
    {

        /*cam = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<CamerScript>();   
        nt = GetComponent<NetworkTransform>();*/
    }

    // Update is called once per frame
  
   
    void FixedUpdate()
    {
       /* if (isClient)
        cam.target = nt.transform;*/
    }
}
