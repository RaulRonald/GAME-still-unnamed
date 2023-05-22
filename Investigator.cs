using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investigator : MonoBehaviour
{
    float temporizador;
    Animator anim;
    public float speed;
    static float InvestigatorPositionX;
    static float InvestigatorPositionY;


    //essa fun��o servir� para alterar a posi��o do "Investigator" durante a transi��o de cenas
    public void SetInvestigatorPosition(float InvPointX, float InvPointY)
    {
        InvestigatorPositionX = InvPointX;
        InvestigatorPositionY = InvPointY;
    }
    void Start()
    {
        //atribui��es
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        running();
        move();
    }
    public void running()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            speed = speed * 1.5f;
        }
        else
            if (Input.GetKeyUp(KeyCode.J))
        {
            speed = speed/1.5f;
        }
    }
    //essa fun��o serve para dizer como se comportara a movimenta��o do Investigator
    public void move()
    {
        //velocidade com base nas setas
        if (Input.GetAxis("Horizontal") == 1)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        else
        if (Input.GetAxis("Horizontal") == -1)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        else
        if (Input.GetAxis("Vertical") == 1)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + speed * Time.deltaTime, gameObject.transform.position.z);
        else
        if (Input.GetAxis("Vertical") == -1)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - speed * Time.deltaTime, gameObject.transform.position.z);
        else
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

        //direita
        if (Input.GetAxis("Horizontal") == 1)
        {
            anim.SetBool("horizontal", true);
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else
        //esquerda
        if (Input.GetAxis("Horizontal") == -1)
        {
            anim.SetBool("horizontal", true);
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        //cima
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 1)
        {
            anim.SetBool("horizontal", false);
            anim.SetBool("up", true);
            anim.SetBool("down", false);
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        //baixo
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == -1)
        {
            anim.SetBool("horizontal", false);
            anim.SetBool("up", false);
            anim.SetBool("down", true);
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        //parado
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            anim.SetBool("horizontal", false);
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
