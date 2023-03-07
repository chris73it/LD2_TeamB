using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowardMouse : MonoBehaviour
{
    void Update()
    {
        //Mouse Position in the world. It's important to give it some distance from the camera. 
        //If the screen point is calculated right from the exact position of the camera, then it will
        //just return the exact same position as the camera, w$$anonymous$$ch is no good.
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);

        //Angle between mouse and t$$anonymous$$s object
        float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);

        //Ta daa
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        //To move horizontally, on line 17 change the y to 'angle' and the z to '0f'.
        //(0f, angle, 0f).
        //To have the player actually rotate towards the mouse then change the code within the brackets in line 21 to(b.x - a.x, b.y - a.y)
        //#when you said the code did exactly the opposite of what was required I flipped the values and thankfully it works :)
    }

    float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
    //float AngleBetweenPoints(Vector3 a, Vector3 b) { return Mathf.Atan2(a.z - b.z, a.x - b.x) * Mathf.Rad2Deg; }
}
