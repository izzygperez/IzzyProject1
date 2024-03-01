using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoopCensor : MonoBehaviour
{
    public GameObject effectObject;

    private void Start()
    {
        effectObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "basketball")
        {
            effectObject.SetActive(true);
        }
    }
}
