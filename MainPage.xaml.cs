using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using news_in.Articles;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI;
using System.Net.NetworkInformation;
using System.Threading.Tasks;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace news_in
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Article> big_hot_news { get; set; }
        public ObservableCollection<Article> medium_hot_news { get; set; }
        public ObservableCollection<Article> small_hot_news { get; set; }
        public ObservableCollection<Article> more_hot_news_us { get; set; }
        public ObservableCollection<Article> more_hot_news_ind { get; set; }
        public ObservableCollection<Article> more_hot_news_uk { get; set; }

        public ObservableCollection<Article> featured_story { get; set; }
        public ObservableCollection<Article> buisness_news_1 { get; set; }
        public ObservableCollection<Article> buisness_news_2 { get; set; }
        public ObservableCollection<Article> buisness_news_wsj { get; set; }
        public ObservableCollection<Article> buisness_news_ft { get; set; }
        public ObservableCollection<Article> buisness_news_te { get; set; }
        public ObservableCollection<Article> tech1 { get; set; }
        public ObservableCollection<Article> tech2 { get; set; }
        public ObservableCollection<Article> tech3 { get; set; }
        public ObservableCollection<Article> techs { get; set; }
        public ObservableCollection<Article> tech_more { get; set; }
        public ObservableCollection<Article> featured_story_1 { get; set; }
        public ObservableCollection<Article> enter_fun_main { get; set; }
        public ObservableCollection<Article> enter_fun_sub { get; set; }
        public ObservableCollection<Article> more_enter_fun { get; set; }
        public ObservableCollection<Article> sports_news_1 { get; set; }
        public ObservableCollection<Article> sports_news_2 { get; set; }
        public ObservableCollection<Article> more_sports_news { get; set; }
        public ObservableCollection<Article> cricket_news { get; set; }
        public ObservableCollection<Article> bookmark { get; set; }
        public ObservableCollection<Article> nfl_all { get; set; }
        
        public RootObject google_news { get; set; }
        public RootObject washington_post { get; set; }
        public RootObject new_york_times { get; set; }
        public RootObject bbc_news { get; set; }
        public RootObject huffington_post { get; set; }
        public RootObject cnn_news { get; set; }
        public RootObject usa_today_news { get; set; }
        public RootObject associated_press_news { get; set; }
        public RootObject cnbc_news { get; set; }
        public RootObject independent_news { get; set; }
        public RootObject times_of_india_news { get; set; }
        public RootObject the_hindu_news { get; set; }
        public RootObject nat_geo { get; set; }
        public RootObject bloomberg { get; set; }
        public RootObject buisness_insider { get; set; }
        public RootObject buisness_insider_uk { get; set; }
        public RootObject fortune { get; set; }
        public RootObject financial_times { get; set; }
        public RootObject wall_street_journal { get; set; }
        public RootObject the_economist { get; set; }
        public RootObject fox_sports_latest_news { get; set; }
        public RootObject verge_news { get; set; }
        public RootObject techcrunch_news { get; set; }
        public RootObject next_web { get; set; }
        public RootObject techradar_news { get; set; }
        public RootObject time_news { get; set; }
        public RootObject mashable_news { get; set; }
        public RootObject bbc_sports_news { get; set; }
        public RootObject cric_info_news { get; set; }
        public RootObject the_guardian_news { get; set; }
        public RootObject engadget_news { get; set; }
        public RootObject recode_news { get; set; }
        public RootObject ars_technica_news { get; set; }
        public RootObject hacker_news { get; set; }
        public RootObject polygon_news { get; set; }
        public RootObject ign { get; set; }
        public RootObject buzzfeed_news { get; set; }
        public RootObject mtv_news { get; set; }
        public RootObject daily_mail_news { get; set; }
        public RootObject entertainment_weekly_news { get; set; }
        public RootObject the_lad_bible_news { get; set; }
        public RootObject mtv_news_uk { get; set; }
        public RootObject espn_news { get; set; }
        public RootObject cric_info_latest_news { get; set; }
        public RootObject football_italia_news { get; set; }
        public RootObject four_four_two_news { get; set; }
        public RootObject fox_sports_news { get; set; }
        public RootObject nfl_news { get; set; }
        public RootObject sky_sports_news { get; set; }
        public RootObject talk_sports_news { get; set; }
        public RootObject sports_bible_news { get; set; }
        public RootObject nfl_latest_news { get; set; }
        public RootObject the_telegraph_news { get; set; }
        public RootObject times_of_india_latest_news { get; set; }
        public RootObject metro_news { get; set; }
        
        public string ic;
        public MainPage()
        {

            this.InitializeComponent();
            Initialization();
            get_first_news();

        }

 

        private void all_news()
        {
            dock_ring.IsActive = true;
            dock_ring.Visibility = Visibility.Visible;
            get_first_news();


            us();
            india();
            uk(); 
            buisness();
            top_tech_news();
            featured_nat_geo();
            featured_time();
            entertainment_fun();
            sports_news();
            

        }
        private void Initialization()
        {

            big_hot_news = new ObservableCollection<Article>();
            medium_hot_news = new ObservableCollection<Article>();
            small_hot_news = new ObservableCollection<Article>();
            more_hot_news_us = new ObservableCollection<Article>();
            more_hot_news_ind = new ObservableCollection<Article>();
            more_hot_news_uk = new ObservableCollection<Article>();
            featured_story = new ObservableCollection<Article>();
            buisness_news_1 = new ObservableCollection<Article>();
            buisness_news_2 = new ObservableCollection<Article>();
            buisness_news_wsj = new ObservableCollection<Article>();
            buisness_news_ft = new ObservableCollection<Article>();
            buisness_news_te = new ObservableCollection<Article>();
            tech1 = new ObservableCollection<Article>();
            tech2 = new ObservableCollection<Article>();
            tech3 = new ObservableCollection<Article>();
            techs = new ObservableCollection<Article>();
            tech_more = new ObservableCollection<Article>();
            featured_story_1 = new ObservableCollection<Article>();
            enter_fun_main = new ObservableCollection<Article>();
            enter_fun_sub = new ObservableCollection<Article>();
            more_enter_fun = new ObservableCollection<Article>();
            sports_news_1 = new ObservableCollection<Article>();
            sports_news_2 = new ObservableCollection<Article>();
            more_sports_news = new ObservableCollection<Article>();
            cricket_news = new ObservableCollection<Article>();
            bookmark = new ObservableCollection<Article>();
            nfl_all = new ObservableCollection<Article>();
        }
        private async void get_first_news()
        {
            Top_news_text.Visibility = Visibility.Collapsed;
            More_hot_news_button_us.Visibility = Visibility.Collapsed;
            about_text.Text = "Loading...";

            about_text.Visibility = Visibility.Visible;
            dock_ring.IsActive = true;

            dock_ring.Visibility = Visibility.Visible;
            try
            {

                google_news = await populate.google_news_Async();

                cnn_news = await populate.cnn_news_Async();
                associated_press_news = await populate.Associated_press_news_Async();
                huffington_post = await populate.huffington_post_news_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
                about_text.Text = e.Message;
            }

                if (google_news != null) {
                    ic = string.Format("ms-appx:///Assets/google.jpg");
                    try {
                        for (int i = 0; i < google_news.articles.Count; i++)
                        {
                            google_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.RelativeOrAbsolute));
                        }
                    }
                    catch (Exception e)
                    {
                        about_text.Text = e.Message;
                    }
                

            google_news = check(google_news);

            if  (google_news.articles[0].urlToImage != null)
                    big_hot_news.Add(google_news.articles[0]);
            if (google_news.articles[1].urlToImage != null)
                    medium_hot_news.Add(google_news.articles[1]);
                if (google_news.articles[2].urlToImage != null)
                    medium_hot_news.Add(google_news.articles[2]);


                try { 
            ic = string.Format("ms-appx:///Assets/cnn.png");
            for (int i = 0; i < cnn_news.articles.Count; i++)
            {
                cnn_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/ap.png");
            for (int i = 0; i < associated_press_news.articles.Count; i++)
            {
                associated_press_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/hp.png");
            for (int i = 0; i < huffington_post.articles.Count; i++)
            {
               huffington_post.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }

                }
                catch(Exception ) { }
            cnn_news = check(cnn_news);
            associated_press_news = check(associated_press_news);
            huffington_post = check(huffington_post); google_news = check(google_news);
                try { 
            for (int i = 3; i < google_news.articles.Count; i++)
                {
                    small_hot_news.Add(google_news.articles[i]);
                }
             for (int i = 0; i < 3; i++)
                {  
                    if(i<huffington_post.articles.Count&&huffington_post.articles[i].urlToImage!=null)
                    small_hot_news.Add(huffington_post.articles[i]);
                    if(i<cnn_news.articles.Count && cnn_news.articles[i].urlToImage != null)
                    small_hot_news.Add(cnn_news.articles[i]);
                    if(i<associated_press_news.articles.Count && associated_press_news.articles[i].urlToImage != null)
                    small_hot_news.Add(associated_press_news.articles[i]);
                }
                }
                catch(Exception ) {
                }
                Top_news_text.Visibility = Visibility.Visible;
                More_hot_news_button_us.Visibility = Visibility.Visible;
            featured_time();
            
            us();

            }
            else
            {
                dock_ring.Visibility = Visibility.Collapsed;
                about_text.FontSize = 27;
                about_text.Text = "No connection ):";
              
            }
        }
        private RootObject check(RootObject error)
        {
            try
            {
                if (error != null)
                    for (int i = 0; i < error.articles.Count; i++)
                    {
                        if (error.articles[i].description == null)
                        {
                            error.articles[i].description = "No description available";

                        }
                        if (error.articles[i].title == null)
                        {
                            error.articles[i].title = "No title available";
                        }

                    }
                for (int i = 0; i < error.articles.Count; i++)
                {
                    if (error.articles[i].urlToImage == null)
                    {
                        error.articles[i].urlToImage = error.articles[i].image.ToString();
                    }
                }
                
                for (int i = 0; i < error.articles.Count; i++)
                {

                    if (!Uri.IsWellFormedUriString(error.articles[i].url, UriKind.Absolute))
                    {
                        error.articles.Remove(error.articles[i]);
                    }

                }


            }
            catch(Exception e)
            {

            }
            return error;
        }
        public async void featured_nat_geo()
        {
         
            featured_story_text1.Visibility = Visibility.Collapsed;
            try
            {
                nat_geo = await populate.national_geographic_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
            }


            try { 
                    for (int i = 0; i < nat_geo.articles.Count; i++)
                    {
                        if(nat_geo.articles[i].urlToImage!=null)
                        featured_story.Add(nat_geo.articles[i]);
                    }
            }
            catch(Exception )
            {

            }
                    featured_story_text1.Visibility = Visibility.Visible;
           
            entertainment_fun();
        }


        private async void us()
        {
            try
            {

                usa_today_news = await populate.usa_today_news_Async();
                new_york_times = await populate.new_york_times_news_Async();
                washington_post = await populate.washington_post_news_Async();
                metro_news = await populate.metro_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
            }

            try { 
            ic = string.Format("ms-appx:///Assets/ut.png");
            for (int i = 0; i < usa_today_news.articles.Count; i++)
            {
                usa_today_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/images.jpg");
            for (int i = 0; i < washington_post.articles.Count; i++)
            {
                washington_post.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));

            }
            ic = string.Format("ms-appx:///Assets/nyt.png");
            for (int i = 0; i < new_york_times.articles.Count; i++)
            {
                new_york_times.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/metro.jpg");
            for (int i = 0; i < metro_news.articles.Count; i++)
            {
               metro_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception )
            {

            }
            usa_today_news = check(usa_today_news);
            new_york_times = check(new_york_times);
            washington_post = check(washington_post);
            metro_news = check(metro_news);
          
            for (int i = 0; i < 50; i++)
                {
                try { 
                    if (i < usa_today_news.articles.Count && usa_today_news.articles[i].urlToImage != null)
                    {
                        more_hot_news_us.Add(usa_today_news.articles[i]);
                    }
                }
                catch (Exception) { }
                try { 
                    if (i < new_york_times.articles.Count && new_york_times.articles[i].urlToImage != null)
                    {
                        more_hot_news_us.Add(new_york_times.articles[i]);
                    }
                }
                catch (Exception) { }
                try { 
                    if (i < washington_post.articles.Count && washington_post.articles[i].urlToImage != null)
                    {
                        more_hot_news_us.Add(washington_post.articles[i]);
                    }
                }
                catch(Exception) { }
                try { 
                if (i < metro_news.articles.Count && metro_news.articles[i].urlToImage != null)
                {
                    more_hot_news_us.Add(metro_news.articles[i]);
                }
                }
                catch (Exception) { }
                try { 
                if (i < huffington_post.articles.Count && huffington_post.articles[i].urlToImage != null&&i>2)
                {
                    more_hot_news_us.Add(huffington_post.articles[i]);
                }
                }
                catch (Exception) { }
                try { 
                if (i < cnn_news.articles.Count && cnn_news.articles[i].urlToImage != null&&i>2)
                {
                    more_hot_news_us.Add(cnn_news.articles[i]);
                }
                }
                catch (Exception) { }
                try { 
                if (i <associated_press_news.articles.Count && associated_press_news.articles[i].urlToImage != null&&i>2)
                {
                    more_hot_news_us.Add(associated_press_news.articles[i]);
                }
                }
                catch (Exception) { }
            }
            
        }
        private async void india() { 
            try
            {
                times_of_india_news = await populate.times_of_india_news_Async();
                the_hindu_news = await populate.the_hindu_news_Async();
                times_of_india_latest_news = await populate.times_of_india_latest_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in getting some news";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/toi.jpg");
            for (int i = 0; i < times_of_india_news.articles.Count; i++)
            {
                times_of_india_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/toi.jpg");
            for (int i = 0; i < times_of_india_latest_news.articles.Count; i++)
            {
                times_of_india_latest_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/th.jpg");
            for (int i = 0; i < the_hindu_news.articles.Count; i++)
            {
                the_hindu_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception )
            {

            }
            times_of_india_news = check(times_of_india_news);
            the_hindu_news = check(the_hindu_news);
            times_of_india_latest_news = check(times_of_india_latest_news);
            try { 

            for (int i = 0; i < 20; i++)
            {
                if (i < times_of_india_news.articles.Count&&times_of_india_news.articles[i].urlToImage!=null)
                {
                    more_hot_news_ind.Add(times_of_india_news.articles[i]);
                }
                if (i < the_hindu_news.articles.Count && the_hindu_news.articles[i].urlToImage != null)
                {
                    more_hot_news_ind.Add(the_hindu_news.articles[i]);
                }
            }
            }
            catch(Exception ) {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";

            }
            int a = times_of_india_latest_news.articles.Count;
            int b = times_of_india_news.articles.Count;
            if (a < b)
            {

            }
            else
                a = b;
            try { 
            for (int i = 0; i < a; i++)
            {
                if (times_of_india_latest_news.articles[i] != times_of_india_news.articles[i])
                {

                    if (times_of_india_latest_news.articles[i].urlToImage != null)
                        more_hot_news_ind.Add(times_of_india_latest_news.articles[i]);
                }
            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }

        }
        private async void uk() { 
            try
            {
                bbc_news = await populate.bbc_news_Async();
                the_guardian_news = await populate.guardian_uk_Async();
                the_telegraph_news = await populate.telegraph_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/tg.png");
            for (int i = 0; i < the_guardian_news.articles.Count; i++)
            {
                the_guardian_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/bbc.png");
            for (int i = 0; i < bbc_news.articles.Count; i++)
            {
                bbc_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/telegraph.png");
            for (int i = 0; i < the_telegraph_news.articles.Count; i++)
            {
                the_telegraph_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception ) { }
            bbc_news = check(bbc_news);
            the_guardian_news = check(the_guardian_news);
            the_telegraph_news = check(the_telegraph_news);
            try { 
            for (int i = 0; i < 40; i++)
            {
                if (i < bbc_news.articles.Count && bbc_news.articles[i].urlToImage != null)
                    more_hot_news_uk.Add(bbc_news.articles[i]);
                if (i < the_guardian_news.articles.Count && the_guardian_news.articles[i].urlToImage != null)
                    more_hot_news_uk.Add(the_guardian_news.articles[i]);
                if (i < the_telegraph_news.articles.Count && the_telegraph_news.articles[i].urlToImage != null)
                    more_hot_news_uk.Add(the_telegraph_news.articles[i]);

            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
        }
        private async void buisness()
        {

            More_news_buisness_button.Visibility = Visibility.Collapsed;
            buisness_text.Visibility = Visibility.Collapsed;
            try { 
            bloomberg = await populate.bloomberg_Async();
            the_economist = await populate.the_economist_Async();
            fortune = await populate.fortune_Async();
            buisness_insider = await populate.buisness_insider_Async();
            }

            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/bloomberg.jpg");
            for (int i = 0; i < bloomberg.articles.Count; i++)
            {

                bloomberg.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/economist.png");
            for (int i = 0; i < the_economist.articles.Count; i++)
            {
                the_economist.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/fortune.png");
            for (int i = 0; i < fortune.articles.Count; i++)
            {
                fortune.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/bi.jpg");
            for (int i = 0; i < buisness_insider.articles.Count; i++)
            {
              buisness_insider.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception ) { }
            bloomberg = check(bloomberg);
            the_economist = check(the_economist);
            fortune = check(fortune);
            buisness_insider = check(buisness_insider);
            try { 
            if (the_economist.articles[0].urlToImage != null)
            {
                buisness_news_1.Add(bloomberg.articles[0]);
            }

            if (fortune.articles[0].urlToImage != null)
            {
                buisness_news_1.Add(fortune.articles[0]);
            }
            if (buisness_insider.articles[0].urlToImage != null)
            {
                buisness_news_1.Add(buisness_insider.articles[0]);
            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            buisness_text.Visibility = Visibility.Visible;
            try { 
            wall_street_journal = await populate.wall_street_journal_Async();
            buisness_insider_uk = await populate.buisness_insider_uk_Async();
            financial_times = await populate.financial_times_Async();
            cnbc_news = await populate.cnbc_news_Async();
            }

            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/wsj.jpg");
            for (int i = 0; i < wall_street_journal.articles.Count; i++)
            {
                if (wall_street_journal.articles[i].urlToImage != null)
                wall_street_journal.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/biuk.png");
            for (int i = 0; i < buisness_insider_uk.articles.Count; i++)
            {

                if (buisness_insider_uk.articles[i].urlToImage != null)
                    buisness_insider_uk.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/ft.jpg");
            for (int i = 0; i < financial_times.articles.Count; i++)
            {

                if (financial_times.articles[i].urlToImage != null)
                    financial_times.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/cnbc.png");
            for (int i = 0; i < cnbc_news.articles.Count; i++)
            {

                if (cnbc_news.articles[i].urlToImage != null)
                    cnbc_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception ) { }
            wall_street_journal = check(wall_street_journal);
            financial_times = check(financial_times);
            cnbc_news = check(cnbc_news);
            buisness_insider_uk = check(buisness_insider_uk);
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i < buisness_insider.articles.Count && i != 0)
                        if (buisness_insider.articles[i].urlToImage != null)
                            buisness_news_2.Add(buisness_insider.articles[i]);
                    if (i < wall_street_journal.articles.Count)
                        if (wall_street_journal.articles[i].urlToImage != null)
                            buisness_news_2.Add(wall_street_journal.articles[i]);
                    if (i < fortune.articles.Count && i != 0)
                        if (fortune.articles[i].urlToImage != null)
                            buisness_news_2.Add(fortune.articles[i]);
                    if (i < bloomberg.articles.Count && i != 0)
                        if (bloomberg.articles[i].urlToImage != null)
                            buisness_news_2.Add(bloomberg.articles[i]);
                    if (i < cnbc_news.articles.Count)
                        if (cnbc_news.articles[i].urlToImage != null)
                            buisness_news_2.Add(cnbc_news.articles[i]);
                    if (i < the_economist.articles.Count)
                        if (the_economist.articles[i].urlToImage != null)
                            buisness_news_2.Add(the_economist.articles[i]);
                    if (i < buisness_insider_uk.articles.Count)
                        if (buisness_insider_uk.articles[i].urlToImage != null)
                            buisness_news_2.Add(buisness_insider_uk.articles[i]);
                    if (i < financial_times.articles.Count)
                        if (financial_times.articles[i].urlToImage != null)
                            buisness_news_2.Add(financial_times.articles[i]);
                }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            try { 
            for (int i = 3; i <4 ; i++)
            {
                if (i < cnbc_news.articles.Count)
                    if (cnbc_news.articles[i].urlToImage != null)
                        buisness_news_2.Add(cnbc_news.articles[i]);
                if (i < the_economist.articles.Count)
                    if (the_economist.articles[i].urlToImage != null)
                        buisness_news_2.Add(the_economist.articles[i]);
            }
                }
                catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            try { 
            for (int i = 3; i < 80; i++)
            {

                if (i < buisness_insider.articles.Count&&buisness_insider.articles[i].urlToImage!=null)
                    buisness_news_wsj.Add(buisness_insider.articles[i]);
                if (i < wall_street_journal.articles.Count && wall_street_journal.articles[i].urlToImage != null)
                    buisness_news_wsj.Add(wall_street_journal.articles[i]);
                if (i < fortune.articles.Count && i!=0 && fortune.articles[i].urlToImage != null)
                    buisness_news_wsj.Add(fortune.articles[i]);
                if (i < buisness_insider_uk.articles.Count && buisness_insider_uk.articles[i].urlToImage != null)
                    buisness_news_wsj.Add(buisness_insider_uk.articles[i]);
                if (i < bloomberg.articles.Count && bloomberg.articles[i].urlToImage != null)
                    buisness_news_wsj.Add(bloomberg.articles[i]);
           
                if (i < cnbc_news.articles.Count&&i!=3 && cnbc_news.articles[i].urlToImage != null)
                    buisness_news_wsj.Add(cnbc_news.articles[i]);
                if (i < financial_times.articles.Count && financial_times.articles[i].urlToImage != null)
                    buisness_news_wsj.Add(financial_times.articles[i]);
                if (i < the_economist.articles.Count&&i!=3 && the_economist.articles[i].urlToImage != null)
                    buisness_news_wsj.Add(the_economist.articles[i]);
            }
            
                }
            catch (Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            More_news_buisness_button.Visibility = Visibility.Visible;
                        top_tech_news();
            india();
        }

        private async void top_tech_news()
        {
            tech_text.Visibility = Visibility.Collapsed;

            More_tech_news.Visibility = Visibility.Collapsed;
            try
            {
                verge_news = await populate.verge_Async();
                recode_news = await populate.recode_Async();
                next_web = await populate.next_web_Async();
                techcrunch_news = await populate.techcrunch_Async();
                techradar_news = await populate.techrradar_Async();
                 ars_technica_news = await populate.ars_technica_Async();
            }
           
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/verge.png");
                for (int i = 0; i < verge_news.articles.Count; i++)
                {
                    verge_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
                }
                ic = string.Format("ms-appx:///Assets/recode.png");
                for (int i = 0; i < recode_news.articles.Count; i++)
                {
                    recode_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
                }
                ic = string.Format("ms-appx:///Assets/thenextweb.jpg");
                for (int i = 0; i < next_web.articles.Count; i++)
                {
                    next_web.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
                }
                ic = string.Format("ms-appx:///Assets/techcrunch.png");
                for (int i = 0; i < techcrunch_news.articles.Count; i++)
                {
                    techcrunch_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
                }
                ic = string.Format("ms-appx:///Assets/techradar.jpg");
                for (int i = 0; i < techradar_news.articles.Count; i++)
                {
                    techradar_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
                }
            for (int i = 0; i < ars_technica_news.articles.Count; i++)
            {
                ars_technica_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception ) { }
            verge_news = check(verge_news);
            recode_news = check(recode_news);
            next_web = check(next_web);
            techcrunch_news = check(techcrunch_news);
            techradar_news = check(techradar_news);
            ars_technica_news = check(ars_technica_news);
            try { 
            if ( verge_news.articles.Count>0 && verge_news.articles[0].urlToImage != null)
                tech1.Add(verge_news.articles[0]);

            if (techcrunch_news.articles.Count>0 &&techcrunch_news.articles[0].urlToImage != null)
                tech2.Add(techcrunch_news.articles[0]);

            if ( techradar_news.articles.Count>0 &&techradar_news.articles[0].urlToImage != null)
                tech2.Add(techradar_news.articles[0]);

            if ( next_web.articles.Count>0&& next_web.articles[0].urlToImage != null)
                tech3.Add(next_web.articles[0]);

            if (recode_news.articles.Count>0 && recode_news.articles[0].urlToImage != null)
                tech3.Add(recode_news.articles[0]);
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            try
            {
                ic = string.Format("ms-appx:///Assets/ars.png");

                for (int i = 1; i < 4; i++)
                {
                    techs.Add(verge_news.articles[i]);
                    techs.Add(next_web.articles[i]);
                    techs.Add(recode_news.articles[i]);
                    techs.Add(ars_technica_news.articles[i]);
                }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            tech_text.Visibility = Visibility.Visible;
            try { 
            polygon_news = await populate.polygon_Async();
                
            ign = await populate.ign_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/polygon.png");
                for (int i = 0; i < polygon_news.articles.Count; i++)
                {
                    polygon_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
                }
             
                ic = string.Format("ms-appx:///Assets/ign.png");
                for (int i = 0; i < ign.articles.Count; i++)
                {
                    ign.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
                }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            polygon_news = check(polygon_news);
     
            ign = check(ign);
            try { 
            for (int i = 4; i < 30; i++)
            {
                if (i < ars_technica_news.articles.Count&&ars_technica_news.articles[i].urlToImage!=null)
                    tech_more.Add(ars_technica_news.articles[i]);
                if (i < recode_news.articles.Count && recode_news.articles[i].urlToImage != null)
                    tech_more.Add(recode_news.articles[i]);
                if (i < next_web.articles.Count && next_web.articles[i].urlToImage != null)
                    tech_more.Add(next_web.articles[i]);
                if (i < verge_news.articles.Count && verge_news.articles[i].urlToImage != null)
                    tech_more.Add(verge_news.articles[i]);
            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            try { 
            for (int i = 1; i < 40; i++)
            {
                if (i<techradar_news.articles.Count && techradar_news.articles[i].urlToImage != null)
                {
                    tech_more.Add(techradar_news.articles[i]);
                }
                if (i<techcrunch_news.articles.Count && techcrunch_news.articles[i].urlToImage != null)
                {
                    tech_more.Add(techcrunch_news.articles[i]);
                }
            
             
                if (i<ign.articles.Count && ign.articles[i].urlToImage != null)
                {
                    tech_more.Add(ign.articles[i]);
                }
                if (i < polygon_news.articles.Count && polygon_news.articles[i].urlToImage != null)
                {
                    tech_more.Add(polygon_news.articles[i]);
                }
            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            try { 
            if ( polygon_news.articles[0].urlToImage != null)
            {
                tech_more.Add(polygon_news.articles[0]);
            }
            if (ars_technica_news.articles[0].urlToImage!=null)
            {

                tech_more.Add(ars_technica_news.articles[0]);

            }

            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }

            More_tech_news.Visibility = Visibility.Visible;
         
           featured_nat_geo();
          
            uk();
        }
        private async void featured_time()
        {
            featured_story_text.Visibility = Visibility.Collapsed;
            try
            {
                time_news = await populate.time_Async();
            }

            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading top news,try again.";
                }
            }

            featured_story_text1.Visibility = Visibility.Collapsed;
            try { 
            for (int i = 0; i < time_news.articles.Count; i++)
            {
                if (time_news.articles[i].urlToImage!=null)
                {

                    featured_story_1.Add(time_news.articles[i]);
                }
            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            featured_story_text.Visibility = Visibility.Visible;
           
            buisness();
          
        }

        private async void entertainment_fun()
        {

            More_enter_fun_news_click.Visibility = Visibility.Collapsed;
            entertainment_fun_text.Visibility = Visibility.Collapsed;
            try
            {
                mashable_news = await populate.mashable_Async();
                buzzfeed_news = await populate.buzzfeed_Async();
                entertainment_weekly_news = await populate.entertainment_weekly_Async();
                daily_mail_news = await populate.daily_mail_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading news,try again.";
                }
            }

            try { 
            ic = string.Format("ms-appx:///Assets/mashable.png");
            for (int i = 0; i < mashable_news.articles.Count; i++)
            {
                mashable_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/buzzfeed.jpg");
            for (int i = 0; i < buzzfeed_news.articles.Count; i++)
            {
                buzzfeed_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/ew.png");
            for (int i = 0; i < entertainment_weekly_news.articles.Count; i++)
            {
                entertainment_weekly_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
               
            }
            ic = string.Format("ms-appx:///Assets/dailymail.jpg");
            for (int i = 0; i < daily_mail_news.articles.Count; i++)
            {
                daily_mail_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception ) { }
            daily_mail_news = check(daily_mail_news);
            entertainment_weekly_news = check(entertainment_weekly_news);
            mashable_news = check(mashable_news);
            buzzfeed_news = check(buzzfeed_news);

            try { 
            for (int i = 0; i < 1; i++)
            {
                enter_fun_main.Add(entertainment_weekly_news.articles[i]);
                enter_fun_main.Add(mashable_news.articles[i]);
    
                enter_fun_main.Add(daily_mail_news.articles[i]);
            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            try { 
            for (int i = 1; i < 5; i++)
            {
                if(mashable_news.articles[i].urlToImage!=null)
                enter_fun_sub.Add(mashable_news.articles[i]);
                if (entertainment_weekly_news.articles[i].urlToImage != null)
                    enter_fun_sub.Add(entertainment_weekly_news.articles[i]);
                if (daily_mail_news.articles[i].urlToImage != null)
                    enter_fun_sub.Add(daily_mail_news.articles[i]);
                if (buzzfeed_news.articles[i].urlToImage != null)
                    enter_fun_sub.Add(buzzfeed_news.articles[i]);

            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            entertainment_fun_text.Visibility = Visibility.Visible;
            try
            {
                mtv_news = await populate.mtv_Async();
                mtv_news_uk = await populate.mtv_uk_Async();
                the_lad_bible_news = await populate.lad_bible_Async();
            }

            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/mtv.png");
            for (int i = 0; i < mtv_news.articles.Count; i++)
            {
               mtv_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/mtv.png");
            for (int i = 0; i < mtv_news_uk.articles.Count; i++)
            {
                mtv_news_uk.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/bible.jpg");
            for (int i = 0; i < the_lad_bible_news.articles.Count; i++)
            {
                the_lad_bible_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            mtv_news = check(mtv_news);
            mtv_news_uk = check(mtv_news_uk);
            the_lad_bible_news = check(the_lad_bible_news);
            
            if (buzzfeed_news.articles[0].urlToImage!=null)
            more_enter_fun.Add(buzzfeed_news.articles[0]);
            Uri uriResult;
            for (int i = 0; i < 30; i++)
            {
                if (i < the_lad_bible_news.articles.Count && the_lad_bible_news.articles[i].urlToImage != null)
                    more_enter_fun.Add(the_lad_bible_news.articles[i]);
                if (i < mtv_news.articles.Count && mtv_news.articles[i].urlToImage != null)
                   more_enter_fun.Add(mtv_news.articles[i]);


                if (i < mtv_news_uk.articles.Count && mtv_news_uk.articles[i].urlToImage != null && Uri.TryCreate(mtv_news_uk.articles[i].url, UriKind.RelativeOrAbsolute, out uriResult))
                    more_enter_fun.Add(mtv_news_uk.articles[i]);
            }


            for (int i = 5; i < 15; i++)
            {
                if (i < mashable_news.articles.Count && mashable_news.articles[i].urlToImage != null)
                    more_enter_fun.Add(mashable_news.articles[i]);
                if (i < buzzfeed_news.articles.Count && buzzfeed_news.articles[i].urlToImage != null)
                    more_enter_fun.Add(buzzfeed_news.articles[i]);
                if (i < daily_mail_news.articles.Count && daily_mail_news.articles[i].urlToImage != null)
                    more_enter_fun.Add(daily_mail_news.articles[i]);
                if (i < entertainment_weekly_news.articles.Count && entertainment_weekly_news.articles[i].urlToImage != null)
                    more_enter_fun.Add(entertainment_weekly_news.articles[i]);
            }



            More_enter_fun_news_click.Visibility = Visibility.Visible;
          
            sports_news();
        }
        private async void sports_news()
        {
            sports_text.Visibility = Visibility.Collapsed;
            More_sports_news_click_button.Visibility = Visibility.Collapsed;
            try { 
                bbc_sports_news = await populate.bbc_sport_Async();
                espn_news = await populate.espn_Async();
                fox_sports_news = await populate.fox_sports_Async();
                sky_sports_news = await populate.sky_sports_Async();
                talk_sports_news = await populate.talk_sports_Async();
                sports_bible_news = await populate.sport_bible_Async();
            }

            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading news,try again.";
                }
            }

            try { 
            ic = string.Format("ms-appx:///Assets/bbc_sport.jpg");
            for (int i = 0; i < bbc_sports_news.articles.Count; i++)
            {
                bbc_sports_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/talk_sport.png");
            for (int i = 0; i < talk_sports_news.articles.Count; i++)
            {
                talk_sports_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/espn.png");
            for (int i = 0; i < espn_news.articles.Count; i++)
            {
                espn_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/sky_sports.jpg");
            for (int i = 0; i < sky_sports_news.articles.Count; i++)
            {
                sky_sports_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/foxs.jpg");
            for (int i = 0; i < fox_sports_news.articles.Count; i++)
            {
                fox_sports_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));

            }
            ic = string.Format("ms-appx:///Assets/sport_bible.png");
            for (int i = 0; i < sports_bible_news.articles.Count; i++)
            {
                sports_bible_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception ) { }
            espn_news = check(espn_news);
            fox_sports_news = check(fox_sports_news);
            bbc_sports_news = check(bbc_sports_news);
            sky_sports_news = check(sky_sports_news);
            talk_sports_news = check(talk_sports_news);
            sports_bible_news = check(sports_bible_news);
            try { 
            for (int i = 0; i < 1; i++)
                {
                    if (espn_news.articles[i].urlToImage != null)
                        sports_news_1.Add(espn_news.articles[i]);

                    if (fox_sports_news.articles[i].urlToImage != null)
                        sports_news_1.Add(fox_sports_news.articles[i]);

                    if (bbc_news.articles[i].urlToImage != null)
                        sports_news_1.Add(bbc_sports_news.articles[i]);

                }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            try { 
                for (int i = 1; i < 5; i++)
                {
                    if (bbc_sports_news.articles[i].urlToImage != null && i < bbc_sports_news.articles.Count)
                        sports_news_2.Add(bbc_sports_news.articles[i]);

                    if (fox_sports_news.articles[i].urlToImage != null && i < fox_sports_news.articles.Count)
                        sports_news_2.Add(fox_sports_news.articles[i]);

                    if (espn_news.articles[i].urlToImage != null && i < espn_news.articles.Count)
                        sports_news_2.Add(espn_news.articles[i]);
                if (sports_bible_news.articles[i].urlToImage != null && i < sports_bible_news.articles.Count)
                    sports_news_2.Add(sports_bible_news.articles[i]);


            }
            }
            catch(Exception )
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";
            }
            sports_text.Visibility = Visibility.Visible;

            try

            {
                football_italia_news = await populate.football_italia_Async();
                four_four_two_news = await populate.four_our_two_Async();
                fox_sports_latest_news = await populate.fox_sports_latest_Async();
            }
         
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/football_italia.jpg");
            for (int i = 0; i < football_italia_news.articles.Count; i++)
            {
                football_italia_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }

            ic = string.Format("ms-appx:///Assets/foxs.jpg");
            for (int i = 0; i < fox_sports_latest_news.articles.Count; i++)
            {
                fox_sports_latest_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/fft.jpg");
            for (int i = 0; i < four_four_two_news.articles.Count; i++)
            {
                four_four_two_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }

            }
            catch(Exception ) { }
            football_italia_news = check(football_italia_news);
            four_four_two_news = check(four_four_two_news);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (football_italia_news.articles[i].urlToImage != null && i < football_italia_news.articles.Count)
                        more_sports_news.Add(football_italia_news.articles[i]);
                    if (fox_sports_latest_news.articles[i].urlToImage != null && i < fox_sports_latest_news.articles.Count)
                        more_sports_news.Add(fox_sports_latest_news.articles[i]);

                    if (talk_sports_news.articles[i].urlToImage != null && i < talk_sports_news.articles.Count)
                        more_sports_news.Add(talk_sports_news.articles[i]);
                }
            }
            catch (Exception)
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";

            }
            try
            {
                for (int i = 0; i < sky_sports_news.articles.Count; i++)
                {
                    if (sky_sports_news.articles[i].urlToImage != null && i < sky_sports_news.articles.Count)
                        more_sports_news.Add(sky_sports_news.articles[i]);
                }
            }
            catch (Exception)
            {
                about_text.FontSize = 15;

                about_text.Text = "Error in getting some news";

            }

            for (int i = 0; i < four_four_two_news.articles.Count; i++)
                {

                    if (four_four_two_news.articles[i].urlToImage != null && i < four_four_two_news.articles.Count)
                    more_sports_news.Add(four_four_two_news.articles[i]);
            }
            
            try { 
            for (int i = 0; i < 4; i++)
            {
                if (talk_sports_news.articles[i].urlToImage != null && i < talk_sports_news.articles.Count)
                    more_sports_news.Add(talk_sports_news.articles[i]);

                if (sports_bible_news.articles[i].urlToImage != null && i < sports_bible_news.articles.Count)
                    more_sports_news.Add(sports_bible_news.articles[i]);

            }

            }
            catch(Exception ) { }
            try
            {
                nfl_news = await populate.nfl_news_Async();
                nfl_latest_news = await populate.nfl_latest_news_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/nfl.jpg");
            for (int i = 0; i < nfl_latest_news.articles.Count; i++)
            {
                nfl_latest_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/nfl.jpg");
            for (int i = 0; i < nfl_news.articles.Count; i++)
            {
                nfl_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch (Exception ) { }
            nfl_news = check(nfl_news);
            nfl_latest_news = check(nfl_latest_news);
            try { 
            for (int i = 0; i < nfl_news.articles.Count; i++)
            {
                if(nfl_news.articles[i].urlToImage!=null)
                nfl_all.Add(nfl_news.articles[i]);
            }
            }
            catch(Exception ) { }
            int c = nfl_latest_news.articles.Count;
            int d = nfl_news.articles.Count;
            if (c < d) { }
            else
            {
                c = d;
            }
            try { 
            for (int i = 0; i <c; i++)
            {
                if (nfl_news.articles != nfl_latest_news.articles)
                {
                    if(nfl_latest_news.articles[i].urlToImage!=null)
                    nfl_all.Add(nfl_latest_news.articles[i]);
                }
            }
            }
            catch(Exception ) { }
            try
            {

                cric_info_news = await populate.cric_info_sport_Async();
                cric_info_latest_news = await populate.cric_info_latest_Async();
            }
            catch (Exception e)
            {
                if (e.Message == "An error occurred while sending the request.")
                {
                    about_text.Text = "no connection";
                    dock_ring.Visibility = Visibility.Collapsed;
                }
                else
                {
                    about_text.FontSize = 15;

                    about_text.Text = "Error in loading news,try again.";
                }
            }
            try { 
            ic = string.Format("ms-appx:///Assets/cric_info.png");
            for (int i = 0; i < cric_info_news.articles.Count; i++)
            {
                cric_info_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            ic = string.Format("ms-appx:///Assets/cric_info.png");
            for (int i = 0; i < cric_info_latest_news.articles.Count; i++)
            {
                cric_info_latest_news.articles[i].image = new BitmapImage(new Uri(ic, UriKind.Absolute));
            }
            }
            catch(Exception ) { }
            cric_info_latest_news = check(cric_info_latest_news);
            cric_info_news = check(cric_info_news);
            try { 
            for (int i = 0; i < cric_info_news.articles.Count; i++)
            {
                if (cric_info_news.articles[i].urlToImage != null)
                    cricket_news.Add(cric_info_news.articles[i]);
            }
          
            }
            catch(Exception ) { }
            int a = cric_info_latest_news.articles.Count;
            int b = cric_info_news.articles.Count;
            if (a < b)
            {

            }
            else
                a = b;
            try { 
            for (int i = 0; i < a; i++)
            {
                if (cric_info_latest_news.articles[i] != cric_info_news.articles[i])
                {

                    if (cric_info_latest_news.articles[i].urlToImage != null)
                        cricket_news.Add(cric_info_latest_news.articles[i]);
                }
            }
            }
            catch(Exception ) { }
            about_text.FontSize = 30;
            about_text.Text = "Newsin";
            dock_ring.IsActive = false;
            More_sports_news_click_button.Visibility = Visibility.Visible;


        }
        private void More_hot_news_Click(object sender, RoutedEventArgs e)
        {
            main_scroll_viewer.Visibility = Visibility.Collapsed;


            more_hot_news_us_grid.Visibility = Visibility.Visible;

            about_icon.Visibility = Visibility.Visible;

        }


        private void back_to_main_page_button_Click(object sender, RoutedEventArgs e)
        {
            main_scroll_viewer.Visibility = Visibility.Visible;
            more_hot_news_us_grid.Visibility = Visibility.Collapsed;
            about_icon.Visibility = Visibility.Visible;
        }

        private void to_india_page_button_Click(object sender, RoutedEventArgs e)
        {

            about_icon.Visibility = Visibility.Visible;
            india_news_grid.Visibility = Visibility.Visible;
            more_hot_news_us_grid.Visibility = Visibility.Collapsed;
        }

        private void back_to_more_hot_news_us_button_Click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
            india_news_grid.Visibility = Visibility.Collapsed;
            more_hot_news_us_grid.Visibility = Visibility.Visible;
        }

        private void More_news_buisness_Click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
            main_scroll_viewer.Visibility = Visibility.Collapsed;
            more_news_buisness_grid.Visibility = Visibility.Visible;
        }

        private void back_to_main_page_button_From_buisness_grid_Click(object sender, RoutedEventArgs e)
        {
           about_icon.Visibility = Visibility.Visible;
            more_news_buisness_grid.Visibility = Visibility.Collapsed;
            main_scroll_viewer.Visibility = Visibility.Visible;
        }

        private void ScrollViewer_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            e.Handled = true;
        }

        private void back_to_main_page_button_From_tech_grid_Click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
            more_news_tech_grid.Visibility = Visibility.Collapsed;
            main_scroll_viewer.Visibility = Visibility.Visible;

        }

        private void More_tech_news_Click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
            main_scroll_viewer.Visibility = Visibility.Collapsed;
            more_news_tech_grid.Visibility = Visibility.Visible;
        }

        private void More_enter_fun_news_Click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
            main_scroll_viewer.Visibility = Visibility.Collapsed;
            more_enter_fun_grid.Visibility = Visibility.Visible;
        }

        private void back_to_main_page_button_From_enter_fun_grid_Click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
            more_enter_fun_grid.Visibility = Visibility.Collapsed;
            main_scroll_viewer.Visibility = Visibility.Visible;
        }

            private void More_sports_news_click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
            main_scroll_viewer.Visibility = Visibility.Collapsed;
            more_sports_news_grid.Visibility = Visibility.Visible;
        }

        private void back_to_main_page_button_From_sports_grid_Click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
           main_scroll_viewer.Visibility = Visibility.Visible;
            more_sports_news_grid.Visibility = Visibility.Collapsed;
        }


        private void hyperlink_button_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            HyperlinkButton hyper = sender as HyperlinkButton;

        }

        private void to_uk_page_button_Click(object sender, RoutedEventArgs e)
        {
            about_icon.Visibility = Visibility.Visible;
            india_news_grid.Visibility = Visibility.Collapsed;
            uk_news_grid.Visibility = Visibility.Visible;
        }


        private void back_to_more_hot_news_ind_button_Click(object sender, RoutedEventArgs e)
        {

            about_icon.Visibility = Visibility.Visible;
            india_news_grid.Visibility = Visibility.Visible;
            uk_news_grid.Visibility = Visibility.Collapsed;

        }
    private void home_menu_button_click(object sender, RoutedEventArgs e)
        {
            about_menu.Visibility = Visibility.Collapsed;
            more_hot_news_us_grid.Visibility = Visibility.Collapsed;
            more_news_buisness_grid.Visibility = Visibility.Collapsed;
            more_news_tech_grid.Visibility = Visibility.Collapsed;
            more_enter_fun_grid.Visibility = Visibility.Collapsed;
            more_sports_news_grid.Visibility = Visibility.Collapsed;
            nfl_grid.Visibility = Visibility.Collapsed;
            cricket_grid.Visibility = Visibility.Collapsed;
            india_news_grid.Visibility = Visibility.Collapsed;
            uk_news_grid.Visibility = Visibility.Collapsed;
            about_icon.Visibility = Visibility.Visible;
            main_scroll_viewer.Visibility = Visibility.Visible;
        
        }
        private void clear()
        {
            big_hot_news.Clear();
            medium_hot_news.Clear();
            small_hot_news.Clear();
            more_hot_news_us.Clear();
            more_hot_news_ind.Clear();
            more_hot_news_uk.Clear();
            featured_story.Clear();
            buisness_news_1.Clear();
            buisness_news_2.Clear();
            buisness_news_wsj.Clear();
            buisness_news_ft.Clear();
            buisness_news_te.Clear();
            tech1.Clear();
            tech2.Clear();
            tech3.Clear();
            techs.Clear();
            tech_more.Clear();
            featured_story_1.Clear();
            enter_fun_main.Clear();
            enter_fun_sub.Clear();
            more_enter_fun.Clear();
            sports_news_1.Clear();
            sports_news_2.Clear();
            more_sports_news.Clear();
            cricket_news.Clear();

    }
    private void refresh_icon_Click(object sender, RoutedEventArgs e)
        {
            clear();
            clear();
            clear();
            offvisible();
            get_first_news();
        }
        private void offvisible()
        {

            Top_news_text.Visibility = Visibility.Collapsed;
            buisness_text.Visibility = Visibility.Collapsed;
            tech_text.Visibility = Visibility.Collapsed;
            featured_story_text.Visibility = Visibility.Collapsed;
            featured_story_text1.Visibility = Visibility.Collapsed;
            entertainment_fun_text.Visibility = Visibility.Collapsed;
            sports_text.Visibility = Visibility.Collapsed;
            More_tech_news.Visibility = Visibility.Collapsed;

            More_hot_news_button_us.Visibility = Visibility.Collapsed;
            More_enter_fun_news_click.Visibility = Visibility.Collapsed;
            More_news_buisness_button.Visibility = Visibility.Collapsed;
            More_sports_news_click_button.Visibility = Visibility.Collapsed;
           
        }

        private void night_mode_icon_Click(object sender, RoutedEventArgs e)
        {
            
            main_grid.Background = new SolidColorBrush(Colors.Black);
            
                       about_icon.Foreground = new SolidColorBrush(Colors.Black);
                refresh_icon.Foreground = new SolidColorBrush(Colors.Black);
                home_icon.Foreground = new SolidColorBrush(Colors.Black);

            More_hot_news_button_us.Background= new SolidColorBrush(Colors.Black);
            More_hot_news_button_us.Foreground = new SolidColorBrush(Colors.White);
            More_enter_fun_news_click.Background = new SolidColorBrush(Colors.Black);

            More_enter_fun_news_click.Foreground = new SolidColorBrush(Colors.White);
            More_sports_news_click_button.Background = new SolidColorBrush(Colors.Black);

            More_sports_news_click_button.Foreground = new SolidColorBrush(Colors.White);
            More_news_buisness_button.Background = new SolidColorBrush(Colors.Black);

            More_news_buisness_button.Foreground = new SolidColorBrush(Colors.White);
            More_tech_news.Background = new SolidColorBrush(Colors.Black);

            More_tech_news.Foreground = new SolidColorBrush(Colors.White);
            back_to_more_hot_news_ind_button.Foreground = new SolidColorBrush(Colors.White);
            back_to_more_hot_news_ind_button.Background = new SolidColorBrush(Colors.Black);
            to_india_page_button.Foreground = new SolidColorBrush(Colors.White);
            to_india_page_button.Background = new SolidColorBrush(Colors.Black);

            to_uk_page_button.Foreground = new SolidColorBrush(Colors.White);
            to_uk_page_button.Background = new SolidColorBrush(Colors.Black);

            to_nfl_page.Foreground = new SolidColorBrush(Colors.White);
            to_nfl_page.Background = new SolidColorBrush(Colors.Black);
            to_cricket_page_button.Foreground = new SolidColorBrush(Colors.White);
            to_cricket_page_button.Background = new SolidColorBrush(Colors.Black);

            back_to_football_grid_button.Foreground = new SolidColorBrush(Colors.White);
            back_to_football_grid_button.Background = new SolidColorBrush(Colors.Black);
            back_to_main_page_button.Foreground = new SolidColorBrush(Colors.White);
            back_to_main_page_button.Background = new SolidColorBrush(Colors.Black);

            back_to_main_page_button_From_buisness_grid.Foreground = new SolidColorBrush(Colors.White);
           back_to_main_page_button_From_buisness_grid.Background = new SolidColorBrush(Colors.Black);

            back_to_main_page_button_From_enter_fun_grid.Foreground = new SolidColorBrush(Colors.White);
            back_to_main_page_button_From_enter_fun_grid.Background = new SolidColorBrush(Colors.Black);

            back_to_main_page_fromm_sports_grid.Foreground = new SolidColorBrush(Colors.White);
            back_to_main_page_fromm_sports_grid.Background = new SolidColorBrush(Colors.Black);
            back_to_main_page_button_From_tech_grid.Foreground = new SolidColorBrush(Colors.White);
            back_to_main_page_button_From_tech_grid.Background = new SolidColorBrush(Colors.Black);
            back_to_more_hot_news_ind_button.Foreground = new SolidColorBrush(Colors.White);
            back_to_more_hot_news_ind_button.Background = new SolidColorBrush(Colors.Black);

            back_to_nfl_Page_button.Foreground = new SolidColorBrush(Colors.White);
            back_to_nfl_Page_button.Background = new SolidColorBrush(Colors.Black);
            back_to_more_hot_news_us_button.Foreground = new SolidColorBrush(Colors.White);

            back_to_more_hot_news_us_button.Background = new SolidColorBrush(Colors.Black);

            featured_news_grid.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            featured_news_grid_1.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            ic = string.Format("ms-appx:///Assets/blacl_logo.png");

            about_image.Source = new BitmapImage(new Uri(ic, UriKind.Absolute));
        
        main_scroll_viewer.Foreground = new SolidColorBrush(Colors.Black);

            about1.Foreground= new SolidColorBrush(Colors.White);

            about2.Foreground = new SolidColorBrush(Colors.White);

            about3.Foreground = new SolidColorBrush(Colors.White);

            about4.Foreground = new SolidColorBrush(Colors.White);

            about5.Foreground = new SolidColorBrush(Colors.White);
        }

        private void about_Button_Click(object sender, RoutedEventArgs e)
        {
            about_menu.Visibility = Visibility.Visible;
            main_scroll_viewer.Visibility = Visibility.Collapsed;
            more_hot_news_us_grid.Visibility = Visibility.Collapsed;
            more_news_tech_grid.Visibility = Visibility.Collapsed;
            more_news_buisness_grid.Visibility = Visibility.Collapsed;
            more_sports_news_grid.Visibility = Visibility.Collapsed;
            india_news_grid.Visibility = Visibility.Collapsed;
            more_enter_fun_grid.Visibility = Visibility.Collapsed;
            nfl_grid.Visibility = Visibility.Collapsed;
            cricket_grid.Visibility = Visibility.Collapsed;
            uk_news_grid.Visibility = Visibility.Collapsed;
        }

        private void white_mode_icon_Click(object sender, RoutedEventArgs e)
        {
            main_grid.Background = new SolidColorBrush(Colors.White);
            about_icon.Foreground = new SolidColorBrush(Colors.White);
            refresh_icon.Foreground = new SolidColorBrush(Colors.White);
            home_icon.Foreground = new SolidColorBrush(Colors.White);
            More_hot_news_button_us.Foreground = new SolidColorBrush(Colors.Black);
            More_enter_fun_news_click.Background = new SolidColorBrush(Colors.White);
            More_hot_news_button_us.Background = new SolidColorBrush(Colors.White);
            More_hot_news_button_us.Foreground = new SolidColorBrush(Colors.Black);

            More_enter_fun_news_click.Foreground = new SolidColorBrush(Colors.Black);
            More_sports_news_click_button.Background = new SolidColorBrush(Colors.White);

            More_sports_news_click_button.Foreground = new SolidColorBrush(Colors.Black);
            More_news_buisness_button.Background = new SolidColorBrush(Colors.White);

            More_news_buisness_button.Foreground = new SolidColorBrush(Colors.Black);
            More_tech_news.Background = new SolidColorBrush(Colors.White);

            More_tech_news.Foreground = new SolidColorBrush(Colors.Black);


            back_to_more_hot_news_ind_button.Foreground = new SolidColorBrush(Colors.Black);
            back_to_more_hot_news_ind_button.Background = new SolidColorBrush(Colors.White);
            to_india_page_button.Foreground = new SolidColorBrush(Colors.Black);
            to_india_page_button.Background = new SolidColorBrush(Colors.White);

            to_uk_page_button.Foreground = new SolidColorBrush(Colors.Black);
            to_uk_page_button.Background = new SolidColorBrush(Colors.White);

            to_nfl_page.Foreground = new SolidColorBrush(Colors.Black);
            to_nfl_page.Background = new SolidColorBrush(Colors.White);
            to_cricket_page_button.Foreground = new SolidColorBrush(Colors.Black);
            to_cricket_page_button.Background = new SolidColorBrush(Colors.White);

            back_to_football_grid_button.Foreground = new SolidColorBrush(Colors.Black);
            back_to_football_grid_button.Background = new SolidColorBrush(Colors.White);
            back_to_main_page_button.Foreground = new SolidColorBrush(Colors.Black);
            back_to_main_page_button.Background = new SolidColorBrush(Colors.White);

            back_to_main_page_button_From_buisness_grid.Foreground = new SolidColorBrush(Colors.Black);
            back_to_main_page_button_From_buisness_grid.Background = new SolidColorBrush(Colors.White);

            back_to_main_page_button_From_enter_fun_grid.Foreground = new SolidColorBrush(Colors.Black);
            back_to_main_page_button_From_enter_fun_grid.Background = new SolidColorBrush(Colors.White);

            back_to_main_page_fromm_sports_grid.Foreground = new SolidColorBrush(Colors.Black);
            back_to_main_page_fromm_sports_grid.Background = new SolidColorBrush(Colors.White);
            back_to_main_page_button_From_tech_grid.Foreground = new SolidColorBrush(Colors.Black);
            back_to_main_page_button_From_tech_grid.Background = new SolidColorBrush(Colors.White);
            back_to_more_hot_news_ind_button.Foreground = new SolidColorBrush(Colors.Black);
            back_to_more_hot_news_ind_button.Background = new SolidColorBrush(Colors.White);

            back_to_nfl_Page_button.Foreground = new SolidColorBrush(Colors.Black);
            back_to_nfl_Page_button.Background = new SolidColorBrush(Colors.White);
            back_to_more_hot_news_us_button.Foreground = new SolidColorBrush(Colors.Black);

            back_to_more_hot_news_us_button.Background = new SolidColorBrush(Colors.White);

            featured_news_grid.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            featured_news_grid_1.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            main_scroll_viewer.Foreground = new SolidColorBrush(Colors.White);
            ic = string.Format("ms-appx:///Assets/app icon2.jpg");

            about_image.Source = new BitmapImage(new Uri(ic, UriKind.Absolute));

            about1.Foreground = new SolidColorBrush(Colors.Black);

            about2.Foreground = new SolidColorBrush(Colors.Black);

            about3.Foreground = new SolidColorBrush(Colors.Black);

            about4.Foreground = new SolidColorBrush(Colors.Black);

            about5.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void to_nfl_page_Click(object sender, RoutedEventArgs e)
        {
            more_sports_news_grid.Visibility = Visibility.Collapsed;
            nfl_grid.Visibility = Visibility.Visible;
        }

        private void back_to_football_grid_button_Click(object sender, RoutedEventArgs e)
        {
            more_sports_news_grid.Visibility = Visibility.Visible;
            cricket_grid.Visibility = Visibility.Collapsed;
            nfl_grid.Visibility = Visibility.Collapsed;
        }

        private void to_cricket_page_button_Click(object sender, RoutedEventArgs e)
        {
            cricket_grid.Visibility = Visibility.Visible;
            nfl_grid.Visibility = Visibility.Collapsed;

        }

        private void back_to_nfl_Page_button_Click(object sender, RoutedEventArgs e)
        {

            cricket_grid.Visibility = Visibility.Collapsed;
            nfl_grid.Visibility = Visibility.Visible;
        }
        
        
    }
    }
