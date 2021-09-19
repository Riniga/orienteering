using UnityEngine;

public class PunchControl : MonoBehaviour
{
    public LayerMask controlLayer;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        Rigidbody body = hit.collider.attachedRigidbody;
        Debug.Log("here");
        if (body == null || body.isKinematic) return;
        Debug.Log("body" + body.name);
        var bodyLayerMask = 1 << body.gameObject.layer;
        if ((bodyLayerMask & controlLayer.value) == 0) return;

        if (hit.gameObject.name == "Control_start")
        {
            if (!TimerController.Enabled)
            {
                TimerController.TryStart();
            }
            else
            {
                TimerController.TryStop();
            }
        }
        else
        {
            var parts = hit.gameObject.name.Split("_");
            if (int.Parse(parts[1]) == ProgressController.CurrentControl+1)
            {
                ProgressController.CurrentControl++;
            }
        }

    }

}
