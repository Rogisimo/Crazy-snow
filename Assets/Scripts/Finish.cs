using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float delay = 1f;

    [SerializeField] ParticleSystem finishEffect;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            Debug.Log("Finish");
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene",delay);
        }
    }


    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
