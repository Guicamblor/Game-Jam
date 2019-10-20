using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed;
    public float startWaitTime;
    public Transform[] moveSpots;

    private int randomSpot;
    private float waitTime;

    public GameObject icons;
    bool iconsOn;

    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            iconsOn = true;
            icons.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        iconsOn = false;
        icons.SetActive(false);
    }
}
