using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

public class CharacterTakeDmg : NetworkBehaviour
{
    public PlayerProperty Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<PlayerProperty>();
    }
    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "damage")
        {
            GameObject parent = other.transform.root.gameObject;
            Debug.Log(parent.name);
            PropertyAi pa = parent.GetComponent<PropertyAi>();
            Player.characterHP -= pa.damage;
        }

    }

}
