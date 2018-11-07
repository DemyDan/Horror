using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlash : MonoBehaviour {

    public GameObject lightAboveFlash;
    public GameObject HouseKey;
    public GameObject GarageDoor;

    void OnDestroy()
    {
        lightAboveFlash.SetActive(false);
        HouseKey.SetActive(true);
        GarageDoor.SetActive(true);
    }
}
