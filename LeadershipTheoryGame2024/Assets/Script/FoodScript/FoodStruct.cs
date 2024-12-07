using UnityEngine;
using UnityEngine.UI;

public struct FoodStruct
{
    public Image image;           //ʳ��ͼƬ
    public bool isUseTool;        //�Ƿ�ʹ�ù���
    public bool isCooked;         //�Ƿ���й���⿴���
    public bool isCombine;        //�Ƿ���Ժ�����ʳ����
    public string foodName;       //ʳ������
    public int foodID;            //ʳ��ID

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
