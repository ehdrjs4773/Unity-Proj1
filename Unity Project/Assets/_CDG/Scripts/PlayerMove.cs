using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;

    public Vector2 margin; //뷰 포트 좌표는 (0,0) ~ (1,1) 사이의 값을 사용한다.


    
    // Start is called before the first frame update
    void Start()
    {
        //transfrom은 굳이 선언하지 않아도 됨.
    }

    // Update is called once per frame
    void Update()
    {
        //GetAxis를 사용하는 이유
        //멀티 플레폼 사용으로 인해서(윈도우 , 안드로이드)
        //1 ~ -1 만  아무것도 안누르면 0 
        // 오른쪽은 1 왼쪽은 - 1

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동처리
        //transform.Translate(h * speed * Time.deltaTime, v*speed * Time.deltaTime, 0);
        //아래 방법도 가능 (덧셈일때는 상관없지만 뺄셈을 써야 할 경우 아래 방법이 더 좋음
        //Vector3 dir = Vector3.right * h + Vector3.forward * v;
        Vector3 dir = new Vector3(h, v, 0);
        //백터의 정규화
        //dir.Normalize();




        Vector3 swap = transform.position;

       transform.Translate(dir * speed * Time.deltaTime);


        //if(transform.position.x + 0.5 >= 5)
        //{
        //    swap.x = 4.5f;
        //
        //}
        //if (transform.position.x - 0.5 <= -5)
        //{
        //    swap.x = -4.5f;
        //
        //}
        //if (transform.position.z + 0.5 >= 5)
        //{
        //    swap.z = 4.5f;
        //
        //}
        //if (transform.position.z - 0.5 <= -5)
        //{
        //    swap.z = -4.5f;
        //
        //}
       swap.x = Mathf.Clamp(swap.x, -4.5f, 4.5f);
       swap.y = Mathf.Clamp(swap.y, -4.5f, 4.5f);
       
       
         transform.position = swap;

      // Vector3 camera = Camera.main.WorldToViewportPoint(transform.position);

        //if(camera.x > 1) camera.x = 1;
        //if (camera.x < 0) camera.x = 0;
        //if (camera.y > 1) camera.y = 1;
        //if (camera.y < 0) camera.y = 0;

        //camera.x = Mathf.Clamp(camera.x, 0.0f + margin.x, 1.0f - margin.x);
        //camera.y = Mathf.Clamp(camera.y, 0.0f + margin.y, 1.0f - margin.y);


      // transform.position = Camera.main.ViewportToWorldPoint(camera);
       


        //Vector3.zero = new Vector3(0, 0, 0);
        //Vector3.right = new Vector3(1, 0, 0);
        //Vector3.left = new Vector3(-1, 0, 0);
        //Vector3.one = new Vector3(1, 1, 1);
        //Vector3.forward = new Vector3(0, 0, 1);
        //Vector3.back = new Vector3(0, 0, -1);
        //Vector3.up = new Vector3(0, 1, 0);
        //Vector3.down = new Vector3(0, -1, 0);
        //playerRigidbody.velocity += new Vector3(h * speed *Time.deltaTime , 0f, v *speed *Time.deltaTime);

        //중요함.
        //P = P0 + vt;
        //위치 = 현재위치 + (방향 * 시간)
        //transform.position = transform.position + dir * speed * Time.deltaTime;
        //transform.position += dir * speed * Time.deltaTime;


        //스크린좌표 : 모니터해상도 픽셀단위
        //뷰포트좌표 : 카메라의 사각뿔 끝에 잇는 사각형 왼쪽하단 (0,0), 우측상단(1,1);
        //UV좌표 : 화면 텍스트, 2D 이미지를 표시하기 위한 좌표계로 텍스쳐좌표계라고도 한다.
        //왼쪽상단(0,0) 우측 하단(1,1)


        /* 메인 카메라의 중요함수
         1. ScreenToViewportPoint
          포지션의 화면 좌표 에서 viewport좌표로 변환하는 역활
         2. ScreenToWorldPoint
          포지션의 화면 좌표 에서 world좌표로 변환하는 역활
         3. ViewportToScreenPoint
          뷰포트의 좌표를 포지션의 좌표로 변환하는 역활
         4. ViewportToWorldPoint
          뷰포트의 좌표를 world 좌표로 변환하는 역활
         5. 

        */

    }

    

}
