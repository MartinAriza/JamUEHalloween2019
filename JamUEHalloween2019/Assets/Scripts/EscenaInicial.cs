﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaInicial : MonoBehaviour
{
    public bool juego;
    public bool controles;
    public bool salir;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnMouseUp ()
    {
        if (juego)
        {
            SceneManager.LoadScene(1);
        }
        if (controles)
        {
            SceneManager.LoadScene(2);
        }
        if (salir)
        {
            Application.Quit();
        }
    }

}
