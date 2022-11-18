using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int HealthCount = 100;
    public void DamagePlayer(int damageAmmount)
    {
        HealthCount -= damageAmmount;
    }
}
