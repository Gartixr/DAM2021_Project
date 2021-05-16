using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject menuPause;
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
    }
    public void ReturnToGame()
    {
        gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (menuPause.gameObject.activeSelf)
            {
                menuPause.gameObject.SetActive(false);
            }
            else
            {
                menuPause.gameObject.SetActive(true);
            }
        }
    }
}
