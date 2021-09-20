using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    string scene1 = "Menu";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loadscene());
    }

    
    IEnumerator Loadscene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }

   


}
