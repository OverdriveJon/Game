using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Displayer : MonoBehaviour
{
    public TextMeshProUGUI _textDisplay;
    public string _words;
    private int index;

   
    public void Type(string words)
	{
        _words = words;
        _textDisplay.SetText(words);
	}
}
