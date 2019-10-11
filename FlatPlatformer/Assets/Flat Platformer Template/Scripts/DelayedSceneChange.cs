/* By: Ryan Scheppler
* Date: 10/9/19
* Description: Add this to objects you need a scene changing function for with a delay
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedSceneChange : MonoBehaviour
{
    public float Delay;
    public string NextScene = "GameOver";

    public void ChangeScene()
    {
        print("Started");
        StartCoroutine(DelayedChange());
    }

    IEnumerator DelayedChange()
    {
        print("before delay");
        
        yield return new WaitForSeconds(Delay);

        print("after");
        SceneManager.LoadScene(NextScene);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
