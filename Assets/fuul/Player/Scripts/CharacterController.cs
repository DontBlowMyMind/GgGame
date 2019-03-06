﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterController : NetworkBehaviour
{
    CharacterTakeDmg takedmg;
    CharacterMovement movement;
    CharacteAnimations animation;
    public PlayerProperty player;

    CharacterBARS bar;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<CharacteAnimations>();
        takedmg = GetComponent<CharacterTakeDmg>();
        bar = GetComponent<CharacterBARS>();
        movement = GetComponent<CharacterMovement>();
    }

   
    void FixedUpdate()
    {
            movement.PlayerMove();
            animation.Animate();
            bar.BarDraw();     
    }
  


}
