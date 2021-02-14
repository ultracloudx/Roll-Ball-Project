using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        Debug.Log("LoadNextLevel poop");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
