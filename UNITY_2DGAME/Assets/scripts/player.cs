
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject final;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到門了");
        final.SetActive(true);
    }


}

