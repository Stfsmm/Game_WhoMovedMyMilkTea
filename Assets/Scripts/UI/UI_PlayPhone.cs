using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_PlayPhone : MonoBehaviour
{
    public Button btn_PlayPhone_App;
    public Transform hand;
    public Button btn_next;
    public void Init()
    {
        Hide();

        btn_PlayPhone_App.onClick.AddListener(() =>
        {
            ClickApp();
            /*/
            Hide();
            GameMgr.I.map.Show();
            GameMgr.I.playPhone.Hide();
            UIMgr.I.ui_Map.Show();
            //*/
        });

    }

    void ClickApp() 
    {
        Vector3 endPos = new Vector3(242,-410,0);
        DOTween.Sequence()
            .Append(hand.DOLocalMove(endPos,0.5f))
            .AppendCallback(() => 
            {
                Hide();
                GameMgr.I.map.Show();
                GameMgr.I.playPhone.Hide();
                UIMgr.I.ui_Map.Show();
                btn_next.gameObject.SetActive(false);
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
