using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public static UIMgr I;

    public UI_StartScene ui_StartScene;
    public UI_Introduce ui_Introduce;
    public UI_PlayPhone ui_PlayPhone;
    public UI_Map ui_Map;
    public UI_Window_moring ui_Window_Moring;
    public UI_MakingProcess uI_MakingProcess;
    public UI_Bill ui_Bill;
    public UI_Ending1 ui_Ending1;
    public UI_Ending2 ui_Ending2;

    void Awake()
    {
        I = this;
        InitAll();
    }
    void InitAll()
    {
        ui_StartScene.Init();
        ui_Introduce.Init();
        ui_PlayPhone.Init();
        ui_Map.Init();
        ui_Window_Moring.Init();
        uI_MakingProcess.Init();
        ui_Bill.Init();
        ui_Ending1.Init();
        ui_Ending2.Init();
    }
}
