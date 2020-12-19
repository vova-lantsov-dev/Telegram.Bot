﻿using System.Net.Http;
using System.Text;
using System.Text.Json;
using Telegram.Bot.Requests.Abstractions;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Represents a API request
    /// </summary>
    /// <typeparam name="TResponse">Type of result expected in result</typeparam>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract record RequestBase<TResponse> : IRequest<TResponse>
    {
        /// <inheritdoc />
        //[JsonIgnore]
        public HttpMethod Method { get; }

        /// <inheritdoc />
        //[JsonIgnore]
        public string MethodName { get; protected set; }

        /// <summary>
        /// Initializes an instance of request
        /// </summary>
        /// <param name="methodName">Bot API method</param>
        protected RequestBase(string methodName)
            : this(methodName, HttpMethod.Post)
        { }

        /// <summary>
        /// Initializes an instance of request
        /// </summary>
        /// <param name="methodName">Bot API method</param>
        /// <param name="method">HTTP method to use</param>
        protected RequestBase(string methodName, HttpMethod method)
        {
            MethodName = methodName;
            Method = method;
        }

        /// <summary>
        /// Generate content of HTTP message
        /// </summary>
        /// <returns>Content of HTTP request</returns>
        public virtual HttpContent ToHttpContent()
        {
            string payload = JsonSerializer.Serialize(this, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            return new StringContent(payload, Encoding.UTF8, "application/json");
        }

        /// <summary>
        /// Allows this object to be used as a response in webhooks
        /// </summary>
        //[JsonIgnore]
        public bool IsWebhookResponse { get; init; }

        /// <summary>
        /// If <see cref="IsWebhookResponse"/> is set to <see langword="true"/> is set to the method
        /// name, otherwise it won't be serialized
        /// </summary>

        //[JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        internal string? WebHookMethodName => IsWebhookResponse ? MethodName : default;
    }
}
