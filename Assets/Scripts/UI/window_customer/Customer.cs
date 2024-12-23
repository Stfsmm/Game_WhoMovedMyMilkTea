using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    public UI_Window_moring ui_window;
    public UI_ChattingBox chatBox;
    public List<string> list_lines = new List<string>();
    public int index_line = 0;
    public float offStageX;
    public float onStageX;
    public Button Btn_Next;

    public void Init()
    {
        this.transform.localPosition = new Vector3(offStageX, -145, 0);
        index_line = 0;
    }
    public void Enter()
    {
        //TODO
        DOTween.Sequence()
               .Append(this.transform.DOLocalMoveX(onStageX, 1f))
               .AppendCallback(() =>
               {
                ShowNextLine();
                chatBox.Show();
               });
    }

    public void ShowNextLine()
    {
        if (index_line < list_lines.Count)
        {
            chatBox.ShowLine(list_lines[index_line]);
            index_line++;
        }
        //else
        //{
        //    Exit();
        //    //ui_window.index_Customer++;
        //}
    }
    public bool isEndLine()
    {
        if (index_line >= list_lines.Count)
            chatBox.Hide();
        return false;

        return true;
    }

    public void Exit()
    {
        DOTween.Sequence()
           .InsertCallback(0.0001f, () =>
           {
               chatBox.Hide();
               //Btn_Next.gameObject.SetActive(false);    
               //TODO£ºHide next button.
           })
           .Append(this.transform.DOLocalMoveX(offStageX, 1f))
           .AppendCallback(() =>
           {
               //Btn_Next.gameObject.SetActive(true);
               //TODO: Show next button.
           })
           ;
    }

    void Show()
    {
        gameObject.SetActive(true);
    }
    void Hide()
    {
        gameObject.SetActive(false);
    }




}
