using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject enemyPref;
    [SerializeField] private GameObject enemySpawn;
    [SerializeField] private Transform[] waypoints;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (enemyPref != null && enemySpawn != null)

            {
                GameObject enemy = Instantiate(enemyPref, enemySpawn.transform.position, Quaternion.identity);

                

            }

    }
}
