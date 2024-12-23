using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    #region
    public static GameMgr I;

    public StartScene startScene;
    public Introduce introduce;
    public PlayPhone playPhone;
    public Map map;
    public Window_moning window_moning;
    public Window_Winter Window_Winter;
    public Window_Spring1 Window_Spring;
    public Winter_Summer Winter_Summer;
    
    //public MakingProcess makingProcess;
    public Bill bill;
    public Ending1 ending1;
    public Ending2 ending2;
    #endregion

    void Awake()
    {
        I = this;
        InitAll();
    }
    void InitAll()
    {
        startScene.Init();
        introduce.Init();
        playPhone.Init();
        map.Init();
        window_moning.Init();
        Window_Winter.Init();
        Window_Spring.Init();
        Winter_Summer.Init();
        //makingProcess.Init();
        bill.Init();
        ending1.Init();
        ending2.Init();
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
