using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnControllers : MonoBehaviour
{
    [SerializeField] GameObject RightController;
    [SerializeField] GameObject LeftController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RightController.SetActive(true);
        LeftController.SetActive(true);
    }
}
