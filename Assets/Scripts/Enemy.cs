using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  [SerializeField]  private int health = 100;
    private List<Transform> targetWaypoint;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Finish")
            Destroy(this.gameObject);
    }


    public void TakeDamage(int attackDamage)
    {
        health -= attackDamage;

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void Awake()
    {
        
    }
}
