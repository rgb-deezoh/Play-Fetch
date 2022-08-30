using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Declaring this makes assigning the dog prefab easily assigned from the inspector
    public GameObject dogPrefab;
    //Declaring this makes assigning the dog prefab easily assigned from the inspector
    private float dogInstanceDelay = 0.5f;
    //Time after the Instance is available for release
    private float availableTime = 0.0f;

    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > availableTime)
        {
           availableTime=Time.time + dogInstanceDelay;
           Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
           
        }
    }
}