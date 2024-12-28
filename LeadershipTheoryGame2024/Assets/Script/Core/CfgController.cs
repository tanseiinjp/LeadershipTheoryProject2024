using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameCore;
//���ݱ��ȡ
public class CfgController : Singleton<CfgController>
{
    public Dictionary<string, Dictionary<string, string>> dicFood;

    public void LoadAllCfg()
    {
        LoadFoodCfg();
    }
    private void LoadFoodCfg()
    {
        ExcelData.LoadExcelFormCSV("FoodCfg", out dicFood);
    }
    //��ȡ���ñ��ֶ�
    public string ReadCfg(string keyName, int ID  , Dictionary<string, Dictionary<string, string>> dic)
    {
        return dic[keyName][ID.ToString()];
    }
}
