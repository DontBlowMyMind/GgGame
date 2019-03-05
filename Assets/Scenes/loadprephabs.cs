using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadprephabs : MonoBehaviour
{
   
    public GameObject tavern;
    public Resources prefab;
    // Start is called before the first frame update
    void Start()
    {
       //prefab = Resources.Load("D:/unity/mousemove/Assets/Scenes/")
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(1)) & (tavern.tag=="selechero"))
        {
           
        }
    }
}
