using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    //Colocar em um Empty colocar tag GM e colocar nome GameMaster
    private static GameMaster instance;
    public Vector3 lastCheckPointPos;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
