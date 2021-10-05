using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaPortais : MonoBehaviour
{
    public Transform portal;
    public Transform spawn;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            Invoke("InPortal", 1.2f);
        }
    }
    void InPortal(){
        Instantiate(portal, new Vector3(spawn.transform.position.x, spawn.transform.position.y, 1), Quaternion.identity);
    }
}
