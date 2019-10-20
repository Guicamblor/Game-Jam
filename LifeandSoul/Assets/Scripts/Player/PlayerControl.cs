using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed = 6f;
    Vector3 movement;
    Animator anim;
    Rigidbody playerRig;
    int floorMask;
    float camRayLength = 100f;

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");

        anim = GetComponent<Animator>();
        playerRig = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);
        Turning();
        Animating(h, v);
    }
    void Move(float h, float v)
    {
        movement.Set(h, 0f, v);

        movement = movement.normalized * speed * Time.deltaTime;

        playerRig.MovePosition (transform.position + movement);
    }

    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit floorHit;

        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playerRig.MoveRotation(newRotation);
        }
    }
    void Animating(float h, float v)
    {
        bool walking = (h != 0f || v != 0f);
<<<<<<< HEAD
        //anim.SetBool("IsWalking", walking);
=======
        anim.SetBool("IsWalking", walking);
>>>>>>> gui
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sala1")
        {
            SceneManager.LoadScene("Sala1");
        }
        if (collision.gameObject.name == "Sala2")
        {
            SceneManager.LoadScene("Sala2");
        }
        if (collision.gameObject.name == "Boss")
        {
            SceneManager.LoadScene("Boss");
        }
    }
}
