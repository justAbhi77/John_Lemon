using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f, displayImageDuration = 1f;
    public CanvasGroup exitBackgroundImageCanvasGroup;

    float m_Timer;
    bool playeratexit;

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playeratexit = true;
        }
    }
    private void Update()
    {
        if (playeratexit)
        {
            endlevel();
        }
    }

    void endlevel()
    {
        m_Timer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;
        if (m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}
