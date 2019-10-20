using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiberaPorta : MonoBehaviour
{
    //colocar rigidybody, colocar collider, colocar a tag objetos e colocar como IsKinect
    public GameObject porta;
    bool Opentdoor = false;

    private void Start()
    {
            porta.SetActive(false);
            porta.SetActive(true);
            Opentdoor = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Objetos")
        {
            porta.SetActive(true);
            porta.SetActive(false);
            Opentdoor = true;
        }
    }
    
}
