using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace MovieAPI.Models
{
    public class MovieDAL 
    {
        public static MovieModel GetMovie(string movie)//Adjust here
        {
            //setup
            //adjustMovie

            string url = $"http://www.omdbapi.com/?i=tt3896198&apikey=51304208&t={movie}"; //link to api

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //Adjust
            //Convert to c#            //show potential fixes - find and install Newtonsoft.json
            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(json);
            return result;

        }
    }
}
