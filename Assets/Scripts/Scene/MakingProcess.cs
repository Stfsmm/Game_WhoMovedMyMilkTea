using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingProcess : MonoBehaviour
{
    public void Init()
    {
        Hide();
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
