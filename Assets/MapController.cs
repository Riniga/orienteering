using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject target;
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180 + target.transform.eulerAngles.y);
    }
}
