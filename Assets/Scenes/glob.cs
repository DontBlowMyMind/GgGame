using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class glob : MonoBehaviour
{
    public float dist;
    public float radius = 20f;
    NavMeshAgent nav;
    Transform target;
    public float speed = 5f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist > radius)
        {
            nav.enabled = false;
            anim.SetBool("walk", false);
           
        }
        if (dist > 2f)
        {
            nav.enabled = true;
            //nav.SetDestination(target.position);
            anim.SetBool("shot", true);
           

        }
        if (dist < 2f)
        {
            
            anim.SetBool("shot", false);
            anim.SetBool("attak", true);
            nav.enabled = false;
        }
    }
   


}
