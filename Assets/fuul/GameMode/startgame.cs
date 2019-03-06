using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class startgame : NetworkBehaviour
{
    public CamerScript cam;
    public GameObject Lobplayer;
    public NetworkTransform nt;
    public SpawnEnemies Spawn;
  
    // Start is called before the first frame update
    void Start()
    {

       /* cam = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<CamerScript>();
        nt = GetComponent<NetworkTransform>();
        if (isClient)
        {

        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawn.isWaweEnd)
            Spawn.StartWawe();

    }
    
    
}
