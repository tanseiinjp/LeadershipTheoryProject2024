using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


namespace GameCore 

{
    public class FoodAttributeTable //ʳ�����Ա����ڷ���ʳ���Struct����
    {
        
        //���FoodData���ҷ���Struct����
        public static void AddStructProperty( string childName)
        {
            GameObject go =GameObject.Find(childName) ; 
            CfgController.Instance.LoadAllCfg();
            FoodData foodData =go.GetComponent<FoodData>() ;
            int foodKey = ValueToFind(childName);//����ʳ����Ƕ���ֵ��е�key
            //����foodID
            foodData.foodStruct.foodID = int.Parse(CfgController.Instance.ReadCfg("ID", foodKey, CfgController.Instance.dicFood));
            //����foodName
            foodData.foodStruct.foodName = CfgController.Instance.ReadCfg("foodName", foodKey, CfgController.Instance.dicFood);
            //ȷ���Ƿ���
            if (int.Parse(CfgController.Instance.ReadCfg("isCombine", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.isCombine = true;
            }
            else
            {
                foodData.foodStruct.isCombine = false;
            }
            //ȷ���Ƿ�ʹ�ù���
            if (int.Parse(CfgController.Instance.ReadCfg("isUseTool", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.isUseTool = true;
            }
            else
            {
                foodData.foodStruct.isUseTool = false;
            }
            //ȷ���Ƿ�ʹ�ü��
            if (int.Parse(CfgController.Instance.ReadCfg("isJG", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.cs.isJG = true;
            }
            else
            {
                foodData.foodStruct.cs.isJG = false;
            }
            //ȷ���Ƿ�ʹ�ý����
            if (int.Parse(CfgController.Instance.ReadCfg("isJBJ", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.cs.isJBJ = true;
            }
            else
            {
                foodData.foodStruct.cs.isJBJ = false;
            }
            //ȷ���Ƿ�ʹ������
            if (int.Parse(CfgController.Instance.ReadCfg("isTG", foodKey, CfgController.Instance.dicFood)) == 1)
            {
                foodData.foodStruct.cs.isTG = true;
            }
            else
            {
                foodData.foodStruct.cs.isTG = false;
            }
        }
        public static int ValueToFind(string childName)//ֵ���Ҽ�
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
