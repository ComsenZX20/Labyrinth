using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculorotatorio : MonoBehaviour
{ [SerializeField]
    float RotacionX = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //funcion que permitir� la rotacion del obst�culo
        transform.Rotate(0.0f, RotacionX * Time.deltaTime, 0f);
    }
}
