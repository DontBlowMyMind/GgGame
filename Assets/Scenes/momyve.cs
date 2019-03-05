using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class momyve : MonoBehaviour
{
    Animator anim;
    NavMeshAgent nav;
    public Image hp;
    public Image mp;
    public GameObject projectile;
    Rigidbody project;
    public List<Transform> spawnproj = new List<Transform>();
    public float projspeed;
    public float healpoint = 1f;
    public float manapoint = 1f;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {

        hp.fillAmount = healpoint;
        mp.fillAmount = manapoint;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(1))
        {
            
        }
        if (Input.GetMouseButton(0))
        {

           // anim.SetBool("Walk", true);
            if (Physics.Raycast(ray, out hit, 5000))
            {
                nav.SetDestination(hit.point);

            }
        }

        if (Vector3.Distance(transform.position, nav.destination) <= 0.1f)
        {
            //anim.SetBool("Walk", false);

        }
        if (hp.fillAmount == 0f)
        {
            Application.LoadLevel("SampleScene");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sworddmg")
        {
            healpoint = healpoint - 0.1f;
        }
    }
}
