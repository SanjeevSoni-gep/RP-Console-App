// See https://aka.ms/new-console-template for more information
using Leo.Communication.Http;
using Leo.Communication.Http.Interfaces;




namespace RP
{
    class Test
    {
        
        public static void Main(string[] args)
        {
            //stic readonly HttpClient client = new HttpClient();

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


                    CallingAPI api = new CallingAPI();
                    var response = api.callAPI();
                    
                    }
                    Console.ReadLine();
                }
            }
        }



    class CallingAPI
    {
        public async Task callAPI()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
            //client.DefaultRequestHeaders.Accept.Add()
            //var response = client.GetAsync("ssResult");
            string url = "https://xkcd.com/info.0.json";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Something went wrong...");
                }
            }
        }

    }

}





