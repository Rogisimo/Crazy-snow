using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{

    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] AudioClip crashSFX;
    bool crashed = false;
   private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground" && !crashed){

            FindObjectOfType<Player>().DisableControls();
            crashed = true;
            Debug.Log("Auch");
            crashParticles.Play();

            GetComponent<AudioSource>().PlayOneShot(crashSFX);

            Invoke("ReloadScene",delay);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
