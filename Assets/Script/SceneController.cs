using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public SceneController instance { get; private set; } // objenin her sahnede olması için değişken

    void Awake()
    {
        if (instance == null) // objenin sahnede olup olmamasının kontrolü
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void InGameScene() // oyun ekranı
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenuScene() // ana menü ekranı
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame() // oyundan çıkma
    {
        Application.Quit();
    }
}
