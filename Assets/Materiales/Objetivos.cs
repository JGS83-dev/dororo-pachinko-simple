using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{
    [SerializeField]
    private int puntos;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Contador.contador += puntos;
    }
}
