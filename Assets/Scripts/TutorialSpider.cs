using UnityEngine;

public class TutorialSpider : MonoBehaviour
{
    private Rigidbody2D greenSpider;

    private void Start()
    {
        greenSpider = GetComponent<Rigidbody2D>();
    }

    //Kill spider on click
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }

    }
}
