using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour {
    [SerializeField] private float timeToResetScene = 1.5f;
    [SerializeField] private ParticleSystem finishEffect;
    [SerializeField] private AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            finishEffect.Play();
            audioSource.Play();
            Invoke("ReloadScene", timeToResetScene);
        }
    }

    public void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
