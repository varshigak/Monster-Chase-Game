using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{   
    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void HomeButton() {
        SceneManager.LoadScene("MainMenu");
    }

}
