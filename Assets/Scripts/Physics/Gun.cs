using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    public float _power = 100;

    private TrajectoryRenderer _trajectory;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
        _trajectory = FindObjectOfType<TrajectoryRenderer>();
    }

    private void Update()
    {
        float enter;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        new Plane(-Vector3.forward, transform.position).Raycast(ray, out enter);
        Vector3 mouseInWorld = ray.GetPoint(enter);

        Vector3 speed = (mouseInWorld - transform.position) * _power;
        transform.rotation = Quaternion.LookRotation(speed);
        //_trajectory.ShowTrajectory(transform.position, speed);

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Rigidbody bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        //    bullet.AddForce(speed, ForceMode.VelocityChange);
        //}
    }
}
