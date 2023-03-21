using UnityEngine;

public class ConstructTower : MonoBehaviour
{
    private bool isEmpty = true;
    [SerializeField]private GameObject tower;
    [SerializeField] private float towerOffset;

    private void OnMouseDown()
    {
        if (isEmpty)
        {
            Instantiate(tower, transform.position + new Vector3(0f, towerOffset, 0), Quaternion.identity);
        }
    }
}
