using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = "Alberico";
        int age = 34;

        var stringArray = new string[2];

        stringArray[0] = "Hello";
        stringArray[ 1] = "World";

        var frase = stringArray[0] + " " + stringArray[1];

        print(frase);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
