using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ChattingBox : MonoBehaviour
{
    public TextMeshProUGUI tmp_chatBox;
    public Image box;
    public Button btn_Yes;
    public Button btn_No;
    public Image makingprocess;

    public void Init()
    {
        Hide();
        tmp_chatBox.text = string.Empty;

        btn_Yes.onClick.RemoveAllListeners();
        btn_Yes.onClick.AddListener(() =>
        {
            if (UIMgr.I.ui_Window_Moring.GetCurtCustomer().gameObject.name 
            =="UI_Window_Owlboss")
            {
                UIMgr.I.ui_Bill.hasPurchasedApp = true;
                return;

            }
            makingprocess?.gameObject.SetActive(true);
            UIMgr.I.uI_MakingProcess.Show();
        });
    }
    public void ShowLine(string line)
    {
        tmp_chatBox.text = line;
    }

    public void Show() 
    {
        gameObject.SetActive(true);
        if (UIMgr.I.ui_Window_Moring.GetCurtCustomer().gameObject.name == "UI_Window_Dogboss")
        {
            btn_No.gameObject.SetActive(false);
            btn_Yes.gameObject.SetActive(false);
        }
        else
        {
            btn_No.gameObject.SetActive(true);
            btn_Yes.gameObject.SetActive(true);
        }
    }
    public void Hide() 
    {
        gameObject.SetActive(false);
    }
}
