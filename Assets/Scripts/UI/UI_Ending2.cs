using DG.Tweening;
//using Microsoft.Unity.VisualStudio.Editor;
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class UI_Ending2 : MonoBehaviour
{
    public Transform endimage;
    public void Init()
    {
        Hide();
    }

    void Endcome()
    {
        Vector3 endPos = new Vector3(0, -801, 0);
        DOTween.Sequence()
            .Append(endimage.DOLocalMove(endPos, 0.5f))
            .AppendCallback(() =>
            {

            });

    }
    public void Show()
    {
        gameObject.SetActive(true);
        Endcome();
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
