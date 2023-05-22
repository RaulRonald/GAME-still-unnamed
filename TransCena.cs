using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransCena : MonoBehaviour
{
    public string nextscene;
    public void introductioncutscene()
    {
        gameObject.SetActive(false);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(nextscene);
    }
}
