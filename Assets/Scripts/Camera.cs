using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject jogador;
    Vector3 diferencaBolaCamera;

    void Start () 
    {
        diferencaBolaCamera =
         jogador.transform.position - transform.position;
    }

    void LateUpdate() {
        transform.position =
          jogador.transform.position - diferencaBolaCamera;
    }

}
