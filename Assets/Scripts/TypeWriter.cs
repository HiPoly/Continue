using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    public float TypeSpeed = 0.1f;
    public string FullText;
    private string CurrentText;

    private void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for(int i = 0; i < FullText.Length; i++)
        {
            CurrentText = FullText.Substring(0, i);
            //GetComponent<Text>() = CurrentText;
            yield return new WaitForSeconds(TypeSpeed);
        }
    }
}
