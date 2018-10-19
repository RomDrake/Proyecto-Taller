using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio : MonoBehaviour
{
    private bool activeAgua;
    private bool activeBaba;
    private bool activeAcido;

    public bool ActiveAgua
    {
        get
        {
            return activeAgua;
        }

        set
        {
            activeAgua = value;
        }
    }

    public bool ActiveBaba
    {
        get
        {
            return activeBaba;
        }

        set
        {
            activeBaba = value;
        }
    }

    public bool ActiveAcido
    {
        get
        {
            return activeAcido;
        }

        set
        {
            activeAcido = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        ActiveAgua = true;
        ActiveBaba = false; 
        ActiveAcido = false; 
}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActiveAgua = true;
            ActiveBaba = false;
            ActiveAcido = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActiveAgua = false;
            ActiveBaba = true;
            ActiveAcido = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActiveAgua = false;
            ActiveBaba = false;
            ActiveAcido = true;
        }
    }
}
