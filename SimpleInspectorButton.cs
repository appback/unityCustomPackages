namespace CSH
{
    [System.Serializable]
    public class SimpleInspectorButton
    {
        public string MethodName;
        public string ButtonText;

        public SimpleInspectorButton(string methodName, string buttonText = "Execute")
        {
            MethodName = methodName;
            ButtonText = buttonText;
        }
    }
}

/* 예제.
    [SerializeField]
    private SimpleInspectorButton testButton = new SimpleInspectorButton("DoSetting", "Do Set");

    public void DoSetting()
    {
        
    }
*/
