using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


namespace GameCore 

{
    public class FoodAttributeTable //食物属性表，用于分配食物的Struct属性
    {
        
        //添加FoodData并且分配Struct属性
        public static void AddStructProperty( string childName)
        {
            GameObject go =GameObject.Find(childName) ; 
            CfgController.Instance.LoadAllCfg();
            FoodData foodData =go.GetComponent<FoodData>() ;
            int foodKey = ValueToFind(childName);//查找食物在嵌套字典中的key
            //分配foodID
            foodData.foodStruct.foodID = int.Parse(CfgController.Instance.ReadCfg("ID", foodKey, CfgController.Instance.dicFood));
            //分配foodName
            foodData.foodStruct.foodName = CfgController.Instance.ReadCfg("foodName", foodKey, CfgController.Instance.dicFood);
            //确定是否结合
            if (int.Parse(CfgController.Instance.ReadCfg("isCombine", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.isCombine = true;
            }
            else
            {
                foodData.foodStruct.isCombine = false;
            }
            //确定是否使用工具
            if (int.Parse(CfgController.Instance.ReadCfg("isUseTool", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.isUseTool = true;
            }
            else
            {
                foodData.foodStruct.isUseTool = false;
            }
            //确定是否使用煎锅
            if (int.Parse(CfgController.Instance.ReadCfg("isJG", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.cs.isJG = true;
            }
            else
            {
                foodData.foodStruct.cs.isJG = false;
            }
            //确定是否使用搅拌机
            if (int.Parse(CfgController.Instance.ReadCfg("isJBJ", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.cs.isJBJ = true;
            }
            else
            {
                foodData.foodStruct.cs.isJBJ = false;
            }
            //确定是否使用汤锅
            if (int.Parse(CfgController.Instance.ReadCfg("isTG", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.cs.isTG = true;
            }
            else
            {
                foodData.foodStruct.cs.isTG = false;
            }
        }
        public static int ValueToFind(string childName)//值查找键
        {
            foreach (var outerKVP in CfgController.Instance.dicFood)
            {
                foreach (var innerKVP in outerKVP.Value)
                {
                    if (innerKVP.Value==childName)
                    {
                        return int.Parse(innerKVP.Key) ;
                    }
                }
            }
            return 0;            
        }

    }
}
