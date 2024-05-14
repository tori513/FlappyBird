using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bird : MonoBehaviour
{
    [SerializeField]
    private float veloc = 1.5f;
    [SerializeField]
    private float rotationSpeed = 10f;

    private Rigidbody2D rigid;

    public AudioSource audioSource;
    public AudioClip jumpSound;

    public AudioSource audioS;
    public AudioClip dieSound;

    public addSco addSco;
    public addSco addSco1;
    public addSco addSco2;

    [SerializeField]
    private GameObject dieImage;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            rigid.velocity = Vector2.up * veloc;
            audioSource.PlayOneShot(jumpSound);
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rigid.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.I.GameOver();
        dieImage.SetActive(true);
        audioSource.PlayOneShot(dieSound);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("goal"))
        {
            addSco.addScore();
            addSco1.addScore();
            addSco2.addScore();
        }
    }
}
