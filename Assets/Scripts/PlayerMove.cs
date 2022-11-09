using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMove : MonoBehaviour
{
    //����
    Animator animator;
    Transform playerTransform;
    bool isRunning;
    //����
    Vector2 playerInputVec;
    Vector3 playerMovement;
    public float rotateSpeed = 1000;
    //ת��/�ƶ��ٶ�
    float currentSpeed;
    float targetSpeed;
    float walkSpeed = 1.5f;
    float runSpeed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        MovePlayer();

    }

    public void GetPlayerMoveInput(InputAction.CallbackContext ctx)
    {
        playerInputVec = ctx.ReadValue<Vector2>();
        Debug.Log(playerInputVec);
    }
    //�������
    public void GetPlayerRunInput(InputAction.CallbackContext ctx)
    {
        isRunning = ctx.ReadValue<float>() > 0 ? true : false;
        Debug.Log(isRunning);
    }
    //����
    void RotatePlayer()
    {
        if (playerInputVec.Equals(Vector2.zero))
            return;
        playerMovement.x = playerInputVec.x;
        playerMovement.z = playerInputVec.y;
        Quaternion targetRotation = Quaternion.LookRotation(playerMovement, Vector3.up);
        playerTransform.rotation = Quaternion.RotateTowards(playerTransform.rotation, targetRotation, rotateSpeed * Time.deltaTime);


    }
    //�ƶ�
    void MovePlayer()
    {
        targetSpeed = isRunning ? runSpeed : walkSpeed;
        targetSpeed *= playerInputVec.magnitude;
        currentSpeed = Mathf.Lerp(currentSpeed, targetSpeed, 0.5f);
        animator.SetFloat("Vertical Speed", currentSpeed);
    }



}
