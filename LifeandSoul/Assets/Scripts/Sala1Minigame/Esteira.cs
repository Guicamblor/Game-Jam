using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esteira : MonoBehaviour
{
    private ArrayList objetos = new ArrayList();
    private Renderer rend;
    [SerializeField] private float velocidadeTextura = .1f;
    [SerializeField] private Transform esteira;

    void Start()
    {
        rend = esteira.GetComponent<Renderer>();
    }

    void FixedUpdate()
    {
        rend.materials[0].SetTextureOffset("_MainTex", new Vector2(velocidadeTextura, 0) * Time.time);
        Movimento();
    }
    void Movimento()
    {
        foreach (Transform objeto in objetos)
        {
            objeto.position += new Vector3(velocidadeTextura, 0, 0) * Time.time;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        objetos.Add(other.transform);
    }
    private void OnTriggerExit(Collider other)
    {
        objetos.Remove(other.transform);
    }
}
