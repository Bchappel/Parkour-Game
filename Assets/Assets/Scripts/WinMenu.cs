using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public string Level1;

    public void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(Level1);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }


    }

    public void RestartGame()
    {


        //SceneManager.LoadScene(Level1);
    }

    public void QuitGame()
    {
        //Application.Quit();
    }

}
