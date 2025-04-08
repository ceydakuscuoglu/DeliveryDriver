using UnityEngine;

public class Package : MonoBehaviour
{

    [SerializeField] Color32 ifPackageNotExistsColor = new Color32(0, 0, 0,0);
    [SerializeField] Color32 ifPackagePickedUpColor = new Color32(0, 0, 0, 0);

    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.color = ifPackageNotExistsColor;
    }

    bool isPickedUp = false;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch !!!");

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Triggerred !!!");
        if (other.tag == "Package" && !isPickedUp)
        {
            Debug.Log("Package picked up !!!");
            isPickedUp = true;
            spriteRenderer.color = ifPackagePickedUpColor;
            Destroy(other.gameObject, 0.5f);
        }


        if (other.tag == "Customer" && isPickedUp)
        {
            spriteRenderer.color = ifPackageNotExistsColor;
            Debug.Log("Package delivered to customer !!!");
            isPickedUp = false;
        }
    }

}
