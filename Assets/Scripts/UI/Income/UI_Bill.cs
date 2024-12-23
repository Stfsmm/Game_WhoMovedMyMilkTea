using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class UI_Bill : MonoBehaviour
{
    public Button btn_next;
    public Button btn_talk;
    public List<string> list = new List<string>();
    public int index = 0;
    //public Transform Talk;
    public Image chatimage;
    public TextMeshProUGUI line;
    public TextMeshProUGUI tmp_income;
    public TextMeshProUGUI tmp_market;
    public TextMeshProUGUI tmp_rents;
    public TextMeshProUGUI tmp_costs;
    public TextMeshProUGUI tmp_sell;

    public int times = 0;//The counting time with the day.
    public bool hasPurchasedApp = false;

    public void Init()
    {
        Hide();

        btn_talk.onClick.AddListener(() =>
        {
            if (times == 0) 
            {
                chatimage.gameObject.SetActive(true);
                
                if (hasPurchasedApp)
                {
                    index = 1;
                    line.text = list[index];
                    line.gameObject.SetActive(true);
                    btn_talk.gameObject.SetActive(false);
                }
                else
                {
                    index = 0;
                    line.text = list[index];
                    line.gameObject.SetActive(true);
                    btn_talk.gameObject.SetActive(false);
                }
                //return ;

            }

            if (times == 1)
            {
                chatimage.gameObject.SetActive(true);
                if (hasPurchasedApp)
                {
                    index = 3;
                    line.text = list[index];
                    line.gameObject.SetActive(true);
                    btn_talk.gameObject.SetActive(false);
                }
                else
                {
                    index = 2;
                    line.text = list[index];
                    line.gameObject.SetActive(true);
                    btn_talk.gameObject.SetActive(false);
                }
                //return ;
            }

            if (times == 2)
            {
                chatimage.gameObject.SetActive(true);
                if (hasPurchasedApp)
                {
                    index = 5;
                    line.text = list[index];
                    line.gameObject.SetActive(true);
                    btn_talk.gameObject.SetActive(false);
                }
                else
                {
                    index = 4;
                    line.text = list[index];
                    line.gameObject.SetActive(true);
                    btn_talk.gameObject.SetActive(false);
                }
                //return ;
            }


        });

        btn_next.onClick.AddListener(() =>
        {

            Hide();
            var list2 = UIMgr.I.ui_Window_Moring.custGroup.list_customers2;
            var list3 = UIMgr.I.ui_Window_Moring.custGroup.list_customers3;
            //List < Customer > customers = new List < Customer >();
            //UIMgr.I.ui_Window_Moring.ResetScene(list2);

            times++;
            GameMgr.I.bill.Hide();
            
            if (times == 1)
            {

                GameMgr.I.Window_Spring.Hide();
                GameMgr.I.Window_Winter.Show();
                UIMgr.I.ui_Window_Moring.Show();
                UIMgr.I.ui_Window_Moring.ResetScene(list2);
                //return;
            }
   
            if (times == 2)
            {
                GameMgr.I.Window_Spring.Show();
                UIMgr.I.ui_Window_Moring.Show();
                UIMgr.I.ui_Window_Moring.ResetScene(list2);
                //return;
            }

            if (times == 3)
            {
                if (hasPurchasedApp)
                {
                    UIMgr.I.ui_Window_Moring.Hide();
                    GameMgr.I.Window_Spring.Hide();
                    GameMgr.I.Window_Winter.Hide();
                    GameMgr.I.ending1.Show();
                    UIMgr.I.ui_Ending1.Show();
                }
                else
                {
                    UIMgr.I.ui_Window_Moring.Hide();
                    GameMgr.I.Window_Winter.Hide();
                    GameMgr.I.Window_Spring.Hide();
                    GameMgr.I.ending2.Show();
                    UIMgr.I.ui_Ending2.Show();
                }
                
            }

        });
    }
    public void Show()
    {
        SetProfitValue();
        gameObject.SetActive(true);
        chatimage.gameObject.SetActive(false);
        line.gameObject.SetActive(false);
        btn_talk.gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    void SetProfitValue()
    {
        //If purchase the application.
        if (hasPurchasedApp)
        {
            //isBuyApp = false;
            if (times == 0) ;
            {
                int sells = Random.Range(9000, 9999);
                int market = Random.Range(1000, 1100);
                int rents = Random.Range(1000, 1100);
                int cost = Random.Range(1000, 1200);
                int income = sells - market - rents - cost;

                tmp_costs.text = cost.ToString();
                tmp_sell.text = sells.ToString();
                tmp_rents.text = rents.ToString();
                tmp_market.text = market.ToString();

                tmp_income.text = income.ToString();
                return;

            }
            if (times == 1) ;
            {
                int sells = Random.Range(6000, 7000);
                int market = Random.Range(1000, 1100);
                int rents = Random.Range(1000, 1100);
                int cost = Random.Range(1000, 1200);
                int income = sells - market - rents - cost;

                tmp_costs.text = cost.ToString();
                tmp_sell.text = sells.ToString();
                tmp_rents.text = rents.ToString();
                tmp_market.text = market.ToString();

                tmp_income.text = income.ToString();
                return;
            }

            if (times == 2) ;
            {
                int sells = Random.Range(4000, 5000);
                int market = Random.Range(1000, 1100);
                int rents = Random.Range(1000, 1100);
                int cost = Random.Range(1000, 1200);
                int income = sells - market - rents - cost;

                tmp_costs.text = cost.ToString();
                tmp_sell.text = sells.ToString();
                tmp_rents.text = rents.ToString();
                tmp_market.text = market.ToString();

                tmp_income.text = income.ToString();
                return;

            }

        }

        if (times == 0)
        {
            int sells = Random.Range(6000, 7000);
            int market = Random.Range(0, 0);
            int rents = Random.Range(1000, 1100);
            int cost = Random.Range(1000, 1200);
            int income = sells - market - rents - cost;

            tmp_costs.text = cost.ToString();
            tmp_sell.text = sells.ToString();
            tmp_rents.text = rents.ToString();
            tmp_market.text = market.ToString();

            tmp_income.text = income.ToString();

            return;
        }

        if (times == 1)
        {
            int sells = Random.Range(3000, 4000);
            int market = Random.Range(0, 0);
            int rents = Random.Range(1000, 1100);
            int cost = Random.Range(1000, 1200);
            int income = sells - market - rents - cost;

            tmp_costs.text = cost.ToString();
            tmp_sell.text = sells.ToString();
            tmp_rents.text = rents.ToString();
            tmp_market.text = market.ToString();

            tmp_income.text = income.ToString();

            return;
        }

        if (times == 2)
        {
            int sells = Random.Range(1000, 2000);
            int market = Random.Range(0, 0);
            int rents = Random.Range(1000, 1100);
            int cost = Random.Range(1000, 1200);
            int income = sells - market - rents - cost;

            tmp_costs.text = cost.ToString();
            tmp_sell.text = sells.ToString();
            tmp_rents.text = rents.ToString();
            tmp_market.text = market.ToString();

            tmp_income.text = income.ToString();

            return;
        }
    }
}
