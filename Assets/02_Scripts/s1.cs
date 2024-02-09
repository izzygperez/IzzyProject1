using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] int x;
    [SerializeField] float startTime;
    [SerializeField]string yourName;
    Vector3 pos;//(x,y,z)
    [SerializeField] Material newMat;
    [SerializeField] Material oldMat;
    [SerializeField] GameObject board;
    // Start is called before the first frame update
    void Start()
    {
        /* yourName = "Player 1";
         Debug.Log("hello "+yourName);
         yourName = obj.name;
         Debug.Log("Hello " + yourName);
         this.gameObject.name = yourName;*/
        startTime = Time.time;
        oldMat = board.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time-startTime >= 10.0f)
        {
            board.GetComponent<MeshRenderer>().material = newMat;
        }
    }

    public void Score()
    {
        Debug.Log("nice shot");
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
