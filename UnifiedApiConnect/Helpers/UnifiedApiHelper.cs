// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. See full license at the bottom of this file. 

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UnifiedApiConnect.Models;

namespace UnifiedApiConnect.Helpers
{
    public class UnifiedApiHelper
    {
        static MediaTypeWithQualityHeaderValue Json = new MediaTypeWithQualityHeaderValue("application/json");


        //public static async Task<Email> GetEmailsAsync(string accessToken, int limit)
        //{
        //    List<Email> EmailList = new List<Email>();
            
        //    using (var client = new HttpClient())
        //    {
        //        using (var request = new HttpRequestMessage(HttpMethod.Get, Settings.GetMailUrl))
        //        {
        //            request.Headers.Accept.Add(Json);
        //            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        //            using (var response = await client.SendAsync(request))
        //            {
        //                if (response.StatusCode == HttpStatusCode.OK)
        //                {
        //                    var json = JObject.Parse(await response.Content.ReadAsStringAsync());
        //                    Emaillist.add(json?["Subject"]?.ToString());
        //                }
        //            }
        //        }
        //    }

        //    return Emaillist;
        //}

    }
}

//********************************************************* 
// 
//O365-AspNetMVC-Unified-API-Connect, https://github.com/OfficeDev/O365-AspNetMVC-Unified-API-Connect
//
//Copyright (c) Microsoft Corporation
//All rights reserved. 
//
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// ""Software""), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:

// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
//********************************************************* 
