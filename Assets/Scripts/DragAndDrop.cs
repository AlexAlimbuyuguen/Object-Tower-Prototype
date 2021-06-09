using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    //private bool isDragging;

    //public void OnMouseDown()
    //{
    //    isDragging = true;
    //}

    //public void OnMouseUp()
    //{
    //    isDragging = false;
    //}

    //void Update()
    //{
    //    if (isDragging)
    //    {
    //        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    //        transform.Translate(mousePosition);
    //    }
    //}

    private bool dragging = false;
    private float distance;
    private Vector3 startDistance;

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 rayPoint = ray.GetPoint(distance);
        startDistance = transform.position - rayPoint;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint + startDistance;
        }
    }
}
