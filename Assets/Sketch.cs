using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        int totalCubes = 30;
        float totalDistance = 2.9f;

        for (int i = 0; i < totalCubes; i++)
        {
            float percentage = i / (float)totalCubes;
            float sin = Mathf.Sin(percentage * Mathf.PI / 2);

            float x = 1.8f + sin * totalDistance;
            float y = 5.0f;
            float z = 0.0f;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);

            newCube.GetComponent<CubeScript>().SetSize(0.45f * (1.0f - percentage));
            newCube.GetComponent<CubeScript>().rotateSpeed = 0.2f + percentage * 4.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
