using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;


    private bool _isPlayerAtExit = false;
    private float _timer;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == this.player)
        {
            this._isPlayerAtExit = true;
        }
    }

    private void Update()
    {
        if (this._isPlayerAtExit)
        { 
            this.EndLevel();
        }
    }

    private void EndLevel()
    {
        this._timer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = _timer / fadeDuration;
        if (_timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}
