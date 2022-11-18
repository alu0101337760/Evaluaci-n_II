using UnityEngine;

public class EggReaction : MonoBehaviour
{

    public ChestCollisionManager chestManager;
    public float scalingFactor = 1.1f;

    private
    void Start()
    {
        chestManager.OnCollisionWithPlayer += ReactionToChestCollision;
    }

    private void ReactionToChestCollision()
    {
        this.transform.localScale = scalingFactor * this.transform.localScale;
    }
}
