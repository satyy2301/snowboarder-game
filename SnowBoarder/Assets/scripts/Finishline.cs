using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    [SerializeField] float finishdelay = 0.5f;
    [SerializeField] ParticleSystem finisheffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Reached Finish line");
            finisheffect.Play();
             Invoke("restartlevel",finishdelay);

        }

    }
    void restartlevel()
    {
        SceneManager.LoadScene(0);
    }
}
