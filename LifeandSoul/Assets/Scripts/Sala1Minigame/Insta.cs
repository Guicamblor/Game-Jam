using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insta : MonoBehaviour
{
    public float cooldownTime = 2f;
    public float proximarodada = 2f;
    public Transform pontodoInsta;
    public GameObject prefabs;
    void Update()
    {
        //Spawna a cada tempo que eu determinar
        if (Time.time > proximarodada)
        {
            Instantiate(prefabs, pontodoInsta.position, pontodoInsta.rotation);
            Instantiate(prefabs, transform.position, Quaternion.identity);
             proximarodada = Time.time + cooldownTime;
        }
    }
}
