using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
namespace Gamecore
=======
namespace GameCore
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
{
    public struct FoodStruct
    {
        public Image image;           //食物图片
        public bool isUseTool;        //是否使用工具
        public bool isCombine;        //是否可以和其他食物结合
        public string foodName;       //食物名称
        public int foodID;            //食物ID
        public CooklStruct cs;        //是否可烹制
        public FoodStruct(Image image, bool isUseTool, bool isCombine, string foodName, int foodID, CooklStruct cs)
        {
            this.image = image;
            this.isUseTool = isUseTool;
            this.isCombine = isCombine;
            this.foodName = foodName;
            this.foodID = foodID;
            this.cs = cs;
        }
    }
}
