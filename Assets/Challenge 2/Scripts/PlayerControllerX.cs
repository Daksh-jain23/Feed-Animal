using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time = 0.0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (time > 0) time -= Time.deltaTime;
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            time = 1.0f;
        }
    }
}
