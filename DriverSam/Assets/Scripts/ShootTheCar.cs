using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;

public class ShootTheCar : MonoBehaviour
{
    RaycastHit2D hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.CompareTag("Dusman"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    void LateUpdate()
    {
        // Debug ray in LateUpdate to visualize the raycast after object transformations.
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.DrawRay(mousePosition, Vector2.zero, Color.red, 1.0f);
    }
}
