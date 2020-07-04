using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{

    /*public int speedForward = 12; // 전진 속도
    public int speedSide = 6; // 옆걸음 속도

    private Transform tr;
    private float dirX = 0;
    private float dirZ = 0;
    */

    private Transform camTr;
    public Camera cam;
    private float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
         camTr = cam.GetComponent<Transform>();
        // camTr = camObj.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            MovePlayer();
        }
    }

    // 플레이어 이동
    /*void MovePlayer()
    {
        dirX = 0; // 좌우 이동(왼쪽: -1, 오른쪽: 1)
        dirZ = 0; // 전진 후진(후진: -1, 전진: 1)
        if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad,
                                         OVRInput.Controller.RTrackedRemote);

            var absX = Mathf.Abs(coord.x);
            var absY = Mathf.Abs(coord.y);
            if (absX > absY)
            {
                if (coord.x > 0) // 오
                    dirX = +1;
                    
                else // 왼
                    dirX = -1;
            }
            else
            {
                if (coord.y > 0) // 위(앞)
                    dirZ = +1;
                else // 아래(뒤)
                    dirZ = -1;
            }

        }
        // 이동 방향 설정 후 이동
        
        Vector3 moveDir = new Vector3(dirX * speed, 0, dirZ * speed);
        transform.Translate(moveDir * Time.smoothDeltaTime);
        
        // transform.rotation = Quaternion.LookRotation(moveDir); 원하는 방향 쳐다보기.

    }*/

    void MovePlayer()
    {
        Vector3 dir = camTr.TransformDirection(Vector3.forward);

        transform.Translate(dir * speed);
    }

}
