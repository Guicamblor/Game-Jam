using UnityEngine;
using UnityEngine.SceneManagement;


public class scrMenu : MonoBehaviour
{

    public void Tutorial()
    {

    }

    public void Sobre()
    {

    }

    public void VaiSalaCen()
    {
        SceneManager.LoadScene("SalaCen");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
