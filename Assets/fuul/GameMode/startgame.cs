using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class startgame : NetworkBehaviour
{
    public SpawnEnemies Spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Spawn.isWaweEnd);
        if (Spawn.isWaweEnd)
            Spawn.StartWawe();

    }
}
