using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        float move2 = Input.GetAxis("Vertical");
        rigid.velocity = new Vector3(move * speed, rigid.velocity.y, move2 * speed);
        
    }
    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.name == "Sala1")
        {
            SceneManager.LoadScene("Sala1");
        }
      if(collision.gameObject.name == "Sala2")
        {
            SceneManager.LoadScene("Sala2");
        }
        if (collision.gameObject.name == "Boss")
        {
            SceneManager.LoadScene("Boss");
        }
    }
}
