using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Vector3 spinSpeed = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        this.transform.position = new Vector3(0, 5, 0);
        this.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);

        spinSpeed = new Vector3(Random.value, Random.value, Random.value);

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(spinSpeed);
    }
}
