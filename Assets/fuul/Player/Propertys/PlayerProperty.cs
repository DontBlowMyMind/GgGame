using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerProperty : NetworkBehaviour
{

    [SerializeField] public bool isDead;
    [SerializeField] public bool isUseSkill;
    [SerializeField] public bool isRunning;
    [SerializeField] public bool isSprinting;

    [SerializeField] public float characterSpeed;

    [SerializeField] public float characterSprintingBost;
    [SerializeField] public float baseSpeed;
    [SerializeField] public float maxSpeed;
    [SerializeField] public float minSpeed;
   
    [SerializeField] public float characterHP;
   
    [SerializeField] public float characterMP;
    
    [SerializeField] public float damage;
  
    [SerializeField] public float agility;
    
    [SerializeField] public float strength;

    [SerializeField] public float intelege;

}
