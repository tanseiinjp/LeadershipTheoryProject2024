using UnityEngine;
using System.Collections;
using System;

<<<<<<< HEAD
namespace Gamecore
=======
namespace GameCore
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
{
    public class TheGameTool : MonoBehaviour
    {
        //�����ڴ�(һ���л�������ʱ�����)
        public static void ClearMemory()
        {
            //�ֶ�������������
            //�������������ǻ��������ܵ�,���Բ���Ƶ��ȥ����
            GC.Collect();
            //ж���ڴ���û�õ���Դ
            Resources.UnloadUnusedAssets();
        }
        //�����ڴ�,���ݳ־û�
        //�ж�ϵͳn�ڴ������Ƿ��а���ĳ����
        public static bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }
        //ȡֵ
        public static int GetInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }
        public static float GetFloat(string key)
        {
            return PlayerPrefs.GetFloat(key);
        }
        public static string GetString(string key)
        {
            return PlayerPrefs.GetString(key);
        }
        //��ֵ
        public static void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }
        public static void SetFloat(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
        }
        public static void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }
        //ɾ��ϵͳ�ڴ���ָ���ļ�ֵ��
        public static void DeleteKey(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }
        //ɾ��ϵͳ�ڴ������еļ�ֵ��
        public static void DeleteAll()
        {
            PlayerPrefs.DeleteAll();
        }
        //�ָ��ַ���
        public static string[] SplitString(string str, char c)
        {
            return str.Split(c);
        }
        //����������
        public static Transform FindTheChild(GameObject goParent, string childName)
        {
            Transform searchTrans = goParent.transform.Find(childName);
            if (searchTrans == null)
            {
                foreach (Transform trans in goParent.transform)
                {
                    searchTrans = FindTheChild(trans.gameObject, childName);
                    if (searchTrans != null)
                    {
                        return searchTrans;
                    }
                }
            }
            return searchTrans;
        }
        //��ȡ��������������
        public static T GetTheChildComponent<T>(GameObject goParent, string childName) where T : Component
        {
            Transform searchTrans = FindTheChild(goParent, childName);
            if (searchTrans != null)
            {
                return searchTrans.GetComponent<T>();
            }
            else
            {
                return null;
            }

        }
        //��������������
        public static T AddTheChildComponent<T>(GameObject goParent, string childName) where T : Component
        {
            Transform searchTrans = FindTheChild(goParent, childName);
            if (searchTrans != null)
            {
                T[] arr = searchTrans.GetComponents<T>();
                for (int i = 0; i < arr.Length; i++)
                {
                    //Destroy(arr[i]);//����,��������������(��ǰ֡����ǰ������)
                    DestroyImmediate(arr[i], true);//��������
                }
                return searchTrans.gameObject.AddComponent<T>();
            }
            else
            {
                return null;
            }
        }
        //���������
        public static void AddChildToParent(Transform parentTrans, Transform childTrans)
        {
            childTrans.parent = parentTrans;
            childTrans.localPosition = Vector2.zero;
            //childTrans.localScale = Vector2.one;
        }
    }
}
