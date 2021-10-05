using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{
    public float time;

    void Update()
    {
        Invoke("DestroyObject", time);
        
    }
    void DestroyObject(){
        Destroy(gameObject);
    }
}
