using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour {
    [SerializeField] private float timeToResetScene = 1.5f;
    [SerializeField] private ParticleSystem crashEffect;
    [SerializeField] private AudioSource audioSource;
    bool hasCrashed;
    private void OnCollisionEnter2D(Collision2D other) {
        if (!hasCrashed) {
        crashEffect.Play();
        audioSource.Play();
        FindObjectOfType<PlayerController>().DisableControls();
        FindObjectOfType<SurfaceEffector2D>().speed = 0;
        Invoke("ReloadScene", timeToResetScene);
        hasCrashed = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        crashEffect.Stop();
    }
    public void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
