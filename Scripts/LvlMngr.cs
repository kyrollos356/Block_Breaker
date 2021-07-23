using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlMngr : MonoBehaviour
{
    static bool win;
    public void LoadLevel(string name)
    {
        Application.LoadLevel(name);
    }
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public static void LoadWinNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
