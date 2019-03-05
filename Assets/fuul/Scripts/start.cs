using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class start : NetworkBehaviour
{
    public CamerScript cam;
    public GameObject player;
    public NetworkTransform nt;
    // Start is called before the first frame update
    void Start()
    {
       // nt = GetComponent<NetworkTransform>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
      //  cam.target = nt.transform;
    }
}
