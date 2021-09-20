using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loadscene());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
   /* IEnumerator Loadscene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
   */
    public void LevelLoaded(int scenename)
    {

        SceneManager.LoadScene(scenename);
    }
   

    IEnumerator Loadscene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }


}
