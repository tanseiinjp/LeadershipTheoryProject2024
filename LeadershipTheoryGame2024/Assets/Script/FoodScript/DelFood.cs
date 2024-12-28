using System;
using UnityEngine;
using static Unity.VisualScripting.Metadata;

public class DelFood : MonoBehaviour
{
    bool isDelFood = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isDelFood)
        {
            DelFoods();
        }
    }

    private void DelFoods()
    {
        GameObject go = GameObject.Find("ParentGo");
        Transform parentGo = go.transform;
        Transform [] childs =parentGo.GetComponentsInChildren<Transform>();
        if (go != null)
        {
            // 遍历所有子物体并销毁它们
            foreach (Transform child in childs)
            {
                if (child !=go.transform) // 确保不销毁父物体本身
                {
                    Destroy(child.gameObject);
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isDelFood = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isDelFood = false;
        }
    }
}
