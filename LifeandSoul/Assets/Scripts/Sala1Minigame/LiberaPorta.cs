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
            Opentdoor = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Objetos")
        {
            porta.SetActive(true);
            Opentdoor = true;
        }
    }
    
}
