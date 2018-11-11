using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour {

    public bool IsIn = false;

    private void Update()
    {
        if(IsIn)
        {
            Application.Quit();
            Debug.Log("Next scene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IsIn = true;
    }
}
