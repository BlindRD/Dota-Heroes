using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerZZ : MonoBehaviour {

    public int trololo = 4;

    public void GoToLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void fuckYou()
    {
        Debug.Log(trololo);
    }
}