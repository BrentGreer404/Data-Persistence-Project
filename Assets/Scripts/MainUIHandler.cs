using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUIHandler : MonoBehaviour
{
    public MainManager mainManager;
    public TextMeshProUGUI ScoreText;
    void Awake()
    {
        ScoreText.text = "Score: 0";
    }

    public void UpdateScore() {
        ScoreText.text = "Score: " + mainManager.m_Points;
    }
}
