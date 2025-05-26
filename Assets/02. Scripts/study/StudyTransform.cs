using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    // Update is called once per frame
    void Update()
    {
        // ���� ���� ������ ĳ���Ͱ� �̵��ϴ� ���
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // ���� �������� �̵�
        // transform.localPosition += Vector3.forward * moveSpeed * Time.deltaTime;

        // ����(ĳ���Ͱ� �ٶ󺸴� ����) �������� �̵��ϴ� ���
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        //float localX = transform.eulerAngles.x;
        //float localY = transform.eulerAngles.z;

        // ���� �������� ȸ��
        //transform.rotation = Quaternion.Euler(localX, angle, localY);

        //���� �������� ȸ��
        //transform.localRotation = Quaternion.Euler(localX, angle, localY);

        // ���� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self ����

        // ���� �������� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World); // Space.World<-world ���� ����

        // Ư�� ��ġ�� �ֺ��� ȸ��
        //transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        // transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 1f, 0f), rotateSpeed * Time.deltaTime);

        // Ư�� ��ġ�� �ٶ󺸸� ȸ��
        transform.LookAt(Vector3.zero);
    }
}
