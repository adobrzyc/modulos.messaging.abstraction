using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// ReSharper disable UnusedType.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace Modulos.Messaging
{
    public class MessageConfig : Freezable, IMessageConfig
    {
        public MessageConfig()
        {
          
        }

        public MessageConfig(IMessageConfig source)
        {
            CopyFromSource(source);
        }

        public void CopyFromSource(IMessageConfig source)
        {
            authenticationMode = source.AuthenticationMode;
            requestSerializer = source.RequestSerializer;
            responseSerializerId = source.ResponseSerializer;
            requestCompressionEngine = source.RequestCompressor;
            responseCompressionEngine = source.ResponseCompressor;
            timeout = source.Timeout;
            maxInvokeAttempts = source.MaxInvokeAttempts;
            endpointConfigMark = source.EndpointConfigMark;
            transportEngine = source.TransportEngine;
            supportConnectionMark = source.SupportConnectionMark;
            
            if(source.Properties.Count > 0)
                Properties = new Dictionary<string, string>(source.Properties);
        }

        public bool ValidateEndpoint 
        {
            get => validateEndpoint;
            set
            {
                ThrowIfFrozen();
                validateEndpoint = value;
            }
        }

        public TransportEngineId TransportEngine
        {
            get => transportEngine;
            set
            {
                ThrowIfFrozen();
                transportEngine = value;
            }
        }

        public AuthenticationMode AuthenticationMode
        {
            get => authenticationMode;
            set
            {
                ThrowIfFrozen();
                authenticationMode = value;
            }
        }

        public SerializerId RequestSerializer
        {
            get => requestSerializer;
            set
            {
                ThrowIfFrozen();
                requestSerializer = value;
            }
        }

        public SerializerId ResponseSerializer
        {
            get => responseSerializerId;
            set
            {
                ThrowIfFrozen();
                responseSerializerId = value;
            }
        }

        public CompressionEngineId RequestCompressor
        {
            get => requestCompressionEngine;
            set
            {
                ThrowIfFrozen();
                requestCompressionEngine = value;
            }
        }

        public CompressionEngineId ResponseCompressor
        {
            get => responseCompressionEngine;
            set
            {
                ThrowIfFrozen(); 
                responseCompressionEngine = value;
            }
        }

        public TimeSpan Timeout
        {
            get => timeout;
            set
            {
                ThrowIfFrozen();
                timeout = value;
            }
        }

        public int MaxInvokeAttempts
        {
            get => maxInvokeAttempts;
            set
            {
                ThrowIfFrozen();
                maxInvokeAttempts = value;
            }
        }

        public bool SupportConnectionMark
        {
            get => supportConnectionMark;
            set
            {
                ThrowIfFrozen();
                supportConnectionMark = value;
            }
        }


        public IDictionary<string, string> Properties { get; private set; } = new ConcurrentDictionary<string, string>();

        public EndpointConfigMark EndpointConfigMark
        {
            get => endpointConfigMark;
            set
            {
                ThrowIfFrozen();
                endpointConfigMark = value;
            }
        }

        public override void Freeze()
        {
            base.Freeze();
            Properties = new ReadOnlyDictionary<string, string>(Properties);
        }

        public string this[string key]
        {
            get => Properties[key];
            set
            {
                if (IsFrozen)
                    throw new ObjectIsFrozenException("Collection is frozen.");

                if (Properties.ContainsKey(key))
                    Properties[key] = value;
                else Properties.Add(key,value);
            }
        }

        private AuthenticationMode authenticationMode = AuthenticationMode.None;
        private TimeSpan timeout;
        private int maxInvokeAttempts = 1;
        private EndpointConfigMark endpointConfigMark;
        private SerializerId requestSerializer;// = new SerializerId("JsonNet");
        private SerializerId responseSerializerId;// = new SerializerId("JsonNet");
        private CompressionEngineId requestCompressionEngine;// = new CompressionEngineId("none");
        private CompressionEngineId responseCompressionEngine;// =  new CompressionEngineId("none");
        private TransportEngineId transportEngine;
        private bool supportConnectionMark;
        private bool validateEndpoint;
    }
}