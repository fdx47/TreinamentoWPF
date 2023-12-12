namespace TreinamentoWPF.Messages
{
    public class TypedObjectMessage
    {
        public object Data { get; set; }
        public string Type { get; set; }
        public TypedObjectMessage(object data, string type)
        {
            Data = data;
            Type = type;
        }
    }
}
