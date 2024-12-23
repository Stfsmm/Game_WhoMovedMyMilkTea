using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class UI_StartScene : MonoBehaviour
{
    public Button btn_Start;
    public Transform title;
    public Transform hand;
    public Image talkimage;
    public Button btn_next;
    public void Init()
    {
        Show();
        titlecome();
        handcome();
        
        btn_Start.onClick.AddListener(() => 
        {
            Hide();
            GameMgr.I.introduce.Show();
            GameMgr.I.startScene.Hide();
            UIMgr.I.ui_Introduce.Show();
            talkimage.gameObject.SetActive(false);
            btn_next.gameObject.SetActive(false);   

        });
    }

    void titlecome()
    {
        Vector3 endPos = new Vector3(-445, 295, 0);
        DOTween.Sequence()
            .Append(title.DOLocalMove(endPos, 0.8f))
            .AppendCallback(() =>
            {

            });

    }

    void handcome()
    {
        Vector3 endPos = new Vector3(642, -198, 0);
        DOTween.Sequence()
            .Append(hand.DOLocalMove(endPos, 0.8f))
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
