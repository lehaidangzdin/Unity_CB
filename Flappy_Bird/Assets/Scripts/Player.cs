using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;

    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(Animated), 0.15f, 0.15f);
    }

    public void OnEnable()
    {
        Vector3 positon = transform.position;
        positon.y = 0;
        transform.position = positon;
        direction = Vector3.zero;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))// bắt sự kiện khi ấn phím cách hoặc click chuột trái
        {
            direction = Vector3.up * strength;
        }
        if (Input.touchCount > 0) // bắt sự kiện click trên mobile
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase== TouchPhase.Began)// bắt sự kiện ngay khi click
            {
                direction = Vector3.up * strength;
            }
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime; // thay đổi vị trí chim
    
       }  

    private void Animated()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
        }else if(collision.gameObject.tag == "Mid")
        {
            FindObjectOfType<GameManager>().IncreateSorce();
        }
    }
}
