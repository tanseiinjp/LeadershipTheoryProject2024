using UnityEngine;

namespace GameCore 
{
    public struct CooklStruct
    {
        public bool isJG;     //���
        public bool isJBJ;     //�����    
        public bool isTG;     //����

        public CooklStruct(bool isJG, bool isJBJ, bool isTG)
        {
            this.isJG = isJG;
            this.isJBJ = isJBJ;
            this.isTG = isTG;
        }
    }
}

