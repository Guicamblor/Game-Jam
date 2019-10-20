using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;
=======
>>>>>>> gui

public class EmiInsvolt : MonoBehaviour
{
    public float cooldownTime = 2f;
<<<<<<< HEAD
    public float proximarodada = 0f;
=======
    public float proximarodada = 0;
>>>>>>> gui
    public GameObject prefabs;
    public Transform pontodoInsta;
    void Update()
    {
        //Spawna a cada tempo que eu determinar
<<<<<<< HEAD

        if (cooldownTime > 0f)
        {
            cooldownTime -= Time.deltaTime;
            
        }
        if (cooldownTime <= 0f )
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                cooldownTime = proximarodada;
                Instantiate(prefabs, pontodoInsta.position, pontodoInsta.rotation);
            }
        }
=======
        
            if (Time.time > proximarodada)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Instantiate(prefabs, pontodoInsta.position, pontodoInsta.rotation);
                    proximarodada = Time.time - cooldownTime;
                }
            }
>>>>>>> gui
        
    }
}
