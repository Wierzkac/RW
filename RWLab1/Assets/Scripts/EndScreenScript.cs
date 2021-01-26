using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenScript : MonoBehaviour
{
    [SerializeField]
    Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        float score = PlayerPrefs.GetFloat("Score"); 
        ScoreText.text = "Udało Ci sie otrzymać " + string.Format("{0:0.00}", score) + " punktów!";
        if (score > PlayerPrefs.GetFloat("HighScore"))
            PlayerPrefs.SetFloat("HighScore", score);
    }
    public void EndGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void PlayAgain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
    public void GoToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
    }
}
