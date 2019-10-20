using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float velocidade;

    // otimização :3 (evita coleta de lixo desnecessário)
    Vector3 deltaMovimento = Vector3.zero;
    public Transform raioRef;
    public float raioDist, chaoDist;
    Transform meu_transform;
    Animator anim;

    void Awake()
    {
        meu_transform = GetComponent<Transform>();
        transform.tag = "Player";
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        // guarda de antemão a rotação
        var rotacaoAntes = meu_transform.rotation;

        // aplica movimento
        {
            // reseta rotação para que a função Translate não nos faça voar
            meu_transform.rotation = Quaternion.Euler(0, meu_transform.localEulerAngles.y, 0);

            // define eixos usando entrada do usuário
            deltaMovimento.x = Input.GetAxis("Horizontal");
            deltaMovimento.z = Input.GetAxis("Vertical");

            // normaliza se necessário
            if (deltaMovimento.magnitude > 1)
                deltaMovimento.Normalize();

            // multiplica pela velocidade e delta tempo
            deltaMovimento *= velocidade * Time.deltaTime;

            // aplica movimento
            meu_transform.Translate(deltaMovimento);
        }

        // acompanhar chão
        {
            // faz raycast pra baixo
            Ray raio = new Ray(raioRef.position, Vector3.down);
            RaycastHit hit;
            if (Physics.Raycast(raio, out hit, raioDist))
            {
                // acompanha distância do chão
                Vector3 pos = meu_transform.position;
                pos.y = hit.point.y + chaoDist;
                meu_transform.position = pos;
            }
        }

        // redefine a rotação que tinha antes
        meu_transform.rotation = rotacaoAntes;

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
        if(collision.gameObject.name == "Encomenda")
        {
            SceneManager.LoadScene("SalaCen2");
        }
    }
}
