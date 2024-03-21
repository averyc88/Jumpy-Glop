using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Jumpy Glop");
    }

    public void highScores()
    {
        SceneManager.LoadScene("High Scores");
    }
}
