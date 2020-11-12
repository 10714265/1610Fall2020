using System;
using UnityEngine;
[CreateAssetMenu]
public class GameSwitch : ScriptableObject
{
    public enum GameStates
    {
        Starting,
        Playing,
        Ending,
    }

    

    public GameStates currentgamestates = GameStates.Starting;

    public void ChangeToPlaying()
    {
        currentgamestates = GameStates.Playing;
    }

    public void runCurrentState()
    {
        switch (currentgamestates)
        {
            case GameStates.Starting:
                Debug.Log("Starting");
                break;
            case GameStates.Playing:
                Debug.Log("Playing");
                break;
            case GameStates.Ending:
                Debug.Log("Ending");
                break;
            
        }
    }
}
