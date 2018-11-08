using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisObject : MonoBehaviour {

    public GameObject DestroyThis;

    private void Update()
    {
        transform.position = DestroyThis.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            Destroy(DestroyThis);
            Destroy(this.gameObject);
        }
    }
}
