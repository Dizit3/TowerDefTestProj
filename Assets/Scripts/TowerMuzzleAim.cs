using UnityEngine;

public class TowerMuzzleAim : MonoBehaviour
{
    [SerializeField] private int attackDamage = 20;
    private float attackRange = 2f;


    [SerializeField] private float delayTime = 0.1f; // Время задержки в секундах
    private float lastUpdateTime; // Время последнего обновления

    private void Update()
    {

        Collider[] detectedEnemies = Physics.OverlapSphere(transform.position, attackRange, LayerMask.GetMask("Enemies"));
        if (detectedEnemies.Length > 0)
        {
            if (Time.time - lastUpdateTime >= delayTime)
            {
                // Выполняем нужные действия
                detectedEnemies[0].GetComponent<Enemy>().TakeDamage(attackDamage);

                // Обновляем время последнего обновления
                lastUpdateTime = Time.time;
            }

            AimToEnemy(detectedEnemies[0].transform.position);
        }

    }

    private void AimToEnemy(Vector3 target)
    {
        transform.LookAt(target);
    }

}
