using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField]
    GameObject StartGameButton;
    [SerializeField]
    GameObject EndGameButton;
    [SerializeField]
    Text HighscoreText;
    // Start is called before the first frame update
    private void Start()
    {
        HighscoreText.text = string.Format("{0:0.00}", PlayerPrefs.GetFloat("HighScore"));
    }
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
    public void EndGame()
    {
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
    #else
            Application.Quit();
    #endif
    }
}
