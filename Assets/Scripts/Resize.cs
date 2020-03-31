using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    
    private float timer;
   public GameObject resize;
    void Start()
    {
    }
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 10f)
        {
           Instantiate(resize,transform.position,transform.rotation);
           timer = 0;

        }

    }
}
