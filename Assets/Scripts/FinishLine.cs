using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour {
    [SerializeField] private float timeToResetScene = 1.5f;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Invoke("ReloadScene", timeToResetScene);
        }
    }

    public void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
