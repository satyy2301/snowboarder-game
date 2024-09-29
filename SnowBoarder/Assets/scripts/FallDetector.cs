using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FallDetector : MonoBehaviour
{
    [SerializeField] float loaddelay = 0.5f ; 
    [SerializeField] ParticleSystem crasheffect;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            crasheffect.Play();
            Debug.Log("OOps hit my head");
            Invoke("reloadscene",loaddelay);
            
        }
    }
    void reloadscene(){
        SceneManager.LoadScene(0);

    }
}
