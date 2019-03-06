using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class DamageDialer :  MonoBehaviour
{
    public float damage;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(!other.GetComponent<PlayerController>().IsDead)
                other.GetComponent<PlayerController>().TakeDamage(damage);
        }
    }
}
