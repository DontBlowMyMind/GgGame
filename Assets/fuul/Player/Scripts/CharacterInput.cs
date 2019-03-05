using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class CharacterInput : NetworkBehaviour
{
    public PlayerProperty PlayerProperty;
    public Damage damage;
    public SpawnEnemies Spawn;
  /*  public Canvas ShopUI;
    public Image helmet;
    public Image gloves;
    public Image sword;*/
    
    // Update is called once per frame
    void Start()
    {
        //ShopUI.enabled = false;
       
       // ShopUI.enabled = false;
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && PlayerProperty.isRunning)
        {
            PlayerProperty.isSprinting = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PlayerProperty.isSprinting = false;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            Spawn.StartWawe();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            damage.FindAngleAndSetAttack();
            gameObject.GetComponent<Animator>().SetTrigger("attack");
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            damage.FindAngleAndSetAttack();
            gameObject.GetComponent<Animator>().SetTrigger("idle");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (Input.GetKeyDown(KeyCode.H))
            {

            }
            if (Input.GetKeyDown(KeyCode.G))
            {

            }
            if (Input.GetKeyDown(KeyCode.S))
            {

            }
        

        }
    }
}
