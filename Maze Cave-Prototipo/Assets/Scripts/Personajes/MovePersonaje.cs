using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonaje : MonoBehaviour
{
    public float speed = 4f;
    public Cambio cambioPersonaje;
    Transform agua;
    Transform baba;
    Transform acido;
    void Start()
    {
        cambioPersonaje = GetComponent<Cambio>();
        agua =  GameObject.FindWithTag("Agua").GetComponent<Transform>();
        baba = GameObject.FindWithTag("Baba").GetComponent<Transform>();
        acido = GameObject.FindWithTag("Acido").GetComponent<Transform>();
    }
    void Update()
    {
        if (cambioPersonaje.ActiveAgua && agua.CompareTag("Agua"))
        {
            Vector3 mov = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            agua.position = Vector3.MoveTowards(agua.position, agua.position + mov, speed * Time.deltaTime);
        }
        if (cambioPersonaje.ActiveBaba && baba.CompareTag("Baba"))
        {
            Vector3 mov = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            baba.position = Vector3.MoveTowards(baba.position, baba.position + mov, speed * Time.deltaTime);
        }
        if (cambioPersonaje.ActiveAcido && acido.CompareTag("Acido"))
        {
            Vector3 mov = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            acido.position = Vector3.MoveTowards(acido.position, acido.position + mov, speed * Time.deltaTime);
        }
    }
}
