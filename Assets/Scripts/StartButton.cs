using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public AudioSource audiSource;
    public AudioClip clickSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void Click()
    {
        Invoke("NextScene", 1f);
        audiSource.PlayOneShot(clickSound);

    }

    void NextScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
