using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_moring : MonoBehaviour
{
    public Button btn_next;
    public TextMeshProUGUI line;
    public UI_CustomersGroup custGroup;
    public UI_ChattingBox chatBox;
    public UI_ChattingBox chatBox2;
    public List<Customer> list_Customers;
    Customer curtCustomer;
    public int index_Customer = 0;
    public Button Btn_GoBack;

    public void Init()
    {
        curtCustomer = list_Customers[index_Customer];
        custGroup.Init();
        chatBox.Init();
        chatBox2.Init();
        list_Customers = custGroup.list_customers;

        Btn_GoBack.gameObject.SetActive(false);
        Hide();
        chatBox.Hide();

        btn_next.onClick.AddListener(() =>
        {
            //customer enter & talking
            //if (this cust's end of line) exit, next customer
            //if (last customer) leave this scene.

            if (index_Customer < list_Customers.Count)
            {
                curtCustomer = list_Customers[index_Customer];
               
                Btn_GoBack.gameObject.SetActive(true);
                curtCustomer.Enter();

                index_Customer++;

                Btn_GoBack.onClick.RemoveAllListeners();
                Btn_GoBack.onClick.AddListener(() =>
                {
                    curtCustomer.Exit();
                    Btn_GoBack.gameObject.SetActive(false);
                });
            }
            else
            {
                GameMgr.I.bill.Show();
                GameMgr.I.window_moning.Hide();
                UIMgr.I.ui_Bill.Show();
                Hide();
            }

        });
    }

    void NextCutomer()
    {
        //Get a customer from the list_customer.
        if (index_Customer < list_Customers.Count)
        {
            var curtCustomer = list_Customers[index_Customer];
            curtCustomer.Enter();
        }
        index_Customer++;

        //Move it and show the chatbox.
        //The behaviour is on the customer instance.
    }

    public Customer GetCurtCustomer() 
    {
        if (curtCustomer is not null)
        {
            return curtCustomer;
        }
        else 
        {
            print("There is no customer.");
            return null;
        }
    }

    public void ResetScene(List<Customer> list)
    {
        //list_Customers = custGroup.list_customers2;
        //curtCustomer.Init();
        custGroup.Init();
        chatBox.Init();
        list_Customers = list;

        Btn_GoBack.gameObject.SetActive(false);
        chatBox.Hide();

        index_Customer = 0;
        curtCustomer = list[index_Customer];

        btn_next.onClick.RemoveAllListeners();
        btn_next.onClick.AddListener(() =>
        {
            if (index_Customer < list.Count)
            {
                Customer customer = list_Customers[index_Customer];
                //if (customer == curtCustomer)
                Btn_GoBack.gameObject.SetActive(true);
                customer.Enter();

                index_Customer++;

                Btn_GoBack.onClick.AddListener(() =>
                {
                    customer.Exit();
                    Btn_GoBack.gameObject.SetActive(false);
                });


            }
            else
            {
                GameMgr.I.bill.Show();
                UIMgr.I.ui_Bill.Show();
                UIMgr.I.ui_Window_Moring.Hide();
                Hide();

                var times = UIMgr.I.ui_Bill.times;
                if (times == 1) ;
                {
                    GameMgr.I.Window_Winter.Hide();
                    //return;
                }

                if (times == 2) ;
                {
                    GameMgr.I.Window_Spring.Hide();
                    //return;
                }

                
            }
        });
    }

    public void Show()
    {
        gameObject.SetActive(true);
        NextCutomer();

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
