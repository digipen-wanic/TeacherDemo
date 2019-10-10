/* By: Ryan Scheppler
 * Date: 10/9/19
 * Description: Add to objects meant to create things on unity events
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEventFunction : MonoBehaviour
{
    public GameObject ObjectToMake;

    public void CreateObject()
    {
        Instantiate(ObjectToMake, transform.position, transform.rotation);
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
