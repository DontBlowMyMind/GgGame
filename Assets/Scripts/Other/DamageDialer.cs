using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class Damage :  MonoBehaviour
{
    public float damage;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerController>().TakeDamage(damage);
        }
    }
}
