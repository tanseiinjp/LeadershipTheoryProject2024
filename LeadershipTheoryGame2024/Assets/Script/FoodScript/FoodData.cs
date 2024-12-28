using UnityEngine;
using Gamecore;

public class FoodData : MonoBehaviour
{
    public FoodStruct foodStruct;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foodStruct = new FoodStruct();
        FoodAttributeTable.AddStructProperty(gameObject.name);//添加FoodData并且分配Struct属性
        //Debug.Log("foodID：" + this.foodStruct.foodID);
        //Debug.Log("foodName：" + this.foodStruct.foodName);
        //Debug.Log("isCombine：" + this.foodStruct.isCombine);
        //Debug.Log("isUseTool：" + this.foodStruct.isUseTool);
        //Debug.Log("isJG：" + this.foodStruct.cs.isJG);
        //Debug.Log("isJBJ：" + this.foodStruct.cs.isJBJ);
        //Debug.Log("isTG：" + this.foodStruct.cs.isTG);
    }

    // Update is called once per frame
    void Update()
    {
        
    }   
}
