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
        Move();
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
    private void PlayerRotate()
    {
        if (target != Vector3.zero)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(target - transform.position), rotationSpeed * Time.deltaTime);
        }
    }
}
