using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    [SerializeField]
    GameObject gameOverPanel;
    [SerializeField]
    AudioSource audioSource;

    public AudioSource audioSou;
    public AudioClip dieBgm;

    public Animator ani;
    private void Awake()
    {
        I = this;
    }

    void Start()
    {
       
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        audioSource.Stop();
        audioSou.PlayOneShot(dieBgm);
        ani.SetBool("isDie", true);
    }

    public void ReGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
