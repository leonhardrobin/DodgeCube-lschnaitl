﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    Player player;
    public float timeActive = 5;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Destroy(this.gameObject, timeActive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (player.lives <= player.maxLives)
            {
                player.lives++;
                Destroy(this.gameObject);
            }
        }
    }
    //if player, check how many lives player has
    //give live if less than max lives
}
