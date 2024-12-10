using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    private Transform currentTarget;

    void Start()
    {
        // Initialize the current target as the primary target
        currentTarget = target;
    }

    void LateUpdate()
    {
        // Check if the primary target is active; if not, switch to target2
        if (target != null && target.gameObject.activeInHierarchy)
        {
            currentTarget = target;
        }
        else if (target2 != null && target2.gameObject.activeInHierarchy)
        {
            currentTarget = target2;
        }

        // Ensure there's a valid target to follow
        if (currentTarget != null && transform.position != currentTarget.position)
        {
            Vector3 targetPosition = new Vector3(currentTarget.position.x, currentTarget.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}




// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CameraMovement : MonoBehaviour
// {

//     public Transform target;
//     public float smoothing;
//     public Vector2 maxPosition;
//     public Vector2 minPosition;

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void LateUpdate()
//     {
//         if(transform.position != target.position)
//         {
//             Vector3 targetPosition = new Vector3(target.position.x,target.position.y,transform.position.z);
//             targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x,maxPosition.x);
//             targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y,maxPosition.y);
            
//             transform.position = Vector3.Lerp(transform.position,targetPosition,smoothing);
//         }
//     }
// }