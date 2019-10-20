using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmiInsvolt : MonoBehaviour
{
    public float cooldownTime = 2f;
    public float proximarodada = 0f;
    public GameObject prefabs;
    public Transform pontodoInsta;
    void Update()
    {
        //Spawna a cada tempo que eu determinar

        if (cooldownTime > 0f)
        {
            cooldownTime -= Time.deltaTime;

        }
        if (cooldownTime <= 0f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                cooldownTime = proximarodada;
                Instantiate(prefabs, pontodoInsta.position, pontodoInsta.rotation);
            }
        }

    }
}
