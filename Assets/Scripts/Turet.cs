using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turet : MonoBehaviour
{
    public float speed = 1;
    public GameObject turretBase;
    public GameObject turretBarrow;
    public Slider speedSlider;
    private float yRot = 0;
    private float xRot = 0;

    public GameObject bulletPrefab;
    public GameObject shootPoint;
    // Start is called before the first frame update
    void Start()
    {
        speed = speedSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        turretBase.transform.Rotate(0, yRot*Time.deltaTime, 0);
        turretBarrow.transform.Rotate(xRot * Time.deltaTime, 0, 0);
    }

    public void RotateLeft()
    {
        yRot = -speed;
    }
    public void RotateRight()
    {
        yRot = speed;
    }
    public void RotateUp()
    {
        xRot = -speed;
    }
    public void RotateDown()
    {
        xRot = speed;
    }
    public void RotateStop()
    {
        yRot = 0;
        xRot = 0;
    }
    public void SpeedUpdate()
    {
        speed = speedSlider.value;
    }
    public void Fire()
    {
        Instantiate(bulletPrefab, shootPoint.transform.position,turretBarrow.transform.rotation);
    }
   
}
