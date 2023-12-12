namespace TreinamentoWPF.Messages
{
    public class ObjectMessage
    {
        public object Data { get; set; }

        public ObjectMessage(object data)
        {
            Data = data;
        }
    }

}
