﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}