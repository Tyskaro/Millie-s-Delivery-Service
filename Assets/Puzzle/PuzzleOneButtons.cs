using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOneButtons : MonoBehaviour
{
    public PuzzleOne puzzleReference;
    public int buttonNumber;
public void Clicked()
    {
        if (puzzleReference.canClick)
        {
            print("Pode clicar");
            StartCoroutine(puzzleReference.SelectButton(buttonNumber));
        }
    }
}
