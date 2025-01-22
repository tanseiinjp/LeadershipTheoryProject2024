using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CombineMeunOS", menuName = "Scriptable Objects/CombineMeunOS")]
public class CombineMeunOS : ScriptableObject
{
    public string foodName;
    public Sprite foodSprite;

    public List<FoodMeunOS> foodMeunOsList;
}
