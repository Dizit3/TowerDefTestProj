using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject[] enemyPref;
    [SerializeField] private GameObject[] enemySpawn;
    [SerializeField] private GameObject[] enemyTarget;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (enemyPref.Length > 0)
            {
                GameObject newEnemy = Instantiate(enemyPref[0], enemySpawn[0].transform.position, Quaternion.identity);
            }

    }
}
