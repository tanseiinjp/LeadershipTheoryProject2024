using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using GameCore;


public class OrderManager : MonoBehaviour
{
    public static OrderManager instance { get; private set; }

    public event EventHandler OnMeunorderSpawend;
    public event EventHandler OnOrderFinished;


    [SerializeField] private FoodListOS meunFoodList;
    [SerializeField] private float orderRate = 2;//��������
    [SerializeField] private int orderMaxCount = 5;//��󶩵�����
    [SerializeField] private MainPlayer mp;

    private List<CombineMeunOS> combineMeunOsList =new List<CombineMeunOS>();

    private float orderTimer = 0;//��ʱ��

    private bool isStartOrder = false;
    private int orderCount = 0;//�ܵ���

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {        
        isStartOrder = true;
    }
    private void Update()
    {
        if (isStartOrder)
        {
            OrderUpdate();
        }
    }

    private void OrderUpdate()
    {
        orderTimer += Time.deltaTime;
        if (orderTimer >= orderRate)
        {
            orderTimer = 0;
            OrderANewMeun();
        }
    }
    public void OrderDel()
    {
        if (orderCount != 0)
        {
             OrderFinished(mp.JiaoFu());
        }
    }
    public void OrderDelByProg(string meunFoodName)
    {
        if (orderCount != 0)
        {
            OrderFinished(meunFoodName);
        }
    }
    private void OrderANewMeun()//�µ�
    {
        if (orderCount >= orderMaxCount)
        {
            isStartOrder = false;
            return;
        }
        orderCount++;
        int index = UnityEngine.Random.Range(0, meunFoodList.combineMeunList.Count);
        combineMeunOsList.Add(meunFoodList.combineMeunList[index]);
        OnMeunorderSpawend?.Invoke(this, EventArgs.Empty);
    }

    public void OrderFinished(string meunFoodName)//��ɶ���
    {
        if (orderCount == 0) return;
        orderCount--;
        isStartOrder = true;
        foreach (var item in combineMeunOsList)
        {
            if (meunFoodName == item.foodName)
            { 
                combineMeunOsList.Remove(item);
                break;
            }
        }
        OnOrderFinished?.Invoke(this, EventArgs.Empty);
    }


    public List<CombineMeunOS> GetOrderList()
    { 
        return combineMeunOsList;
    }
}
