using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject focalPoint;
    public float speed = 5;
    private float forwardInput;
    private Rigidbody rigidyBd;

    // Start is called before the first frame update
    void Start()
    {
        rigidyBd = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        rigidyBd.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

}
