using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int nextScene;
    public float timer;
        

    void Start()
    {
        Invoke("ChangeScene", 15f); // Invoke the ChangeScene method after 10 seconds
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(nextScene); // Load the next scene
    }
}

