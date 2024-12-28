using System;
using UnityEngine;

public class AutoArrangeChildren : MonoBehaviour
{
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

    public void ArrangeChildren()
    {
        Transform[] children = GetComponentsInChildren<Transform>();
        float offsetX = 0.0f;

        foreach (Transform child in children)
        {
            if (child == transform) continue; // 跳过父物体本身

            Vector3 newPosition = new Vector3(offsetX, 0, 0);
            child.localPosition = newPosition;
            offsetX += child.GetComponent<Renderer>().bounds.size.x + spacing;
        }
    }
}
