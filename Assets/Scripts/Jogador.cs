using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 forcaAplicada;

    public Text textoPlacar;
    public GameObject placarFimJogo;

    public float intensidade = 6f;
    int pontuacao = 0;

  void Update()
  {
    if(pontuacao == 8)
    {
      placarFimJogo.SetActive(true);
      return;
    }
  }   
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

  public void OnTriggerEnter(Collider collider)
  {
    Destroy(collider.gameObject);
    pontuacao ++;
    textoPlacar.text = "Placar: " + pontuacao.ToString();
  }
}
