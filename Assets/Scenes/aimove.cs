using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class aimove : MonoBehaviour
{
    public GameObject player;
    public float dist;
    public float radius = 20f;
    NavMeshAgent nav;
    public float atdist;
    Transform target;
   
    public float speed = 5f;
    Animator anim;
    void Start()
    {
        
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist > radius)
        {
            nav.enabled = false;
            //anim.SetBool("walk",false);
          
        }
        if (dist < radius & dist > atdist)
        {
            nav.enabled = true;
            nav.SetDestination(target.position);
          //  anim.SetBool("walk", true);
           

        }
        if (dist < atdist)
        {
           
           // anim.SetBool("walk", false);
          //  anim.SetBool("attak", true);
            nav.enabled = true;
        }
       
        
    }
   

}
