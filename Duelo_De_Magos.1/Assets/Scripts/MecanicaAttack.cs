using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaAttack : MonoBehaviour
{
    public Transform power_Yellow_1;
    public Transform esfera;
    public Transform fire;
    public Transform s_Fire;
    public Transform power2;
    public Transform spawn;
    public Transform spawn_2;

    void Start()
    {
        
    }

    void Update()
    {   
        /*if(Input.GetKeyDown(KeyCode.F)){
            Invoke("Power2", 0.7f);
        }
        if(Input.GetKeyDown(KeyCode.Z)){
            Invoke("Power_Yellow_1", 0.7f);
        }*/
        if(Input.GetKeyDown(KeyCode.F)&&Mecanica_Conjuracao.agua&&Mecanica_Conjuracao.raio&&Mecanica_Conjuracao.fogo){
            Invoke("Esfera", 0.7f);
            Coletores.ContFogo--;
            Coletores.ContAgua--;
            Coletores.ContRaio--;
            Mecanica_Conjuracao.fogo=false;
            Mecanica_Conjuracao.agua=false;
            Mecanica_Conjuracao.ar=false;
            Mecanica_Conjuracao.terra=false;
            Mecanica_Conjuracao.gravidade=false;
            Mecanica_Conjuracao.raio=false;
            Mecanica_Conjuracao.sombras=false;

        }
        /*if(Input.GetKeyDown(KeyCode.C)){
            Invoke("Fire", 0.7f);
        }
        if(Input.GetKeyDown(KeyCode.V)){
            Invoke("S_Fire", 0.7f);
        }*/
    }

    void Power2(){
        Instantiate(power2, new Vector3(spawn.transform.position.x, spawn.transform.position.y, 1), Quaternion.identity);
    }
    void Power_Yellow_1(){
        Instantiate(power_Yellow_1, new Vector3(spawn.transform.position.x, spawn.transform.position.y, 1), Quaternion.identity);
    }
    void Esfera(){
        Instantiate(esfera, new Vector3(spawn.transform.position.x, spawn.transform.position.y, 1), Quaternion.identity);
        Esfera_de_Energia.contEsferas++;
    }
    void Fire(){
        Instantiate(fire, new Vector3(spawn_2.transform.position.x, spawn_2.transform.position.y, 1), Quaternion.identity);
    }
    void S_Fire(){
        Instantiate(s_Fire, new Vector3(spawn.transform.position.x, spawn_2.transform.position.y, 1), Quaternion.identity);
    }
}
