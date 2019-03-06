using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ISLOCAL : NetworkBehaviour
{
    
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<CharacterController>().enabled = true;
        }
    }

  
}
