using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class MenuManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public KeyCode Key;

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private Button Play;
    [SerializeField] private Button Quit;
    public Animation pauseAnim;
    
    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        //pauseAnim.Play("Pause");
        Time.timeScale = 0f;
        GameIsPaused = true;
        
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
