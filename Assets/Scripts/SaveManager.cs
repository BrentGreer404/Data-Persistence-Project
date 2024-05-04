using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;
    
    public int highScore;
    public string highScoreName;
    public string playerName;

    private void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        highScore = 0;
        highScoreName = "Bovine";
        playerName = "";
        LoadHighScore();
    }
    // Start is called before the first frame update
    public void SaveHighScore() {
        SaveData data = new SaveData();
        data.highScore = highScore;
        data.highScoreName = playerName;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadHighScore() {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highScore = data.highScore;
            highScoreName = data.highScoreName;
        }
    }
    [System.Serializable]
    class SaveData {
        public int highScore;
        public string highScoreName;
    }
}
