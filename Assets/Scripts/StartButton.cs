using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1); // "OyunSahnesi" oyunun ba�lamas�n� istedi�iniz sahnenin ad�d�r
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
