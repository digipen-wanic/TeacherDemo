/* By: Ryan Scheppler
 * Date: 10/11/19
 * Description: Add to fly enemy, handles fly specific death things
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDeath : MonoBehaviour
{
    public float DeathDelay = 1;
    Animator myAnimator;
    public void OnDeath()
    {
        myAnimator.SetBool("Dead", true);
        Destroy(gameObject.GetComponent<DamageOnCollide>());
        StartCoroutine(DelayedDestroy());
    }

    IEnumerator DelayedDestroy()
    {

        yield return new WaitForSeconds(DeathDelay);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
