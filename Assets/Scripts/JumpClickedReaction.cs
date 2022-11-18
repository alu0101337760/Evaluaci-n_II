
using UnityEngine;


public class JumpClickedReaction : MonoBehaviour
{
    public float jumpFactor = 50;

    public void OnPointerEnter()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0) * jumpFactor);
    }
}
