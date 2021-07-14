using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public InputField playerField;

    public int Highscore = 0;
    public int score = 0;

    public PlayerData playerdata;

    [System.Serializable]
    public class PlayerData
    {
        public string playerName;
        public int sacore;
        public int HighScore;

    }


    public static DataManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(Instance);
        playerdata = new PlayerData();




    }


    public void StartGame()
    {
        playerdata.playerName = playerField.text.ToString();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();


#endif
        Application.Quit();





    }




}


