using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        // a camera ira buscar o jogador em cena e ira acompanha-lo
        gameObject.transform.position = new Vector3(Player.GetComponent<Transform>().position.x, GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.y, gameObject.transform.position.z);
    }
}
