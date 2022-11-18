using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public string teleportKey = "t";
    private Vector3 targetPosition = new Vector3();


    public GameObject selector;
    private Vector3 hiddenPosition = new Vector3(0, -1, 0);

    void Start()
    {
        selector = Instantiate(selector, hiddenPosition, Quaternion.identity);
    }

    private void ManageMouseSelection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.gameObject.tag == "Ground")
                {
                    targetPosition = hit.point;
                    selector.transform.position = targetPosition;
                }
            }
        }
    }

    private void ManageTeleport()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            selector.transform.position = hiddenPosition;
            this.transform.position = targetPosition;

        }
    }


    // Update is called once per frame
    void Update()
    {
        ManageMouseSelection();
        ManageTeleport();
    }
}
