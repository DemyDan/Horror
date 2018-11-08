using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTextWhenEnter : MonoBehaviour
{
    public bool player;

    [TextArea]
    public string text = "Where am I?";

    private void OnGUI()
    {
        if (player)
        {
            GUI.Box(new Rect(140, Screen.height - 50, Screen.width - 300, 120), (text));
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
