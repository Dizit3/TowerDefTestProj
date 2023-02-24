using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TowerMuzzleAim : MonoBehaviour
{
    private List<GameObject> currentCollisions;
    private GameObject currentEnemy = null;
    [SerializeField]private int attackDamage = 0;
    private float attackRange = 2f;

    private void Awake()
    {
        currentCollisions = new List<GameObject>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        //m_CurrentCollisions.Add(collision.gameObject); //��������� ������ � ������ ������� ����� � ������� ��������� �����
    }



    private void OnTriggerExit(Collider collision)
    {
    //    int index = m_CurrentCollisions.FindIndex(
    //x => x.gameObject == collision.gameObject); // ������� ������ ������ �������� �� ������� ������� �������� �����

    //    m_CurrentCollisions.RemoveAt(index); //������� ������ �������� �� ������� ������� �������� �����
    }

    private void Update()
    {

        Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange, LayerMask.GetMask("Enemies"));
        if (hitEnemies.Length > 0)
        {
            hitEnemies[0].GetComponent<Enemy>().TakeDamage(attackDamage);
            AimToEnemy(hitEnemies[0].transform.position);
        }

    }



    private void AimToEnemy(Vector3 target)
    {
        transform.LookAt(target);
    }
}
