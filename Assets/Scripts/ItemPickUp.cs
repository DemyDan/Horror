﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour {

    public bool player;

    [TextArea]
    public string text = "";

    private void OnGUI()
    {
        if (player)
        {
            GUI.Box(new Rect(140, Screen.height - 100, Screen.width - 300, 50), ("Press e to pickup " + this.name + "\n" + text));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            player = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            player = false;
        }
    }
}
