using UnityEngine;
using System.Collections;
 
public class MouseFollow : MonoBehaviour {
 
    public float speed = 6.0f;
  
    void Start()
    {
    }
 
    private void Update()
    {
        if (Input.GetMouseButton (0)) {

            var halfWidth = (Screen.width / 2);
            var halfHeight = (Screen.height / 2);

            var directionX = Input.mousePosition.x < halfWidth ? -1 : 1;
            var directionY = Input.mousePosition.y < halfHeight ? -1 : 1;

            var amountX = (Input.mousePosition.x - halfWidth) / halfWidth;
            var amountY = (Input.mousePosition.y - halfHeight) / halfHeight;
                       
            var newX = amountX * speed * Time.deltaTime;
            var newZ = amountY * speed * Time.deltaTime;

            Debug.Log($"New {newX}, {newZ}");

            transform.Rotate(0, amountX, 0);
            transform.Translate(new Vector3 (0, 0, newZ));
        }
    }
}
 