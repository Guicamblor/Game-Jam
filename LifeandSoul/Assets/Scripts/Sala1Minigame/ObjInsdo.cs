using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInsdo : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rigid;
    
    void Update()
    {
        //faz o objeto se mexer que você quer instanciar 
            rigid = GetComponent<Rigidbody>();
            rigid.velocity = new Vector3(speed, 0, 0);
    }
}
