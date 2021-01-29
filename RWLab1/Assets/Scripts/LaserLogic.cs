/* SceneHandler.cs*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class LaserLogic : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    [SerializeField]
    GameObject Event;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "PlayAgainButton")
        {
            Event.GetComponent<EndScreenScript>().PlayAgain();
        }

        if (e.target.name == "GoToMenuButton")
        {
            Event.GetComponent<EndScreenScript>().GoToMenu();
        }

        if (e.target.name == "EndGameButton")
        {
            Event.GetComponent<EndScreenScript>().EndGame();
        }

        if (e.target.name == "StartGameButton")
        {
            Event.GetComponent<MainMenuScript>().StartGame();
        }

        if (e.target.name == "ExitGameButton")
        {
            Event.GetComponent<MainMenuScript>().EndGame();
        }

    }
}