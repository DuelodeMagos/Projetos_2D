using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Runas : MonoBehaviour
{
    public Text contFogo;
    public Text contAgua;
    public Text contTerra;
    public Text contAr;
    public Text contGravidade;
    public Text contSombras;
    public Text contRaio;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contFogo.text = (Coletores.ContFogo).ToString();
        contAgua.text = (Coletores.ContAgua).ToString();
        contTerra.text = (Coletores.ContTerra).ToString();
        contAr.text = (Coletores.ContAr).ToString();
        contGravidade.text = (Coletores.ContGravidade).ToString();
        contSombras.text = (Coletores.ContSombras).ToString();
        contRaio.text = (Coletores.ContRaio).ToString();
    } 
}
