using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public static score instance;

    public TMP_Text canvasText;

    public string textVarible = "score: ";

    void Start()
    {
        canvasText.text = textVarible;
    }

    // Update is called once per frame
    void Update()
    {
        canvasText.text = textVarible;
    }
}
