using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{ 
    public Light flashLight;
    public Transform cam;
    public bool clickedE = false;
    public bool inSight = false;

    List<string> keyItems = new List<string>();


    void Update()
    {
        FlashLight();
        Touch();
    }

    void FlashLight()
    {
        if (Input.GetKeyDown("q"))
        {
            flashLight.enabled = !flashLight.enabled;
        }
    }

    private void Touch()
    {
        RaycastHit hit;
        int layer_mask = LayerMask.GetMask("Interactable");

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 0.8f, layer_mask))
        {
            //If its a keyitem
            if (hit.collider.CompareTag("keyItem"))
            {
                if (Input.GetKeyDown("e"))
                {
                    keyItems.Add(hit.collider.name);
                    Destroy(hit.collider.gameObject);
                }
                Debug.Log("hit");
                //If its a lightswitch
            }
            else if (hit.collider.CompareTag("ligthSwitch"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Debug.Log("Clicked");
                    if (hit.collider.GetComponent<LightButton>().spotLight.enabled == true)
                    {
                        hit.collider.GetComponent<LightButton>().spotLight.enabled = false;
                        Debug.Log("Disabled");
                    }
                    else if (hit.collider.GetComponent<LightButton>().spotLight.enabled == false)
                    {
                        hit.collider.GetComponent<LightButton>().spotLight.enabled = true;
                        Debug.Log("Enabled");
                    }
                }
            }
            Debug.DrawRay(cam.transform.position, cam.transform.forward * hit.distance, Color.yellow);
        }
    }



    //Show the items you have picked up
    void OnGUI()
    {
        if (keyItems.Count >= 1)
        {
            GUILayout.BeginVertical();
            foreach (string item in keyItems)
            {
                GUILayout.Box(item);
            }
            GUILayout.EndVertical();
        }

    }
}


