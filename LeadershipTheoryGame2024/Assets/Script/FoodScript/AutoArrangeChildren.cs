using System;
using UnityEngine;

public class AutoArrangeChildren : MonoBehaviour
{
    public float objScale = 0.2f, spaceing = 1.5f;

    int objCount = 0;

    public void ArrangeChildren()
    {
        Transform[] children = GetComponentsInChildren<Transform>();
        float offsetX = 0.0f;
        //objCount++;
        foreach (Transform child in children)
        {
            if (child == transform) continue;  //ˆê‰ñ–Ú‚Í‰½‚à‚µ‚È‚¢

            Vector3 newPosition = new Vector3(offsetX, 0, 0);
            child.localPosition = newPosition;
            child.localScale = new Vector3(objScale, objScale, 1f);
            offsetX += spaceing;
        }
    }
}
