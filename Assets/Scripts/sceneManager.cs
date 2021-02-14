using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void backToBeginning()
    {

        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        //Change lol
        Debug.Log("Quit success");
        Application.Quit();
    }
}
