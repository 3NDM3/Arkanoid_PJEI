﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerx3 : MonoBehaviour
{

    public GameObject bola;

    GameObject[] numeroBolas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("runa"))
        {

            numeroBolas = GameObject.FindGameObjectsWithTag("bola");

            for (int i = 0; i < numeroBolas.Length; i++)
            {
                Instantiate(bola, transform.position, bola.transform.rotation);
                Instantiate(bola, transform.position, bola.transform.rotation);
                Instantiate(bola, transform.position, bola.transform.rotation);
            }

            
        }
    }
}