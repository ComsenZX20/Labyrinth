using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccioncolisionpared : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;
    [SerializeField]
    Material materialParedTocada;
    bool paredRoja = false;
    float TiempoEnRojo = 5f;
    // Start is called before the first frame update
    
    // Update is called once per frame
    private void Update()
    {
         if (paredRoja == true)
        {
            TiempoEnRojo = TiempoEnRojo - Time.deltaTime;
            if (TiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;
                paredRoja = false;
                TiempoEnRojo = 5f;

            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;

        }paredRoja = true;
    }
}
