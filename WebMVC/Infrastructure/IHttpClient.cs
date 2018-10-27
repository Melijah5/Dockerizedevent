using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{ 
    // interface is establishing contract 
    // interface only Defintion
    public interface IHttpClient
    {
        // authorizationToken - at the first time we dont need token
        //Url -

        // Get
        Task<string> GetStringAsync(string uri, string authorizationToken = null, string authorizationMethod = "Bearer");
      
        // creation
        Task<HttpResponseMessage> PostAsync<T>(string uri, T newevent, string authorizationToken = null, string authorizationMethod = "Bearer");

        Task<HttpResponseMessage> DeleteAsync(string uri, string authorizationToken = null, string authorizationMethod = "Bearer");
        
        // changing
        Task<HttpResponseMessage> PutAsync<T>(string uri, T newevent, string authorizationToken = null, string authorizationMethod = "Bearer");
    }
}
