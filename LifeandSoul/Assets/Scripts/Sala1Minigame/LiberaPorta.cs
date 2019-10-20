using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiberaPorta : MonoBehaviour
{
    public GameObject porta;
    bool Opentdoor = false;

    private void Start()
    {
            porta.SetActive(true);
            Opentdoor = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Objetos")
        {
            porta.SetActive(false);
            Opentdoor = true;
        }
    }
    
}
