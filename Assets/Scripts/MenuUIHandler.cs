using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    
    public TextMeshProUGUI HighScoreText;
    public TMP_InputField InputText;
    void Awake()
    {
        HighScoreText.text = "High Score: " + SaveManager.Instance.highScore + " Name: " + SaveManager.Instance.highScoreName;
    }

    public void StartClicked() {
        Debug.Log(SaveManager.Instance.playerName);
        SaveManager.Instance.playerName = InputText.text;
        SceneManager.LoadScene(1);
    }
}
