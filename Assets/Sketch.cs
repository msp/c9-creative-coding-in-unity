using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        int totalCubes = 8;
        int totalDistance = 5; // width of room from origin

        for (int i = 0; i < totalCubes; i++)
        {
            float percentage = i / (float)totalCubes;

            float x = percentage * totalDistance;
            float y = 5.0f;
            float z = 0.0f;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<CubeScript>().SetSize(1.0f - percentage);
            newCube.GetComponent<CubeScript>().rotateSpeed = percentage;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
