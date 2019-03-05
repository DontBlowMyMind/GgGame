using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uron : MonoBehaviour
{
   // public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
           
            gameObject.GetComponent<Animator>().SetTrigger("attack");
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            
            gameObject.GetComponent<Animator>().SetTrigger("idle");
        }
    }

}
