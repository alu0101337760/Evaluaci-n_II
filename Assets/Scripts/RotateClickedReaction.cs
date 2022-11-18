using UnityEngine;


public class RotateClickedReaction : MonoBehaviour
{
    public float rotateFactor = 50;

    public void OnPointerEnter()
    {

        this.gameObject.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0, rotateFactor, 0)));
    }
}
