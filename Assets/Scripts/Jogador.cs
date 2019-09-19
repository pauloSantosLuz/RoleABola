using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 forcaAplicada;

    public float intensidade = 6f;

   
    void Start()
    {
       rigidbody = GetComponent<Rigidbody>();
    }
  void FixedUpdate()
  {
      float horizontal = Input.GetAxis("Horizontal");
      float vertical = Input.GetAxis("Vertical");

      forcaAplicada = new Vector3(horizontal, 0f, vertical);

      rigidbody.AddForce(forcaAplicada * intensidade);
  }
}
