using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timeLeft;
    public TextMeshProUGUI timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft < 0) return;
        timeLeft -= Time.deltaTime;
        UpdateText();
        if(timeLeft < 0) {
            timeLeft = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void UpdateText() {
        timerText.text = "Time Left: " + timeLeft.ToString("F0");
    }
}
