using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    #region Unity_functions
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    #endregion

    #region Scence_transitions

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoseGame()
    {
        SceneManager.LoadScene("LoseScene");
    }

    public void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    #endregion
}