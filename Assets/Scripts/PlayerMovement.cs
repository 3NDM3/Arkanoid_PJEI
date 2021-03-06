﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public GameObject bola;
    public GameObject bolaPU;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.y = -4;
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

    }

    public void VelCero()
    {
        moveSpeed = 0;
    }

    public void InstanciaBola()
    {
        Instantiate(bolaPU, bola.transform.position, bola.transform.rotation);
    }

    
}
