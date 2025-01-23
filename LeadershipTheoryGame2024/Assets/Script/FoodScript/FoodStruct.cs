using UnityEngine;
using UnityEngine.UI;


namespace GameCore

{
    public struct FoodStruct
    {
        public Image image;           //ʳ��ͼƬ
        public bool isUseTool;        //�Ƿ�ʹ�ù���
        public bool isCombine;        //�Ƿ���Ժ�����ʳ����
        public string foodName;       //ʳ������
        public int foodID;            //ʳ��ID
        public CooklStruct cs;        //�Ƿ������
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
