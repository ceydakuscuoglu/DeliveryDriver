using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] GameObject thingToFollow;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
