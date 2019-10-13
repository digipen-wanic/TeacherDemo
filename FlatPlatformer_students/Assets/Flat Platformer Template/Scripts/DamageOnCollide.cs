/* By: Ryan Scheppler
 * Date: 10/9/19
 * Description: Add to objects meant to damage health.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DamageOnCollide : MonoBehaviour
{
    int DamageAmount = 10;

    bool DestroyOnCollide = false;

    public UnityEvent DamageFunctions;

    public UnityEvent DestroyFunctions;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health otherHealth = collision.gameObject.GetComponent<Health>();
        if(otherHealth != null)
        {
            otherHealth.Damage(DamageAmount);
            DamageFunctions.Invoke();
        }
        if(DestroyOnCollide)
        {
            DestroyFunctions.Invoke();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health otherHealth = collision.gameObject.GetComponent<Health>();
        if (otherHealth != null)
        {
            otherHealth.Damage(DamageAmount);
            DamageFunctions.Invoke();
        }
        if (DestroyOnCollide)
        {
            DestroyFunctions.Invoke();
            Destroy(gameObject);
        }
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
