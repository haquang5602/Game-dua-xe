using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float tocDoXe = 100f;
    [SerializeField]
    private float lucReXe = 100f;
    [SerializeField]
    private float lucPhanhXe = 50f;
    [SerializeField]
    private GameObject hieuUngPhanh;

    private float dauVaoDiChuyen;
    private float dauVaoRe;
    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        dauVaoDiChuyen = Input.GetAxis("Vertical");
        DiChuyenXe();
        dauVaoRe = Input.GetAxis("Horizontal");
        ReXe();
        if(dauVaoDiChuyen>0&& Input.GetKey(KeyCode.LeftShift)) 
        {
            PhanhXe();
        }
    }

    private void DiChuyenXe()
    {
        rb.AddRelativeForce(Vector3.forward * dauVaoDiChuyen * tocDoXe);
        hieuUngPhanh.SetActive(false);
    }
    private void ReXe()
    {
        Quaternion re = Quaternion.Euler(Vector3.up * dauVaoRe * lucReXe * Time.deltaTime);
        rb.MoveRotation(rb.rotation * re);

    }
    private void PhanhXe()
    {
        if(rb.velocity.z != 0)
        {
            rb.AddRelativeForce(-Vector3.forward * lucPhanhXe);
            hieuUngPhanh.SetActive(true);

        }
    }
}
