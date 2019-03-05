using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            gameObject.GetComponent<Animator>().SetTrigger("");
        }
        x = Input.GetAxis("Vertical");
        y = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.W))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y, 0), 0.2f);
        if (Input.GetKeyDown(KeyCode.S))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y +180,0), 0.2f);
        if (Input.GetKeyDown(KeyCode.A))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y -90,0), 0.2f);
        if (Input.GetKeyDown(KeyCode.D))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y+90,0), 0.2f);


    }
    void FixedUpdate()
    {
        gameObject.GetComponent<Animator>().SetFloat("Speed", x, 0.1f, Time.deltaTime);
        gameObject.GetComponent<Animator>().SetFloat("Direction", y, 0.1f, Time.deltaTime);
    }
}
