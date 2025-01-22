using UnityEngine;

public class JiaoFu : MonoBehaviour
{
    
    private bool isJiaoFu = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isJiaoFu)
        {
            OrderManager.instance.OrderDel();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isJiaoFu = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isJiaoFu = false;
        }
    }
}
