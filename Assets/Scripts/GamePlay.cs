using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    
    void Start()
    {
        
    }
   
    void Update()
    {        

    }
    
    public void LevelLoaded(int scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    


   


}
