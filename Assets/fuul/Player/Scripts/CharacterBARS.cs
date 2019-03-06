using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class CharacterBARS : NetworkBehaviour
{
   [SerializeField] public Image hpbar;
    [SerializeField] public Image mpbar;
    [SerializeField] public Text str;
    [SerializeField] public Text intel;
    [SerializeField] public Text agil;
    
    public PlayerProperty characterProperty;
    // Update is called once per frame
   
    public void BarDraw()
    {
        
        str.text = characterProperty.strength.ToString();
        intel.text = characterProperty.intelege.ToString();
        agil.text = characterProperty.agility.ToString();

        hpbar.fillAmount = characterProperty.characterHP;
        mpbar.fillAmount = characterProperty.characterMP;
        if (hpbar.fillAmount == 0f)
        {
            characterProperty.isDead = true;
        }
    }
    public override void OnStartLocalPlayer()
    {
        GetComponent<PlayerProperty>();
        base.OnStartLocalPlayer();
    }
}
