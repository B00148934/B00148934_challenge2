using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float reduceSpam = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && reduceSpam <=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            reduceSpam = 1;
        }

        if (reduceSpam >= 0)
        {
            reduceSpam -= Time.deltaTime;
        }
    }
}
