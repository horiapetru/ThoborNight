using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public static PauseMenu instance;
    public GameManager GameManager;
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!isPaused)
            {
                pauseGame();
            }else 
            {
                resumeGame();
            }
        }
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        // if(GameManager.startPlaying)
        // {
        //     GameManager.startPlaying = false;
        // }
    }

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        // if(!GameManager.startPlaying)
        // {
        //     GameManager.startPlaying = true;
        // }
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
