using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Controller : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
        {
            Debug.Log("Local");
            this.transform.GetChild(0).GetComponent<Camera>().enabled = true;
        }
        else
        {
            Debug.Log("Not");
            this.transform.GetChild(0).GetComponent<Camera>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        var x = Input.GetAxis("Horizontal") * 0.1f;
        var z = Input.GetAxis("Vertical") * 0.1f;
        transform.Translate(x, 0, z);
    }
}
