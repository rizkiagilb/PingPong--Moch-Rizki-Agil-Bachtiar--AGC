using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame(){
        // SceneManager.SetActiveScene(SceneManager.GetSceneByName("Game")); ini salah ya, sesat :v
        SceneManager.LoadScene("Game");
    }

    public void Author(string nama)
    {
        Debug.Log(nama);
    }

}