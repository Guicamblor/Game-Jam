using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insta : MonoBehaviour
{
    public GameObject[] obj;
    public float cooldownTime = 2f;
    public float proximarodada = 0;
    void Update()
    {
        if (Time.time > proximarodada)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                Instantiate(obj[i]);
                proximarodada = Time.time + cooldownTime;
            }
        }
    }
}
