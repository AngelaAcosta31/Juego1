using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.Translate(moveX, moveY,0);
    }
}
