using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;

    public float speed = 5.0f;
    public Vector3 direction;
    public GameObject chuong;
    Rigidbody2D _rigidbody;
    public float force = 300;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();

    }
    void Update()
    {

        // getKey : cập nhập bàn phím liên tục => ấn giữ vẫn đc chạy
        // getKeyDown thì ngược lại.
        if (Input.GetKey(KeyCode.A))
        {
            animator.Play("Firen_walk");
            direction = Vector3.left;
            transform.localScale = new Vector3(-5.0f, 5.0f, 1f);
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.Play("Firen_walk");
            direction = Vector3.right;
            transform.localScale = new Vector3(5.0f, 5.0f, 1f);
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // transform.Translate(Vector3.up * speed * Time.deltaTime);
            // animator.Play("Firen_walk");
            _rigidbody.AddForce(Vector2.up * force);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            animator.Play("Firen_walk");

        }

        //ban chuong
        if (Input.GetKeyDown(KeyCode.Space))
        {

            // lệnh Instantiate tạo 1 object mới tại vị trí nhân vật (Object cần tạo, vị trí +(khoảng cách từ tâm nv sang hướng nào), quay obj hay bt)
            // Instantiate(chuong, transform.position + Vector3.right * 1f, Quaternion.identity);

            Instantiate(chuong, transform.position, Quaternion.identity);


            //_chuong = GetComponent<chuong>.SetDirection(direction);
        }

    }
}
