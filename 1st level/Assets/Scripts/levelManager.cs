using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            print("Quit game!");
            QuitGame();
        }
    }
    public void LoadSceneButton(string levelOne)
    {
        SceneManager.LoadScene(levelOne);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
