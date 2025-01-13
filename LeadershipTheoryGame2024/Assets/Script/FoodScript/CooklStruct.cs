using UnityEngine;

namespace GameCore 
{
    public struct CooklStruct
    {
        public bool isJG;     //¼å¹ø
        public bool isJBJ;     //½Á°è»ú    
        public bool isTG;     //ÌÀ¹ø

        public CooklStruct(bool isJG, bool isJBJ, bool isTG)
        {
            this.isJG = isJG;
            this.isJBJ = isJBJ;
            this.isTG = isTG;
        }
    }
}

