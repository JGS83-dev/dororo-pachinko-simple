using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminador : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Contador.dororosEliminados += 1;
    }
}
