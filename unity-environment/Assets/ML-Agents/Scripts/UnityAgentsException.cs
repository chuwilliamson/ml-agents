namespace MLAgents
{
/// <summary>
/// Contains exceptions specific to ML-Agents.
/// </summary>
    [System.Serializable]
    public class UnityAgentsException : System.Exception
    {
        /// When a UnityAgentsException is called, the timeScale is set to 0.
        /// The simulation will end since no steps will be taken.
        public UnityAgentsException(string message) : base(message)
        {

        }

        /// A constructor is needed for serialization when an exception propagates 
        /// from a remoting server to the client. 
        protected UnityAgentsException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        {
        }
    }
}
