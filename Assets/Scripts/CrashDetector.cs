using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour {
    [SerializeField] private float timeToResetScene = 1.5f;
    private void OnCollisionEnter2D(Collision2D other) {
        Invoke("ReloadScene", timeToResetScene);
    }
    public void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
