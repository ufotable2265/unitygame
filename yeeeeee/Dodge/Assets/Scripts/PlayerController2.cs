using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2: MonoBehaviour
{
    private Rigidbody playerRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; // 이동 속력
    public GameObject bulletPrefab; // 발사할 총알 프리팹
    public float bulletSpeed = 20f; // 총알 발사 속도
    public float fireRate = 0.5f; // 발사 주기 (초)
    private float nextFireTime = 0f; // 다음 발사 가능 시간

    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 수평과 수직 축 입력 값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력 값과 이동 속력을 통해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, zSpeed)으로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // 리지드바디의 속도에 newVelocity를 할당
        playerRigidbody.velocity = newVelocity;

        // 마우스 왼쪽 버튼을 클릭하고, 다음 발사 가능 시간이 되었다면
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            // 다음 발사 가능 시간을 현재 시간 + 발사 주기로 설정
            nextFireTime = Time.time + fireRate;
            ShootBullet();
        }
    }
void ShootBullet()
{
    // 마우스 커서의 월드 좌표 가져오기
    Vector3 mousePos = Input.mousePosition;
    mousePos.z = transform.position.z - Camera.main.transform.position.z;
    Ray ray = Camera.main.ScreenPointToRay(mousePos);

    // 광선을 사용하여 원하는 작업 수행
    RaycastHit hit;
    if (Physics.Raycast(ray, out hit))
    {
        // 광선이 충돌한 오브젝트의 정보 사용
        Debug.Log("Hit: " + hit.transform.name);
        if (hit.collider.tag == "Ememy")
        {
            // 상대방 게임 오브젝트에서 PlayerController 컴포넌트를 가져오기
            BulletSpawner BulletSpawner
                = hit.collider.GetComponent<BulletSpawner>();

            // 상대방으로부터 PlayerController 컴포넌트를 가져오는대 성공했다면
            if (BulletSpawner != null)
            {
                // 상대방 PlayerController 컴포넌트의 Die() 메서드 실행
                BulletSpawner.Die();
            }
        }
    }

    // 총알 프리팹 생성 및 발사
    GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    bullet.transform.LookAt(hit.point);
    bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed, ForceMode.Impulse);
}

    public void Die()
    {
        // 자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);

        // 씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindObjectOfType<GameManager>();
        // 가져온 GameManager 오브젝트의 EndGame() 메서드 실행
        gameManager.EndGame();
    }
}