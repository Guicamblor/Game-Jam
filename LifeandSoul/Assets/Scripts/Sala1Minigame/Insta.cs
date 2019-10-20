using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insta : MonoBehaviour
{
    public float cooldownTime = 2f;
<<<<<<< HEAD
    public float proximarodada = 2f;
    public Transform pontodoInsta;
=======
    public float proximarodada = 0;
>>>>>>> gui
    public GameObject prefabs;
    void Update()
    {
        //Spawna a cada tempo que eu determinar
        if (Time.time > proximarodada)
        {
<<<<<<< HEAD
            Instantiate(prefabs, pontodoInsta.position, pontodoInsta.rotation);
=======
            Instantiate(prefabs, transform.position, Quaternion.identity);
>>>>>>> gui
             proximarodada = Time.time + cooldownTime;
        }
    }
}
