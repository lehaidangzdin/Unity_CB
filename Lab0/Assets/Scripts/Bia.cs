using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bia : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    // public int numberBeers = 5;
    public float spawnRate = 1f;
    public float nextSpawn = 0f;
    Vector2 where;
    float randomX;
    // sounds



    void Start()
    {
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randomX = Random.Range(-7f, 3f);
            where = new Vector2(randomX, transform.position.y);
            Instantiate(prefab, where, Quaternion.identity);
        }

    }



    void createBeers()
    {
        GameObject ChaiBia = Instantiate(prefab, transform.position, Quaternion.identity);
        ChaiBia.transform.position += Vector3.up * Random.Range(-4, 2);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {

        Text soLuot = GameObject.Find("SoLuot").GetComponent<Text>();


        if (coll.gameObject.tag == "Bg")
        {
            ThungBia.soLuot -= 1;
            soLuot.text = "So luot " + ThungBia.soLuot;
            Destroy(gameObject);
        }

    }
}
