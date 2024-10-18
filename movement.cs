using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 10f; //��������� ���������� ��� ���������� �������� ������ � �����
    public float rotateSpeed = 7f;//��������� ���������� ��� ���������� �������� �����  � ������
    public float jumpForce = 30f; //��������� ���������� ��� ���������� ���� ������


    private float vInput;
    private float hInput;
    private float Vector3up;


    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);

        hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.Space))
        {

            {

                //Vector3up = Input.GetAxisRaw("Jump") * jumpForce;
                rb.AddForce(transform.up * jumpForce,ForceMode.Impulse);
            }




        }

    }
}
