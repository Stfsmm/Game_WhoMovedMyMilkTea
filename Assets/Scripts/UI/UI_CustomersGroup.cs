using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_CustomersGroup : MonoBehaviour
{
    public List<Customer> list_customers = new List<Customer>();
    public List<Customer> list_customers2 = new List<Customer>();
    public List<Customer> list_customers3 = new List<Customer>();

    public void Init()
    {
        foreach (var customer in list_customers)
        {
            customer.Init();
        }
    }
    public void SetCustomerList(List<Customer> list) 
    {
        foreach (var customer in list)
        {
            customer.Init();
        }
    }
}
