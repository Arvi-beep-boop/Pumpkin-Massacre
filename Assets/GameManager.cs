using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    string endText = "";
    public bool playerDead = false;
    [SerializeField] 
    Text deadText;
    [SerializeField]
    GameObject deadPanel;
    void Start()
    {
        if (Instance == null)
            Instance = this;
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if(playerDead)
        {
            Time.timeScale = 0f;
            deadText.text = "Congrats, waves survived: " + SpawnManager.instance.GetCurrentWave();
            deadPanel.SetActive(true);
        }
    }
    public void RestartBtn()
    {
        SceneManager.LoadScene(0);
    }
}
