using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    private Slider progressBar; // ָ��UI������������
    private Transform ParentGo;
    private Text foodName_M;

    public float destroyTime = 5.0f; // ������Ʒ��ʧ��ʱ�䣨�룩

    //public float duration = 30f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        progressBar = this.transform.GetComponent<Slider>();
        ParentGo = progressBar.transform.parent;
        foodName_M = ParentGo.GetComponent<Text>();
        //this.StartCoroutine(Progress());
        
    }

    // Update is called once per frame
    void Update()
    {

      

    }
    //IEnumerator Progress()
    //{
    //    float timeElapsed = 0f;
    //    while (timeElapsed < duration)
    //    {
    //        this.progressBar.value = timeElapsed / duration;
    //        timeElapsed += Time.deltaTime;
    //        yield return null;
    //    }

    //    OrderManager.instance.OrderDelByProg(foodName_M.text);

    //}

    private void DelOrder()
    {
        OrderManager.instance.OrderDelByProg(foodName_M.text);
    }
}
