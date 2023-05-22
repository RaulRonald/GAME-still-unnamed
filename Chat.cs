using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : MonoBehaviour
{
    public string[] texts;
    public Text texto;
    private void Start()
    {
        StartCoroutine(EsperarContagem());
    }
    IEnumerator EsperarContagem()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            for (int j = 0; j < texts[i].Length; j++)
            {
                texto.text = texto.text + texts[i][j];
                yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitForSeconds(2);
            texto.text = "";
        }
    }

}
