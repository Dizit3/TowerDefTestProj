using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject[] enemyPref;
    [SerializeField] private GameObject[] enemySpawn;
    [SerializeField] private GameObject[] enemyTarget;

    private NavMeshAgent m_navMesh;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (enemyPref.Length > 0)
            {
                GameObject newEnemy = Instantiate(enemyPref[0], enemySpawn[0].transform.position, Quaternion.identity);

                m_navMesh = newEnemy.GetComponent<NavMeshAgent>();

                if (enemyTarget.Length > 0)
                    m_navMesh.SetDestination(enemyTarget[Random.Range(0, enemyTarget.Length)].transform.position);

            }
    }
}
