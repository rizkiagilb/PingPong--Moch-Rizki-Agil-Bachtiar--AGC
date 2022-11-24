using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUi : MonoBehaviour
{
    // Start is called before the first frame update
    public void Btn_GoToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
