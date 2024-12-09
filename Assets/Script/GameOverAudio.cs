using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAudio : MonoBehaviour
{
    private AudioSource gameOverAudio;

    void Start()
    {
        gameOverAudio = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("GameOver") == 1)
        {
            gameOverAudio.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource tidak ditemukan pada GameObject ini!");
        }
    }
}
