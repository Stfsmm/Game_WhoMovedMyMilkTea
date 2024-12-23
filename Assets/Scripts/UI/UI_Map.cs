using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Map : MonoBehaviour
{
    public Button Btn_next;
    public TextMeshProUGUI line;
    public List<string> list = new List<string>();
    public int index = 0;
    public Transform I;
    public Transform Talk;
    public Button btn_Come;
    public UI_ChattingBox UI_ChattingBox;
    public void Init()
    {
        Hide();

        btn_Come.onClick.AddListener(() =>
        {
            Icome();
            Talkcome();
            Btn_next.gameObject.SetActive(true);
        });


        Btn_next.onClick.AddListener(() =>
        {
            ShowNextLine();
        });
    }
    void ShowNextLine()
    {
        if (index < list.Count)
        {
            line.text = list[index];
            index++;
        }
        else
        {
            GameMgr.I.window_moning.Show();
            GameMgr.I.map.Hide();
            UIMgr.I.ui_Window_Moring.Show();
            Hide();
        }

    }

    void Icome()
    {
        Vector3 endPos = new Vector3(-753, -346, 0);
        DOTween.Sequence()
            .Append(I.DOLocalMove(endPos, 0.5f))
            .AppendCallback(() =>
            {

            });

    }

    void Talkcome()
    {
        Vector3 endPos = new Vector3(-43, -302, 0);
        DOTween.Sequence()
            .Append(Talk.DOLocalMove(endPos, 0.5f))
            .AppendCallback(() =>
            {

            });

    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
