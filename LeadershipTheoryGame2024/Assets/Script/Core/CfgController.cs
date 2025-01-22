using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameCore;
//数据表读取
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
    //读取配置表字段
    public string ReadCfg(string keyName, int ID  , Dictionary<string, Dictionary<string, string>> dic)
    {
        return dic[keyName][ID.ToString()];
    }
}
