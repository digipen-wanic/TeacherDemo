/* By: Ryan Scheppler
 * Date: 10/9/19
 * Description: Add to objects meant to have a health.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth = 100;

    public bool DestroyAtZero = true;

    public UnityEvent DamageFunctions;
    public UnityEvent DeathFunctions;
    public UnityEvent HealFunctions;
    private bool DeathOccured = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //call this to deal damage
    public void Damage( int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0 && !DeathOccured)
        {
            CurrentHealth = 0;
            DeathFunctions.Invoke();
            DeathOccured = true;
            if (DestroyAtZero)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            DamageFunctions.Invoke();
        }
    }
    //call this to heal
    public void Heal(int health)
    {
        CurrentHealth += health;
        if(CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
        HealFunctions.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
