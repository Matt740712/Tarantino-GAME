using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private GameAudioManager gameAudioManager;

    void Start()
    {
        gameAudioManager = GameObject.FindObjectOfType<GameAudioManager>();
        gameAudioManager.audioSource.Play();
    }
}

