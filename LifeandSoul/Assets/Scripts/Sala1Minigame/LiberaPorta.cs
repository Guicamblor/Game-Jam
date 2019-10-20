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
<<<<<<< HEAD
            porta.SetActive(false);
=======
            porta.SetActive(true);
>>>>>>> gui
            Opentdoor = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Objetos")
        {
<<<<<<< HEAD
            porta.SetActive(true);
=======
            porta.SetActive(false);
>>>>>>> gui
            Opentdoor = true;
        }
    }
    
}
