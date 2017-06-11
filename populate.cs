using news_in.Articles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace news_in
{
    class populate
    {

        public async static Task<RootObject> google_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=google-news&sortBy=top&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> washington_post_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-washington-post&sortBy=top&apiKey=f3ee1d11c05748d79294a20016fd69c8");
        
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> new_york_times_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-new-york-times&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> huffington_post_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-huffington-post&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> bbc_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=bbc-news&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> cnn_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=cnn&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> usa_today_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=usa-today&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> Associated_press_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=associated-press&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> cnbc_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=cnbc&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> independent_news_Async()


        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=independent&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> times_of_india_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-times-of-india&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> the_hindu_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-hindu&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> national_geographic_Async()
        {

            RootObject data = null;
            var http = new HttpClient();
          
                var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=national-geographic&apiKey=f3ee1d11c05748d79294a20016fd69c8");
                    var result = await response.Content.ReadAsStringAsync();
                    var serializer = new DataContractJsonSerializer(typeof(RootObject));
                    var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));

                    data = (RootObject)serializer.ReadObject(ms);
                    return data;
            
        }
        public async static Task<RootObject> bloomberg_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=bloomberg&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> buisness_insider_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=business-insider&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> buisness_insider_uk_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=business-insider-uk&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> fortune_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=fortune&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> financial_times_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=financial-times&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> wall_street_journal_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-wall-street-journal&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> the_economist_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-economist&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> verge_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-verge&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> techcrunch_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=techcrunch&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> next_web_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-next-web&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> techrradar_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=techradar&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> time_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=time&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> mashable_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=mashable&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> bbc_sport_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=bbc-sport&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> cric_info_sport_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=espn-cric-info&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> guardian_uk_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-guardian-uk&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> engadget_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=engadget&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }

        public async static Task<RootObject> recode_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=recode&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }

        public async static Task<RootObject> ars_technica_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=ars-technica&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }

        public async static Task<RootObject> hacker_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=hacker-news&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> polygon_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=polygon&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> ign_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=ign&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> buzzfeed_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=buzzfeed&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> mtv_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=mtv-news&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> daily_mail_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=daily-mail&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;

        }
        public async static Task<RootObject> entertainment_weekly_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=entertainment-weekly&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> lad_bible_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-lad-bible&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
                public async static Task<RootObject> mtv_uk_Async()
                {


                    var http = new HttpClient();
                    var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=mtv-news-uk&apiKey=f3ee1d11c05748d79294a20016fd69c8");
                    var result = await response.Content.ReadAsStringAsync();
                    var serializer = new DataContractJsonSerializer(typeof(RootObject));

                    var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
                    var data = (RootObject)serializer.ReadObject(ms);
                    return data;
                }
        public async static Task<RootObject> espn_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=espn&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> football_italia_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=football-italia&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> four_our_two_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=four-four-two&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> fox_sports_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=fox-sports&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> fox_sports_latest_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=fox-sports&sortBy=latest&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> nfl_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=nfl-news&sortBy=top&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> nfl_latest_news_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=nfl-news&sortBy=latest&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }

        public async static Task<RootObject> sky_sports_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=sky-sports-news&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> talk_sports_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=talksport&sortBy=latest&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> sport_bible_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-sport-bible&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> cric_info_latest_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=espn-cric-info&sortBy=latest&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> telegraph_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-telegraph&sortBy=latest&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> times_of_india_latest_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=the-times-of-india&sortBy=latest&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
        public async static Task<RootObject> metro_Async()
        {


            var http = new HttpClient();
            var response = await http.GetAsync("  https://newsapi.org/v1/articles?source=metro&sortBy=latest&apiKey=f3ee1d11c05748d79294a20016fd69c8");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
    }
}
