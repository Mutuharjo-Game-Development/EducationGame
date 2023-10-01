using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour
{
    public List<bool> answerList;

    public static ButtonFunction instance;

    private void Awake()
    {
        if (!instance)
            instance = this;
    }
    public void SubmitButton()
    {
        if (answerList.Contains(false))
        {
            Debug.Log("Jawaban Salah, Ulangi lagi");
            ResetButton();
        }
        else if (answerList.Count == 0)
        {
            Debug.Log("Anda belum mencocokkan jawaban");
        }
        else
        {
            Debug.Log("Jawaban Benar");
        }
    }
    public void ResetButton()
    {
        answerList.Clear();
        foreach (DragAndDrop dragItem in FindObjectsByType<DragAndDrop>(FindObjectsSortMode.None))
            dragItem.ResetPosition();

        foreach (DropPlace dropPlace in FindObjectsByType<DropPlace>(FindObjectsSortMode.None))
            dropPlace.ResetData();
    }
}