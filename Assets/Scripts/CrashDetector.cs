using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CrashDetector : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Crash!");
    }
}
