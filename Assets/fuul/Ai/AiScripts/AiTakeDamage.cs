using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AiTakeDamage : MonoBehaviour
{
    public PropertyAi pa;
    public PlayerProperty player;
    public Image hpbar;
    
    // Start is called before the first frame update
    void Start()
    {
        pa.hp = 1f;
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag =="gg")
        {
            pa.hp -= player.damage;
        }
    }
    void Update()
    {
        hpbar.fillAmount = pa.hp;
        if (pa.hp <= 0)
        {
            pa.isdead = true;
        }
    }
}
