using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class uron : NetworkBehaviour
{

    [SerializeField] private bool isattak;
    public Damage damage;


    private void FixedUpdate()
    {
        if(!isLocalPlayer)
        {
          /*  if (Input.GetKeyDown(KeyCode.Mouse1)) 
            {
                isattak = true;
                    if (isattak == true)
                {
                    damage.FindAngleAndSetAttack();
                    gameObject.GetComponent<Animator>().SetTrigger("attack");
                }
                
            }
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                isattak = false;
                if (isattak == false)
                {
                    foreach(var nu in damage.Enemys)
                    {
                        if (nu == null)
                        {
                            damage.Enemys.Clear();
                        }
                    }
                    gameObject.GetComponent<Animator>().SetTrigger("idle");
                }
                
            }*/
        }
       
    }
    public override void OnStartLocalPlayer()
    {
        GetComponent<GameObject>();
        base.OnStartLocalPlayer();
    }

}
