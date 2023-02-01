using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TowerMuzzleAim : MonoBehaviour
{
    private List<GameObject> m_CurrentCollisions;
    private GameObject m_CurrentEnemy = null;
    private int attackDamage = 25;
    private float attackRange = 2f;

    private void Awake()
    {
        m_CurrentCollisions = new List<GameObject>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        //m_CurrentCollisions.Add(collision.gameObject); //Добавляем врагов в список текущих целей в радиусе видимости башни
    }



    private void OnTriggerExit(Collider collision)
    {
    //    int index = m_CurrentCollisions.FindIndex(
    //x => x.gameObject == collision.gameObject); // Находим индекс врагов вышедших за пределы радиуса действия башни

    //    m_CurrentCollisions.RemoveAt(index); //Удаляем врагов вышедших за пределы радиуса действия башни
    }

    private void Update()
    {

        Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange, LayerMask.GetMask("Enemies"));
        if (hitEnemies.Length > 0)
        {
            hitEnemies[0].GetComponent<Enemy>().TakeDamage(attackDamage);
        }


        if (m_CurrentCollisions.Count > 0)
            AimToFirst(m_CurrentCollisions.First());


    }



    private void AimToFirst(GameObject obj)
    {
        m_CurrentEnemy = obj;
        transform.LookAt(m_CurrentEnemy.transform.position);
    }
}
