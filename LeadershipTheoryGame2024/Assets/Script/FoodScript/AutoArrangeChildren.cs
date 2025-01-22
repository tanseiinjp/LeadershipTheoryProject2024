using System;
using UnityEngine;

public class AutoArrangeChildren : MonoBehaviour
{
<<<<<<< HEAD
    public float objScale = 0.2f, spaceing = 1.5f;

    int objCount = 0;
=======
    public float spacing = 0.001f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ArrangeChildren();
    }
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d

    public void ArrangeChildren()
    {
        Transform[] children = GetComponentsInChildren<Transform>();
        float offsetX = 0.0f;
<<<<<<< HEAD
        //objCount++;
        foreach (Transform child in children)
        {
            if (child == transform) continue;  //堦夞栚偼壗傕偟側偄

            Vector3 newPosition = new Vector3(offsetX, 0, 0);
            child.localPosition = newPosition;
            child.localScale = new Vector3(objScale, objScale, 1f);
            offsetX += spaceing;
=======

        foreach (Transform child in children)
        {
            if (child == transform) continue; // 跳过父物体本身

            Vector3 newPosition = new Vector3(offsetX, 0, 0);
            child.localPosition = newPosition;
            offsetX += child.GetComponent<Renderer>().bounds.size.x + spacing;
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
        }
    }
}
