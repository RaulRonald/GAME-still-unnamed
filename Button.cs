using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject Beforetela, Aftertela;
    public void NextTela()
    {
        Aftertela.SetActive(true);
        Beforetela.SetActive(false);
    }
    public string nextscene;
    public void NextScene()
    {
        SceneManager.LoadScene(nextscene);
    }
}
