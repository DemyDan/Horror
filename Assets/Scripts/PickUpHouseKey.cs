using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHouseKey : MonoBehaviour {

    public GameObject GarageDoor;
    public GameObject BloodOnWall;
    public GameObject scare;
    public GameObject scare1;
    public Light lightOnStreet;

    private void OnDestroy()
    {
        GarageDoor.SetActive(false);
        BloodOnWall.SetActive(true);
        lightOnStreet.color = Color.red;
        scare.SetActive(true);
        scare1.SetActive(true);
    }
}
