﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySearchZone : MonoBehaviour
{
    public enemy1AI enemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enemy.SetSearching();
        }
    }
}
