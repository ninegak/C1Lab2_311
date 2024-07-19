using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheRIng : MonoBehaviour
{
    // Start is called before the first frame update

    public int numberOfObjects; // Example value, change as needed
    public float radius;        // Example value, change as needed
    public GameObject prefab;

    void make_circle()
    {
        // Degrees-to-radians conversion constant (Read Only).
        // This is equal to (PI * 2) / 360.

        float angle = 360f / numberOfObjects;
        for (int i = 0; i < numberOfObjects; i++)
        {
            float x = Mathf.Sin(Mathf.Deg2Rad * angle * i) * radius;
            float z = Mathf.Cos(Mathf.Deg2Rad * angle * i) * radius;
            Vector3 position = new Vector3(x, 0.5f, z);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    void Start()
    {
        this.make_circle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
