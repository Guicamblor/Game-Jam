using UnityEngine;
using UnityEngine.SceneManagement;

public class scrMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SalaCen");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
