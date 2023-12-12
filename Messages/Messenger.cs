namespace TreinamentoWPF.Messages
{
    public class Messenger
    {
        private static readonly Messenger _instance = new();

        public static Messenger Instance { get { return _instance; } }

        private readonly Dictionary<Type, List<Action<object>>> _actions =
            new Dictionary<Type, List<Action<object>>>();

        public void Register<T>(Action<object> action)
        {
            if (!_actions.ContainsKey(typeof(T)))
            {
                _actions[typeof(T)] = new List<Action<object>>();
            }

            _actions[typeof(T)].Add(action);
        }

        public void Send<T>(T message)
        {
            if (_actions.ContainsKey(typeof(T)))
            {
                foreach (var action in _actions[typeof(T)])
                {
                    action(message);
                }
            }
        }
        public void Unregister<T>(Action<object> action)
        {
            if (_actions.ContainsKey(typeof(T)))
            {
                _actions[typeof(T)].Remove(action);
            }
        }
    }
}
