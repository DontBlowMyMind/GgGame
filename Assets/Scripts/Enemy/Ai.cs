using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.AI;
using System.Linq;

public class Ai : NetworkBehaviour
{
    public float dist;

    NavMeshAgent nav;
    public float AgrRadius = 20f;
    public float atdist = 2f;
    Transform target;
    NetworkAnimator anim;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<NetworkAnimator>();
    }

    private void FindPlayer()
    {
        int index = 0;
        var players = GameObject.FindGameObjectsWithTag("Player").ToList().FindAll(x => x.GetComponent<PlayerController>().IsDead == false).ToArray();
        if (players.Length == 0)
            return;
        float minDis = Vector3.Distance(this.transform.position, players[0].transform.position);
        for (int i = 0; i < players.Length; i++)
        {
            float currentDist = Vector3.Distance(this.transform.position, players[i].transform.position);
            if (currentDist < minDis)
            {
                minDis = currentDist;
                index = i;
            }
        }
        target = players[index].transform;
    }
    void Move()
    {
        if (target == null)
            return;
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist > AgrRadius)
        {
            anim.animator.SetBool("idle", true);
        }

        if ((dist < AgrRadius) && (dist > atdist))
        {
            nav.SetDestination(target.position);
            anim.animator.SetBool("idle", false);
            anim.SetTrigger("run");
        }

        if (dist < atdist)
        {
            anim.animator.SetBool("idle", false);
            anim.SetTrigger("attack");
        }
    }

    void Update()
    {
        if (target != null)
        {
            if (target.GetComponent<PlayerController>().IsDead)
            {
                target = null;
                anim.animator.SetBool("idle", true);
                dist = int.MaxValue;
                FindPlayer();
            }
        }
        else
        {
            FindPlayer();
        }
        Move();
    }
}


