using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool coolDown = true;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (coolDown)
            {
                dogSpawn();
                StartCoroutine(noSpawnObject(1.0f));

            }
        }
  
    }

    void dogSpawn()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    IEnumerator noSpawnObject(float seconds) //Coroutine to avoid spamming the spacebar
    {
        coolDown = false;
        yield return new WaitForSeconds(seconds);
        coolDown = true;
    }
}
