using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    //colocar objetos empty para a parada de subida e de descida
    //o ultimo box collider(botão) tem que ser trigger
public class Elevador : MonoBehaviour
{
    public bool EstaSubindo, EstaDescendo, EstaParado, EstaPerto;
    public Transform paradaBaixo, paraAlto;
    public float speed;
    public GameObject Botao;

     void OnTriggerEnter()
    {
        EstaPerto = true;
<<<<<<< HEAD
        Debug.Log("OI");
=======
>>>>>>> gui
    }
    void OnTriggerExit()
    {
        EstaPerto = false;
    }
    void FixedUpdate()
    {
        if(EstaSubindo == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, paraAlto.transform.position, speed * Time.deltaTime);
        }
        if(EstaDescendo == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, paradaBaixo.transform.position, speed * Time.deltaTime);
        }
        if(transform.position == paradaBaixo.transform.position || transform.position == paraAlto.transform.position)
        {
            Botao.GetComponent<Renderer>().material.color = Color.red;
            EstaParado = true;
        }
        else
        {
            Botao.GetComponent<Renderer>().material.color = Color.green;
            EstaParado = false;
        }
<<<<<<< HEAD
        if(Input.GetKey(KeyCode.Q) && EstaPerto == true && EstaParado == true)
=======
        if(Input.GetKeyDown("E") && EstaPerto == true && EstaParado == true)
>>>>>>> gui
        {
            if(transform.position == paradaBaixo.transform.position)
            {
                EstaSubindo = true;
                EstaDescendo = false;
            }
            else if(transform.position == paraAlto.transform.position)
            {
                EstaSubindo = false;
                EstaDescendo = true;
            }
        } 
    }
}
