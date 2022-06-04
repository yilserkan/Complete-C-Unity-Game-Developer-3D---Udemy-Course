using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] ParticleSystem explosionParticles;
    [SerializeField] float levelLoadDelay = 1f;

    bool hasCrashed = false;

    void OnTriggerEnter(Collider other) 
    {
        if(!hasCrashed)
            StartCrashSequence();  
    }

    void StartCrashSequence()
    {
        hasCrashed = true;
        explosionParticles.Play();
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<PlayerController>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);  
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
