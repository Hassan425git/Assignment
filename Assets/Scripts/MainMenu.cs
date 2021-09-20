using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public void LevelLoaded(int scenename)
    {
        SceneManager.LoadScene(scenename);
    }

}
