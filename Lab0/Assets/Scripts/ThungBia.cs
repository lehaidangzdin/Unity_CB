using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ThungBia : MonoBehaviour
{
    public static int diem = 0;
    public static int soLuot = 3;

    GameObject bia;
    public float speed = 12f;
    // sounds
    public AudioClip collectSounds;
    // public GameObject collectSound;


    AudioSource audioSource;
    // text
    public Text gameEnd;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (transform.position.x <= -7.5)
        {
            // Debug.Log("Qua vach");
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (transform.position.x >= 3.2)
        {
            // Debug.Log("Qua vach2");
            transform.Translate(-speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        // tinh diem
        if (soLuot == 0)
        {
            Time.timeScale = 0f;
            gameEnd.text = "GameOver!";



        }
        if (diem == 300)
        {
            Time.timeScale = 0f;
            gameEnd.text = "You win!!!";

        }

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Text soDiem = GameObject.Find("Diem").GetComponent<Text>();
        // Text soLuot = GameObject.Find("SoLuot").GetComponent<Text>();

        if (coll.gameObject.tag == "ChaiBia")
        {
            diem += 20;
            soDiem.text = diem.ToString();
            // SoundManager.PlaySound("collect");
            audioSource.PlayOneShot(collectSounds);

            Destroy(coll.gameObject);

        }


    }


}
