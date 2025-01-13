using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "FoodListOS", menuName = "Scriptable Objects/FoodListOS")]
public class FoodListOS : ScriptableObject
{
    public List<CombineMeunOS> combineMeunList;
}
