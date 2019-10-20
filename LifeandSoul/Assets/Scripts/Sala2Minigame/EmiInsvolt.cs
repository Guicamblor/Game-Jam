using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmiInsvolt : MonoBehaviour
{
    public float cooldownTime = 2f;
    public float proximarodada = 0;
    public GameObject prefabs;
    public Transform pontodoInsta;
    void Update()
    {
        //Spawna a cada tempo que eu determinar
        
            if (Time.time > proximarodada)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Instantiate(prefabs, pontodoInsta.position, pontodoInsta.rotation);
                    proximarodada = Time.time - cooldownTime;
                }
            }
        
    }
}
