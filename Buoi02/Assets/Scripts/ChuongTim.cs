using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuongTim : MonoBehaviour
{
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    public void DestroyChuong()
    {
        Destroy(gameObject);
    }
}
