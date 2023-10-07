using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour {
    [SerializeField] private float timeToResetScene = 1.5f;
    [SerializeField] private ParticleSystem crashEffect;
    private void OnCollisionEnter2D(Collision2D other) {
        crashEffect.Play();
        Invoke("ReloadScene", timeToResetScene);
    }
    public void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
