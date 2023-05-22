using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool sceneiscutscene;
    private float Timer;
    public float TimerCutScene;
    public GameObject TransiCena;
    void Update(){
        if (sceneiscutscene == true) {
            Timer += Time.deltaTime;
            if (Timer >= TimerCutScene){
                TransiCena.SetActive(true);
            }
        }
    }
}
