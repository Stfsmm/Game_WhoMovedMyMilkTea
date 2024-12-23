using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class UI_Introduce : MonoBehaviour
{
    public Button btn_Next;
    public TextMeshProUGUI line;
    public List<string> list = new List<string>();
    public int index = 0;
    public Transform I;
    public Button btn_Come;
    public Image talkimage;
    public void Init()
    {
        Hide();
        //line.text = list[index];

        btn_Come.onClick.AddListener(() =>
        {
            Icome();
            talkimage.gameObject.SetActive(true);
            btn_Next.gameObject.SetActive(true);

        });

        btn_Next.onClick.AddListener(() => 
        {
           ShowNextLine();
        });
    }

    void Icome()
    {
        Vector3 endPos = new Vector3(-520, -130, 0);
        DOTween.Sequence()
            .Append(I.DOLocalMove(endPos, 0.5f))
            .AppendCallback(() =>
            {
              
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
            GameMgr.I.playPhone.Show();
            GameMgr.I.introduce.Hide();
            UIMgr.I.ui_PlayPhone.Show();
            Hide();
        }
        
    }



    public void Show()
    {
        gameObject.SetActive(true);
       
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }

   



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
