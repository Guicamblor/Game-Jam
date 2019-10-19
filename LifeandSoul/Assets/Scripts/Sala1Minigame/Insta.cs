using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insta : MonoBehaviour
{
    public GameObject[] obj;

    void Update()
    {
        for (int i = 0; i < obj.Length; i++)
        {
            Instantiate(obj[i]);
        }
    }
}
