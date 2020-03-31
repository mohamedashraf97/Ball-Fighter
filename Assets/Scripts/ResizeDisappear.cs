using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeDisappear : MonoBehaviour
{
   void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag =="Player" || other.gameObject.tag =="Resize")
        {
            Destroy(gameObject);
        }
    }
}
