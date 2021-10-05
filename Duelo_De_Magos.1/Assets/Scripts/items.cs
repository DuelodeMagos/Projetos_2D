using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
   
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name=="Mago"){
            Destroy(gameObject);
        }
    }
}
