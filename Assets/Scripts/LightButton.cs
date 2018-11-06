using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : MonoBehaviour {

    public Light spotLight;
    public bool player;

    private void OnGUI()
    {
        if(player)
        {
            GUI.Box(new Rect(140, Screen.height - 50, Screen.width - 300, 120), ("Press e to turn on"));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
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
