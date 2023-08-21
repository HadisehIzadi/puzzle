using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
	public TMP_Text timeText;
    public TMP_Text scoreText;

    public TMP_Text winScore;
    public TMP_Text winText;
    public GameObject winStars1, winStars2, winStars3;
    
    public GameObject roundOverScreen;
    
    public string LevelSelect;

    public GameObject pauseScreen;
    public GameObject pauseButton;
    // Start is called before the first frame update
    void Start()
    {
        winStars1.SetActive(false);
        winStars2.SetActive(false);
        winStars3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     public void PauseUnpause()
    {
        if(!pauseScreen.activeInHierarchy)
        {
        	
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
            pauseButton.SetActive(false);
        } else
        {
            pauseScreen.SetActive(false);
            pauseButton.SetActive(true);
            Time.timeScale = 1f;
        }
    }



    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToLevelSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(LevelSelect);
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    
    
}
