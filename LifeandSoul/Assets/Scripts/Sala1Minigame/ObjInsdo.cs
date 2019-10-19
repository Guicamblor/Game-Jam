using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInsdo : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rigid;
    public Transform chao;
    void Start()
    {
        
    }   
    void Update()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = new Vector3(speed + Time.deltaTime, 0, transform.position.z);
    }
}
