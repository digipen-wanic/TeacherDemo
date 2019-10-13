/* By: Ryan Scheppler
* Date: 10/9/19
* Description: Add to object to cause a level change when the player touches it.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevelOnCollide : MonoBehaviour
{
    public string NextScene = "EndScene";
    public AudioClip sfxDoor;

    private AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            audioSource.clip = sfxDoor;
            audioSource.Play();
            SceneManager.LoadScene(NextScene);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
