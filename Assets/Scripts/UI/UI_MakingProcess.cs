using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class UI_MakingProcess : MonoBehaviour
{
    public Button btn_next;
    public UI_Window_moring uI_Window_Moring;
    public Image makingprocess;
    public float offStageX;
    public void Init()
    {
        Hide();

        btn_next.onClick.AddListener(() =>
        {
            Hide();
            makingprocess.gameObject.SetActive(false);
            uI_Window_Moring.gameObject.SetActive(true);
            Exit();
           
            //GameMgr.I.window_moning.Show();
            //GameMgr.I.makingProcess.Hide();
            //UIMgr.I.ui_Window_Moring.Show();
            //UIMgr.I.uI_MakingProcess.Hide();
        });
    }

    public void Exit()
    {
        DOTween.Sequence()
           .InsertCallback(0.0001f, () =>
           {

           })
           .Append(this.transform.DOLocalMoveX(offStageX, 1f))
           .AppendCallback(() =>
           {
               //Btn_Next.gameObject.SetActive(true);
               //TODO: Show next button.
           })
           ;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
   
}
