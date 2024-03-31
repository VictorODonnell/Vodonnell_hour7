using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    private int even; // Declare even as a member variable of the class

    // Start is called before the first frame update
    void Start()
    {
        even = 0; // Initialize even in the Start method
    }

    // Update is called once per frame
    void Update()
    {
        even += 2;
        Debug.Log("Number is " + even); // Access even within the Update method
    }
}
