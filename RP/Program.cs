// See https://aka.ms/new-console-template for more information
using Leo.Communication.Http;
using Leo.Communication.Http.Interfaces;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace RP
{
    class Test
    {
        
        public static void Main(string[] args)
        {
            
            List<string> woIdList = new List<string>();

            //protected readonly ILeoHttpClient _leoHttpClient;
            string woId = Console.ReadLine();
            woIdList.Add(woId);


            while (woId != "")
            {
                woId = Console.ReadLine();
                woIdList.Add(woId);
            }

            if (woId == "")
            {
                foreach (string value in woIdList)
                {
                    Console.WriteLine("WOid-> : " + " " + value);
                    // TODO: call apis

                    if(value!="")
                    {
                        CallingAPI api = new CallingAPI();
                        var response = api.callAPIForV1(value);

                    }

                }
                    Console.ReadLine();
                }
            }
        }



    class CallingAPI
    {

        public async Task callAPIForV1(string woId)
        {
            var tokenV1 = "becb*e6xHpuTmjA7*cE31VTbaSD5eqvN14Vwr0A*6Ae93XsbLOsyaH1BYDKIErSspYEc2m3lesNKnvz1u6J5aDMKMAVroa2Eiea+Vr*lgVrasB7wrAwPEEic4oMIGmZQy6oNkSAyJQHjX+BD5O*HhCagRSO51Meh4ijgX2LAOzsJC9O9+hgbErCe0YSRLQMHRb4mcRp559FhRlXZ*Lc8ojgRSiMIigV+rSrkcH3wHR6j7lgsQvrLlKAomc8UJKQqCXUY+kd93DgfQB4Q2sXT3HTVwiKpOqWxyXbTdMBI1HnbIKgTU1Ku9C5+5voW1lQt0WmO+FqfPcyEdEOhiOYDMQM8IKfKE7JAJXU+ay7EykeocQKKjqEOCrMbu8JOT5Aa3e6H0d3qhc+uaO+vrXLEQLt4HiDqK37UEAz8NBrIiq5DXXrM4b*S*l96loe8wkM0evq8420zPPOAmoCYZPGnOdy+aqqe1Uyf*orxNgy3Qh8U99epTTCK1H3Ie24Tqjb0oYnBX*CHJ4SlaBCWZTQi*nRFrBLeryg2jP1a7plwpH*Ib9l5rdfIaQeZ5P8H8VwoORUvNv2f9AccG*1fSX*DSZvIXWNDdulgaewgZQlHyo2gjiCGNH92DBtcoeNoYNCYOY+uMdpUztXQ2SLYXCoU7pbSmGkbvOmxMNWCIKCB63mlpZutRsrOr4GKd0df6XqG3s84eZYkZfiuBjIlagbemPbg6E+ooM7+0SQ6XWpocipL8My5ThcleQeJy55H88dIzsDO8uC+KnmqwMvS3iRHvxcHbygdyyXm2Yxaf6ZOHPYvJ+8exkNI+lK4L2uk54Qxwxjl0vjjg+*A648OJ5C7L5IQAYc0UalEaAaL8bj8TNQwq4ObPxsCzAs*ZST3gHyEqGuFAQVU59LCgEbGQYEtGWPKD8xhfij9hTPV3ZkhMnrsHk481XYFy+txggBmrTtAIWzpgQWsd*TL13AfXQ9w4yPsMaG6UnTbo4*UYSRb9RsazrxBkWc6CE7j+8fnjUGQBcdc3ouvyoRVy01+sKR7c+V7N23YK00+1WYXN6KCzpPzilTSt*e1*Pwg*WqxDG7WMDgMfAtpLqnmRdYrVoX7bR3ta51uEfkaIciSiUW0G5050lkOzVyvaOnw2gEeQyn4JJXUPl16etmzmE7Nc6jIA8NSp**pnXxAChtKy+VkF9HPwkLSRUrmCpn1zAf3xMZLjAo0GlI2sM0PF6L2BdPCyp2QD*6wP3aUObyS9lg+y2Pzh*6XDwRnYqST3SV0NnPEDh9GfBGaHHUkQrAA35ifDWQgRNoPXnIBXo288z2oTv6SQDqDnD9jYkBgZOfWKFtfq1gXsvzMp7+o42jG2z7vTdGQ608JQRT1mr2zzDoGN6t+rAVhxVbxdkgTra*CBkbE3M43sNvqovL1IGgSpMmMBAyyxKl2*5O3QmPdgsGJqDO+Wcrm*pzPRgFe*TL2j*9A5SxhsdaIQ5l9ev*6VFXbMrOIGtZTjDg76RDMTi1IzqVhWHdOApht+E4N5PYynMiwjnIe*DSlz7QPNn5fiBgCyY9vw+sYqXySoX4YmKpYr9WpO6fm8PR6gjBs+368ajyw*99CxHQgeW428ENPofoAhANCEfFWdu45VH0q9cgSmTQ=";
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenV1);
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "89031208dbe043a8b46a883926414e7e");
            string baseUrl = "https://api-nexxeaksqc.gep.com/nexxecollaborationmfg/api/v1/ManufacturingVisiblity/";
            string endUrl = "/Schedule/00000000-0000-0000-0000-000000000000";
            string url = $"{baseUrl}{woId}{endUrl}";


            string baseUrl2 = "https://api-nexxeaksqc.gep.com/nexxecollaborationpo/api/v1/PurchaseOrderSchedule/";
            string endUrl2 = "";
            string url2 ="";
            var result="";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    // need to change as per above response
                    //referenceDocScheduleId= referenceDocScheduleId as string;
                  

                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Something went wrong...");
                }
            }
            endUrl2 = "807cf9a8-8a1b-4494-960a-2e6eb6211c03";
            url2 = $"{baseUrl2}{endUrl2}";
            var referenceDocScheduleId = JToken.Parse(result)["returnValue"]["woDemandSource"];

            using (HttpResponseMessage response2 = await client.GetAsync(url2))
            {
                if (response2.IsSuccessStatusCode)
                {
                    var result2 = await response2.Content.ReadAsStringAsync();

                }
            }
        }

    }

}





