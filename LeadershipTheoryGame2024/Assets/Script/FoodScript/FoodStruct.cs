using UnityEngine;
using UnityEngine.UI;

public struct FoodStruct
{
    public Image image;           //食物图片
    public bool isUseTool;        //是否使用工具
    public bool isCooked;         //是否进行过烹饪处理
    public bool isCombine;        //是否可以和其他食物结合
    public string foodName;       //食物名称
    public int foodID;            //食物ID

    public FoodStruct(Image image, bool isUseTool, bool isCooked, bool isCombine, string foodName, int foodID)
    { 
        this.image = image;
        this.isUseTool = isUseTool;
        this.isCooked = isCooked;
        this.isCombine = isCombine;
        this.foodName = foodName;
        this.foodID = foodID;
    }
}
