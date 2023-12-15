using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour
{
    public float targetOrthographicSize;
    public float zoomSpeed = 1f; 
    public float moveSpeed = 5f; 
    public Vector3 moveDirection; 

    void Start()
    {
       moveDirection = Vector3.left * 500;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(SmoothZoomOut());
            
        }
    }

    IEnumerator SmoothZoomOut()
    {
        float initialOrthographicSize = Camera.main.orthographicSize;
        targetOrthographicSize = Camera.main.orthographicSize + 1;
        float elapsedTime = 0f;

        while (elapsedTime < 1f)
        {
            Camera.main.orthographicSize = Mathf.Lerp(initialOrthographicSize, targetOrthographicSize, elapsedTime);
            elapsedTime += Time.deltaTime * zoomSpeed;
            transform.Translate(moveDirection * Time.deltaTime * moveSpeed);

            yield return null;
        }

        
        Camera.main.orthographicSize = targetOrthographicSize;
        Destroy(gameObject);
    }
}
