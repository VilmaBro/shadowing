using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour{
    public int scene;


    public void NewScene(int scene){
        SceneManager.LoadScene(scene);
    }
}