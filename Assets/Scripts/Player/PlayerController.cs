using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    public Vector3 target;
    public NavMeshAgent nav;
    private Transform cam;
    private NetworkAnimator anim;
    public float speed = 2;
    public float rotationSpeed = 5f;

    [SyncVar]
    public float HP = 100;

    [SyncVar]
    private bool isDead = false;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        cam = transform.GetChild(0);
        anim = GetComponent<NetworkAnimator>();
        if (isLocalPlayer)
        {
            cam.GetComponent<Camera>().enabled = true;
        }
        else
        {
            cam.GetComponent<Camera>().enabled = false ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(CheckHP())
            Move();
    }

    public bool IsDead
    {
        get { return isDead; }
    }

    private bool CheckHP()
    {
        if(HP <= 0)
        {
            isDead = true;
            return false;
        }
        return true;
    }
    private void Move()
    {
        if (!isLocalPlayer)
            return;

        PlayerRotate();
        nav.speed = speed;
        Ray ray = cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit, 50000))
            {
                anim.animator.SetBool("Run", true);
                nav.SetDestination(hit.point);
            }
        }

        if (Vector3.Distance(transform.position, nav.destination) <= 0.25)
        {
            anim.animator.SetBool("Run", false);
            target = Vector3.zero;
        }
    }

    public void TakeDamage(float damage)
    {
        if (!isServer)
            return;
        HP -= damage;
    }
    private void PlayerRotate()
    {
        if (target != Vector3.zero)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(target - transform.position), rotationSpeed * Time.deltaTime);
        }
    }
}
