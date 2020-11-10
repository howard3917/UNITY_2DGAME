using UnityEngine.UI;
using UnityEngine;

public class player : MonoBehaviour

{
   //道具數量
 public Text textCount;
    //數量
 public int count;

//碰撞條件
// 1.都須有碰撞器collider 2d
// 2.至少有一rigibody
public GameObject final;
    private void OnTriggerEnter2D(Collider2D collision)
    //collision 儲存碰到物件的資訊 
    {
        //if(條件){條件成立時會執行的程式區塊}
        //如果碰到的物件的名稱是傳送門就....
        if (collision.name == "傳送門")
        {


            print("碰到門了");
            final.SetActive(true);
        }
        //如果碰到的標籤是櫻桃就吃掉她
        if (collision.tag == "櫻桃") ;
        //刪除(碰到的遊戲物件)
        //此腳本的遊戲物件
        Destroy(collision.gameObject);

        //遞增
        count++;
        //道具數量的文字 ="櫻桃數量:"+數量
        textCount.text = "櫻桃數量:" + count;
    }
    
    
      
}

