using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace AI_TechSeries
{
    namespace AI
    {
        namespace Demo
        {
            namespace TextAnalytics
            {
                /// <summary>
                /// Allows authentication to the API using a basic apiKey mechanism
                /// </summary>
                class ApiKeyServiceClientCredentials : ServiceClientCredentials
                {
                    private readonly string subscriptionKey;

                    /// <summary>
                    /// Creates a new instance of the ApiKeyServiceClientCredentails class
                    /// </summary>
                    /// <param name="subscriptionKey">The subscription key to authenticate and authorize as</param>
                    public ApiKeyServiceClientCredentials(string subscriptionKey)
                    {
                        this.subscriptionKey = subscriptionKey;
                    }

                    /// <summary>
                    /// Add the Basic Authentication Header to each outgoing request
                    /// </summary>
                    /// <param name="request">The outgoing request</param>
                    /// <param name="cancellationToken">A token to cancel the operation</param>
                    public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
                    {
                        if (request == null)
                        {
                            throw new ArgumentNullException("request");
                        }

                        request.Headers.Add("Ocp-Apim-Subscription-Key", this.subscriptionKey);

                        return base.ProcessHttpRequestAsync(request, cancellationToken);
                    }
                }
            }
        }
    }
}
