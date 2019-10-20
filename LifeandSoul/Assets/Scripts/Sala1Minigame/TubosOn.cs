using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubosOn : MonoBehaviour
{
    bool Ativado = false;
    public GameObject[] tubo;

    void FixedUpdate()
    {
        if(GetComponent<LiberaPorta>().porta == false)
        {
            for (int i = 0; i < tubo.Length; i++)
            {
                tubo[i].GetComponent<Renderer>().material.color = Color.red;
                Ativado = true;
            }
            
        }
        else if(GetComponent<LiberaPorta>().porta == true)
        {
            for (int i = 0; i < tubo.Length; i++)
            {
                tubo[i].GetComponent<Renderer>().material.color = Color.green;
                Ativado = false;
            }
            
        }
    }
}
