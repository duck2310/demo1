using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // hàm này chạy 1 lần duy nhất khi nhấn play
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // hàm này chạy liên tục trong mỗi khung hình
    void Update()
    {
        // lưu ý dấu ngoặc kép phải đóng trước dấu cộng
        Debug.Log("Update called! " + Time.frameCount);
    }
}