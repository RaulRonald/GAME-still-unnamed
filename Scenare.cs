using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenare : MonoBehaviour
{
    public float vel, posxi,posxf; 
    void FixedUpdate()
    {
        if(gameObject.GetComponent<Transform>().position.x <= posxf) {
        gameObject.GetComponent<Transform>().position = new Vector3(posxi , gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z); }
        gameObject.GetComponent<Transform>().position = new Vector3(gameObject.GetComponent<Transform>().position.x - (vel * Time.deltaTime), gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z); 
        
    }
}
