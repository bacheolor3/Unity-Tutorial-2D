using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    // Update is called once per frame
    void Update()
    {
        // 월드 기준 앞으로 캐릭터가 이동하는 기능
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 방향으로 이동
        // transform.localPosition += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬(캐릭터가 바라보는 방향) 방향으로 이동하는 기능
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        //float localX = transform.eulerAngles.x;
        //float localY = transform.eulerAngles.z;

        // 월드 방향으로 회전
        //transform.rotation = Quaternion.Euler(localX, angle, localY);

        //로컬 방향으로 회전
        //transform.localRotation = Quaternion.Euler(localX, angle, localY);

        // 로컬 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략

        // 월드 방향으로 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World); // Space.World<-world 기준 공간

        // 특정 위치의 주변을 회전
        //transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        // transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 1f, 0f), rotateSpeed * Time.deltaTime);

        // 특정 위치를 바라보며 회전
        transform.LookAt(Vector3.zero);
    }
}
