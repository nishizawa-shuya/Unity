using UnityEngine;

// �o�[���ړ����鏈��
public class MoveBar : MonoBehaviour
{
    float chargeTime; // �o�[�̃`���[�W���Ԃ��L������
    bool chargeFlgWidth = false; // �`���[�W�������������ǂ����𔻒肷��
    float oldPosX; // �ړ��O�̃o�[�̈ʒu���L������

    void Start()
    {
        // gameObject�̃��O�擾
        Debug.Log(gameObject);
    }

    void Update()
    {
        // gameObject���폜
        // Destroy(this.gameObject);

        // �E�L�[�ŉE�Ɉړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            chargeTime += Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)) // �L�[�������ꂽ�Ȃ�i�`���[�W���������Ȃ�j
        {
            // �`���[�W�����t���O��TRUE
            chargeFlgWidth = true;

            // �`���[�W�������_�̃o�[�̈ʒu���L��
            oldPosX = transform.position.x;
        }
        
        // �`���[�W�����������Ȃ瓮���o��
        if (chargeFlgWidth)
        {
            // �`���[�W��������������
            if (transform.position.x >= oldPosX + 2f * chargeTime)
            {
                // �`���[�W������������������~�܂�
                chargeFlgWidth = false;
                // gameObject�̃��O�擾
                Debug.Log(transform.position.x);

                return;
            }

            // �o�[�̈ړ������ideltaTime�Ōv�Z�j
            transform.position += new Vector3(2f * Time.deltaTime, 0f, 0f);
        }
       
    }
}
