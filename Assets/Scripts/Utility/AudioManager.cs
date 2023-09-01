using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip gameOverEffect;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void GameOverMusic()
    {
        audioSource.clip = gameOverEffect;
        audioSource.loop = false;
        audioSource.Play();
    }
}
