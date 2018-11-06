using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    LightButton lightSwitch;

    public Light flashLight;
    public bool clickedE = false;
	
	// Update is called once per frame
	void Update () {
        FlashLight();
	}

    void FlashLight()
    {
        if(Input.GetKeyDown("q"))
        {
            flashLight.enabled = !flashLight.enabled;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        //Checks if you are within the lightbutton range and enables you to press e
        if (other.gameObject.tag.Equals("ligthSwitch"))
        {
            if (Input.GetKeyDown("e"))
            {
                if (other.gameObject.GetComponent<LightButton>().spotLight.enabled == true)
                {
                    other.gameObject.GetComponent<LightButton>().spotLight.enabled = false;
                    Debug.Log("Disabled");
                }
                else if (other.gameObject.GetComponent<LightButton>().spotLight.enabled == false)
                {
                    other.gameObject.GetComponent<LightButton>().spotLight.enabled = true;
                    Debug.Log("Enabled");
                }
            }
        }
    }
}
