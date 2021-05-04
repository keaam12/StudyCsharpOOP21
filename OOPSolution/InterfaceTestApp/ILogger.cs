    namespace InterfaceTestApp
{
    interface ILogger
    {
        // 약속이다. 이 ILogger를 구현(상속)하게 되면 아래의 액션을 무조건!!!! 구현

        void WriteLog(string message); // 하나의 메시지를 받아서 처리할 것

        void WriteError(string error); // 메서드 추가
    }
}
