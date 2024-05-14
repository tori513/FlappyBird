using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

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

    public GameObject score;

    public Text bestScoreTxt;

    public addSco addSco;
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
        score.SetActive(false);

        if (PlayerPrefs.HasKey("bestScore") == false)
        {
            PlayerPrefs.SetInt("bestScore", addSco.score);
        }
        else
        {
            if (PlayerPrefs.GetInt("bestScore") < addSco.score)
            {
                PlayerPrefs.SetInt("bestScore", addSco.score);
            }
        }
        bestScoreTxt.text = PlayerPrefs.GetInt("bestScore").ToString();
    }

    public void ReGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
