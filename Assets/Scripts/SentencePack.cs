using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Lines", menuName = "Continue/Lines")]

public class SentencePack: ScriptableObject
{
    [TextArea(3, 10)]
    [SerializeField]
    public List<string> Lines;




}
