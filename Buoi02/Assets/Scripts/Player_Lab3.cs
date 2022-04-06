using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Lab3 : MonoBehaviour
{
    Object spellPrefab;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        spellPrefab = Resources.Load("Spell");
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // animator.Play("Firen_Spell");//spell
            // GameObject spell = (GameObject)Instantiate(spellPrefab);
            // spell.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -1f);
        }
    }
}
