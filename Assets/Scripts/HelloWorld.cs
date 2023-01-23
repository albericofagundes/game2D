using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public List<string> lista = new List<string>();
    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        lista.Add("Hello");

        lista.Add("World");

 




        print(lista[0] + " " + lista[1]);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3( velocidade , 0 , transform.position.z )* Time.deltaTime );

        
    }
}
