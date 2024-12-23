using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Ending1 : MonoBehaviour
{
    public Button btn_next;
    public void Init()
    {
        Hide();

        btn_next.onClick.AddListener(() =>
        {
            Hide();
            GameMgr.I.startScene.Show();
            GameMgr.I.ending1.Hide();
            UIMgr.I.ui_StartScene.Show();

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
