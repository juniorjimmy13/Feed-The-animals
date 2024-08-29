using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool pressed = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !pressed)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            pressed = true;
            StartCoroutine(ResetDogPress());
        }
    }

    IEnumerator ResetDogPress()
    {
        yield return new WaitForSeconds(2.0f);
        pressed = false;
    }
}
