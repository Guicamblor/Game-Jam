using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoCena : MonoBehaviour
{
    public GameObject[] cenario;
    public float cooldownTime = 2f;
    public float proximarodada = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > proximarodada)
        {
            proximarodada = Time.time + cooldownTime;
        }
    }
}
